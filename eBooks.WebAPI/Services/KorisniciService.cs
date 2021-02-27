using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eBooks.Model;
using eBooks.Model.Requests;
using eBooks.WebAPI.Database;
using eBooks.WebAPI.Exceptions;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace eBooks.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly _140256Context _context;
        private readonly IMapper _mapper;

        public KorisniciService(_140256Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(Model.Requests.KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.StartsWith(request.KorisnickoIme, StringComparison.CurrentCultureIgnoreCase));
            }

            var list = query.Include(i => i.KorisniciUloge).ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var korisnik = _context.Korisnici.Include(i => i.KorisniciUloge).Where(w => w.KorisnikId == id).FirstOrDefault();

            return _mapper.Map<Model.Korisnici>(korisnik);
        }

        public Model.Korisnici Insert(KorisniciUpsertRequest request)
        {
            var korisnik = _mapper.Map<Database.Korisnici>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            korisnik.LozinkaSalt = Util.Helper.GenerateSalt();
            korisnik.LozinkaHash = Util.Helper.GenerateHash(korisnik.LozinkaSalt, request.Password);

            _context.Korisnici.Add(korisnik);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                Database.KorisniciUloge korisniciUloge = new Database.KorisniciUloge();

                korisniciUloge.KorisnikId = korisnik.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;

                _context.KorisniciUloge.Add(korisniciUloge);
            }
            _context.SaveChanges();

            var result = _context.Korisnici.Include(i => i.KorisniciUloge).Where(w => w.KorisnikId == korisnik.KorisnikId).FirstOrDefault();

            return _mapper.Map<Model.Korisnici>(result);
        }

        public Model.Korisnici Update(int id, KorisniciUpsertRequest request)
        {
            var entity = _context.Korisnici.Include(i => i.KorisniciUloge).Where(w => w.KorisnikId == id).FirstOrDefault();
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = Util.Helper.GenerateSalt();
                entity.LozinkaHash = Util.Helper.GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Autentificiraj(string username, string password)
        {
            var user = _context.Korisnici.Include("KorisniciUloge.Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = Util.Helper.GenerateHash(user.LozinkaSalt, password);

                if (hashedPass == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }
            return null;
        }
    }
}

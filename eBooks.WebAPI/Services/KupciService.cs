using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBooks.Model;
using eBooks.Model.Requests;
using eBooks.WebAPI.Database;

namespace eBooks.WebAPI.Services
{
    public class KupciService : IKupciService
    {
        private readonly _140256Context _context;
        private readonly IMapper _mapper;

        public KupciService(_140256Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Kupci> Get(KupciSearchRequest request)
        {
            var query = _context.Kupci.AsQueryable();

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

            var list = query.ToList();

            return _mapper.Map<List<Model.Kupci>>(list);
        }

        public Model.Kupci GetById(int id)
        {
            var kupac = _context.Kupci.Find(id);
            return _mapper.Map<Model.Kupci>(kupac);
        }

        public Model.Kupci GetByUsername(string request)
        {
            var entity = _context.Kupci.Where(w => w.KorisnickoIme == request).FirstOrDefault();

            var r = _mapper.Map<Model.Kupci>(entity);

            return r;
        }

        public Model.Kupci Insert(KupciUpsertRequest request)
        {
            var kupac = _mapper.Map<Database.Kupci>(request);

            kupac.LozinkaSalt = Util.Helper.GenerateSalt();
            kupac.LozinkaHash = Util.Helper.GenerateHash(kupac.LozinkaSalt, request.Password);

            _context.Kupci.Add(kupac);
            _context.SaveChanges();

            return _mapper.Map<Model.Kupci>(kupac);
        }

        public Model.Kupci Update(int id, KupciUpsertRequest request)
        {
            var entity = _context.Kupci.Find(id);
            _context.Kupci.Attach(entity);
            _context.Kupci.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                entity.LozinkaSalt = Util.Helper.GenerateSalt();
                entity.LozinkaHash = Util.Helper.GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Kupci>(entity);
        }
    }
}

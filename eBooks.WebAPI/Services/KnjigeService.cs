using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBooks.Model;
using eBooks.Model.Requests;
using eBooks.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eBooks.WebAPI.Services
{
    public class KnjigeService : BaseCRUDService<Model.Knjige, Model.Requests.KnjigeSearchRequest, Database.Knjige, Model.Requests.KnjigeUpsertRequest, Model.Requests.KnjigeUpsertRequest>
    {
        public KnjigeService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Knjige> Get(KnjigeSearchRequest search)
        {

            var query = _context.Knjige.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv != null && x.Naziv.StartsWith(search.Naziv, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(search?.OriginalniNaziv))
            {
                query = query.Where(x => x.OriginalniNaziv != null && x.OriginalniNaziv.StartsWith(search.OriginalniNaziv, StringComparison.CurrentCultureIgnoreCase));
            }

            if (search?.IsAutorLoadingEnabled == true)
            {
                query = query.Include(x => x.AutoriKnjige);

                var list = query.ToList();
                var list2 = new List<Model.Knjige>();

                foreach (var x in list)
                {
                    var p = new Model.Knjige();
                    _mapper.Map(x, p);
                    p.AutoriKnjige = new List<Model.AutoriKnjige>();
                    foreach (var y in x.AutoriKnjige)
                    {
                        p.AutoriKnjige.Add(new Model.AutoriKnjige()
                        {
                            AutorId = y.AutorId,
                            KnjigaId = y.KnjigaId
                        });
                    };
                    list2.Add(p);
                }
                return list2;
            }

            if (search?.IsIzdavacLoadingEnabled == true)
            {
                query = query.Include(x => x.Izdavac);
            }

            var knjige = query.ToList();

            return _mapper.Map<List<Model.Knjige>>(knjige);
        }

        public override Model.Knjige GetById(int id)
        {
            var knjiga = _context.Knjige.Include(i => i.Izdavac).Include(t => t.Kolekcija).Include(n => n.KnjigeKategorije).Where(w => w.KnjigaId == id).FirstOrDefault();

            var entity = _mapper.Map<Model.Knjige>(knjiga);

            if (knjiga.Kolekcija != null)
            {
                entity.Kolekcija = knjiga.Kolekcija.Naziv;
                entity.KolekcijaOriginalniNaziv = knjiga.Kolekcija.OriginalniNaziv;
            }

            return entity;
        }
    }
}

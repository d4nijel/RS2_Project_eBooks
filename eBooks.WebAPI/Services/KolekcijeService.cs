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
    public class KolekcijeService : BaseCRUDService<Model.Kolekcije, Model.Requests.KolekcijeSearchRequest, Database.Kolekcije, Model.Requests.KolekcijeUpsertRequest, Model.Requests.KolekcijeUpsertRequest>
    {
        public KolekcijeService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Kolekcije> Get(KolekcijeSearchRequest search)
        {
            var query = _context.Kolekcije.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv != null && x.Naziv.StartsWith(search.Naziv, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(search?.OriginalniNaziv))
            {
                query = query.Where(x => x.OriginalniNaziv != null && x.OriginalniNaziv.StartsWith(search.OriginalniNaziv, StringComparison.CurrentCultureIgnoreCase));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Kolekcije>>(list);
        }

        public override Model.Kolekcije GetById(int id)
        {
            var entity = _context.Kolekcije.Include(i => i.Knjige).Where(w => w.KolekcijaId == id).FirstOrDefault();
            return _mapper.Map<Model.Kolekcije>(entity);
        }
    }
}

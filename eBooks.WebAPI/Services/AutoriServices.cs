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
    public class AutoriServices : BaseCRUDService<Model.Autori, Model.Requests.AutoriSearchRequest, Database.Autori, Model.Requests.AutoriUpsertRequest, Model.Requests.AutoriUpsertRequest>
    {
        public AutoriServices(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Autori> Get(AutoriSearchRequest search)
        {
            var query = _context.Autori.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime != null && x.Ime.StartsWith(search.Ime, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime != null && x.Prezime.StartsWith(search.Prezime, StringComparison.CurrentCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(search?.Pseudonim))
            {
                query = query.Where(x => x.Pseudonim != null && x.Pseudonim.StartsWith(search.Pseudonim, StringComparison.CurrentCultureIgnoreCase));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Autori>>(list);
        }
    }
}

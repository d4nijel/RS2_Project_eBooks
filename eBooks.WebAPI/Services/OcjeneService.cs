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
    public class OcjeneService : BaseCRUDService<Model.Ocjene, Model.Requests.OcjeneSearchRequest, Database.Ocjene, Model.Requests.OcjeneUpsertRequest, Model.Requests.OcjeneUpsertRequest>
    {
        public OcjeneService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Ocjene> Get(OcjeneSearchRequest search)
        {
            var query = _context.Ocjene.AsQueryable();

            if (search.KupacId != null)
            {
                query = query.Where(x => x.KupacId == search.KupacId);
            }

            if (search.KnjigaId != null)
            {
                query = query.Where(x => x.KnjigaId == search.KnjigaId);
            }

            query = query.OrderByDescending(o => o.Datum);

            var list = query.ToList();

            return _mapper.Map<List<Model.Ocjene>>(list);
        }
    }
}

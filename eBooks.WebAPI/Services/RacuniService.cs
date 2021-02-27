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
    public class RacuniService : BaseCRUDService<Model.Racuni, Model.Requests.RacuniSearchRequest, Database.Racuni, Model.Requests.RacuniUpsertRequest, Model.Requests.RacuniUpsertRequest>
    {
        public RacuniService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Racuni> Get(RacuniSearchRequest search)
        {
            var query = _context.Racuni.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.BrojRacuna))
            {
                query = query.Where(x => x.BrojRacuna.StartsWith(search.BrojRacuna, StringComparison.CurrentCultureIgnoreCase));
            }

            var racuni = query.ToList();

            return _mapper.Map<List<Model.Racuni>>(racuni);
        }
    }
}

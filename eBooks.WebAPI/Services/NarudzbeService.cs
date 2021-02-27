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
    public class NarudzbeService : BaseCRUDService<Model.Narudzbe, Model.Requests.NarudzbeSearchRequest, Database.Narudzbe, Model.Requests.NarudzbeUpsertRequest, Model.Requests.NarudzbeUpsertRequest>
    {
        public NarudzbeService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Narudzbe> Get(NarudzbeSearchRequest search)
        {
            var query = _context.Narudzbe.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.BrojNarudzbe))
            {
                query = query.Where(x => x.BrojNarudzbe.StartsWith(search.BrojNarudzbe, StringComparison.CurrentCultureIgnoreCase));
            }

            var narudzbe = query.ToList();

            return _mapper.Map<List<Model.Narudzbe>>(narudzbe);
        }
    }
}

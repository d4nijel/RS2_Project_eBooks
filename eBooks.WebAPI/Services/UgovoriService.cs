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
    public class UgovoriService : BaseCRUDService<Model.Ugovori, Model.Requests.UgovoriSearchRequest, Database.Ugovori, Model.Requests.UgovoriUpsertRequest, Model.Requests.UgovoriUpsertRequest>
    {
        public UgovoriService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Ugovori> Get(UgovoriSearchRequest search)
        {
            var query = _context.Ugovori.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.BrojUgovora))
            {
                query = query.Where(x => x.BrojUgovora != null && x.BrojUgovora.StartsWith(search.BrojUgovora, StringComparison.CurrentCultureIgnoreCase));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Ugovori>>(list);
        }
    }
}

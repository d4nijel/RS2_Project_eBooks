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
    public class IzdavaciServices : BaseCRUDService<Model.Izdavaci, Model.Requests.IzdavaciSearchRequest, Database.Izdavaci, Model.Requests.IzdavaciUpsertRequest, Model.Requests.IzdavaciUpsertRequest>
    {
        public IzdavaciServices(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Izdavaci> Get(IzdavaciSearchRequest search)
        {
            var query = _context.Izdavaci.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv != null && x.Naziv.StartsWith(search.Naziv, StringComparison.CurrentCultureIgnoreCase));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Izdavaci>>(list);
        }
    }
}

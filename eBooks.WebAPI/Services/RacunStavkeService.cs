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
    public class RacunStavkeService : BaseCRUDService<Model.RacunStavke, Model.Requests.RacunStavkeSearchRequest, Database.RacunStavke, Model.Requests.RacunStavkeUpsertRequest, Model.Requests.RacunStavkeUpsertRequest>
    {
        public RacunStavkeService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.RacunStavke> Get(RacunStavkeSearchRequest search)
        {
            var query = _context.RacunStavke.AsQueryable();

            if (search?.IsKnjigaLoadingEnabled == true)
            {
                query = query.Include(x => x.Knjiga);
            }

            var racunStavke = query.ToList();

            return _mapper.Map<List<Model.RacunStavke>>(racunStavke);
        }
    }
}

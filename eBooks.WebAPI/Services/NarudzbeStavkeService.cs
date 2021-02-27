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
    public class NarudzbeStavkeService : BaseCRUDService<Model.NarudzbaStavke, Model.Requests.NarudzbeStavkeSearchRequest, Database.NarudzbaStavke, Model.Requests.NarudzbeStavkeUpsertRequest, Model.Requests.NarudzbeStavkeUpsertRequest>
    {
        public NarudzbeStavkeService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.NarudzbaStavke> Get(NarudzbeStavkeSearchRequest search)
        {
            var query = _context.NarudzbaStavke.AsQueryable();

            if (search?.IsKnjigaLoadingEnabled == true)
            {
                query = query.Include(x => x.Knjiga);
            }

            var naruzdaStavke = query.ToList();

            return _mapper.Map<List<Model.NarudzbaStavke>>(naruzdaStavke);
        }
    }
}

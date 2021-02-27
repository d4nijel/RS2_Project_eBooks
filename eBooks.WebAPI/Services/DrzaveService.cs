using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBooks.Model;
using eBooks.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eBooks.WebAPI.Services
{
    public class DrzaveService : BaseService<Model.Drzave, object, Database.Drzave>
    {
        public DrzaveService(_140256Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Drzave> Get(object search)
        {
            var list = _context.Drzave.Include(i => i.Gradovi).ToList();
            return _mapper.Map<List<Model.Drzave>>(list);
        }

        public override Model.Drzave GetById(int id)
        {
            var drzava = _context.Drzave.Include(i => i.Gradovi).Where(w => w.DrzavaId == id).FirstOrDefault();
            return _mapper.Map<Model.Drzave>(drzava);
        }
    }
}

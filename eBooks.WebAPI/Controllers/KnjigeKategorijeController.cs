using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBooks.Model;
using eBooks.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBooks.WebAPI.Controllers
{
    public class KnjigeKategorijeController : BaseCRUDController<Model.KnjigeKategorije, object, Model.KnjigeKategorije, Model.KnjigeKategorije>
    {
        public KnjigeKategorijeController(ICRUDService<KnjigeKategorije, object, KnjigeKategorije, KnjigeKategorije> service) : base(service)
        {
        }
    }
}
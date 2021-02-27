using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBooks.Model;
using eBooks.Model.Requests;
using eBooks.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBooks.WebAPI.Controllers
{
    public class KolekcijeController : BaseCRUDController<Model.Kolekcije, Model.Requests.KolekcijeSearchRequest, Model.Requests.KolekcijeUpsertRequest, Model.Requests.KolekcijeUpsertRequest>
    {
        public KolekcijeController(ICRUDService<Kolekcije, KolekcijeSearchRequest, KolekcijeUpsertRequest, KolekcijeUpsertRequest> service) : base(service)
        {
        }
    }
}
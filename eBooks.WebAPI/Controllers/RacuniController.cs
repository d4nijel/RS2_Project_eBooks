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
    public class RacuniController : BaseCRUDController<Model.Racuni, Model.Requests.RacuniSearchRequest, Model.Requests.RacuniUpsertRequest, Model.Requests.RacuniUpsertRequest>
    {
        public RacuniController(ICRUDService<Racuni, RacuniSearchRequest, RacuniUpsertRequest, RacuniUpsertRequest> service) : base(service)
        {
        }
    }
}
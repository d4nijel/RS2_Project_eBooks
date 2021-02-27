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
    public class RacunStavkeController : BaseCRUDController<Model.RacunStavke, Model.Requests.RacunStavkeSearchRequest, Model.Requests.RacunStavkeUpsertRequest, Model.Requests.RacunStavkeUpsertRequest>
    {
        public RacunStavkeController(ICRUDService<RacunStavke, RacunStavkeSearchRequest, RacunStavkeUpsertRequest, RacunStavkeUpsertRequest> service) : base(service)
        {
        }
    }
}
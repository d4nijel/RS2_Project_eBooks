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
    public class OcjeneController : BaseCRUDController<Model.Ocjene, Model.Requests.OcjeneSearchRequest, Model.Requests.OcjeneUpsertRequest, Model.Requests.OcjeneUpsertRequest>
    {
        public OcjeneController(ICRUDService<Ocjene, OcjeneSearchRequest, OcjeneUpsertRequest, OcjeneUpsertRequest> service) : base(service)
        {
        }
    }
}
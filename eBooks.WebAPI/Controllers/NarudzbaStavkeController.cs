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
    public class NarudzbaStavkeController : BaseCRUDController<Model.NarudzbaStavke, Model.Requests.NarudzbeStavkeSearchRequest, Model.Requests.NarudzbeStavkeUpsertRequest, Model.Requests.NarudzbeStavkeUpsertRequest>
    {
        public NarudzbaStavkeController(ICRUDService<NarudzbaStavke, NarudzbeStavkeSearchRequest, NarudzbeStavkeUpsertRequest, NarudzbeStavkeUpsertRequest> service) : base(service)
        {
        }
    }
}
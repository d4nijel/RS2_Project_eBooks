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
    public class NarudzbeController : BaseCRUDController<Model.Narudzbe, Model.Requests.NarudzbeSearchRequest, Model.Requests.NarudzbeUpsertRequest, Model.Requests.NarudzbeUpsertRequest>
    {
        public NarudzbeController(ICRUDService<Narudzbe, NarudzbeSearchRequest, NarudzbeUpsertRequest, NarudzbeUpsertRequest> service) : base(service)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBooks.Model;
using eBooks.Model.Requests;
using eBooks.WebAPI.Database;
using eBooks.WebAPI.Mappers;
using eBooks.WebAPI.Services;
using eBooks.WebAPI.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBooks.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KnjigeController : ControllerBase
    {
        private readonly ICRUDService<Model.Knjige, Model.Requests.KnjigeSearchRequest, Model.Requests.KnjigeUpsertRequest, Model.Requests.KnjigeUpsertRequest> _service;

        public KnjigeController(ICRUDService<Model.Knjige, KnjigeSearchRequest, KnjigeUpsertRequest, KnjigeUpsertRequest> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Knjige>> Get([FromQuery]Model.Requests.KnjigeSearchRequest request)
        {
            return _service.Get(request);
        }

        [Route("[action]")]
        [HttpGet]
        public List<Model.Knjige> RecommendProduct(int kupacId)
        {
            Recommender r = new Recommender();
            return r.GetRecommendedProducts(kupacId);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Knjige> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id}")]
        public Model.Knjige Update(int id, Model.Requests.KnjigeUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpPost]
        public Model.Knjige Insert(Model.Requests.KnjigeUpsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
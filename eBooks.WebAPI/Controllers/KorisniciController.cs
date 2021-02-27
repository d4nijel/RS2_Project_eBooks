using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBooks.WebAPI.Database;
using eBooks.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBooks.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
       
        [HttpGet]
        public ActionResult<List<Model.Korisnici>> Get([FromQuery]Model.Requests.KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Korisnici> GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, Model.Requests.KorisniciUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Korisnici Insert(Model.Requests.KorisniciUpsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
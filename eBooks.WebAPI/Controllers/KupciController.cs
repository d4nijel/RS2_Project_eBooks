using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBooks.Model;
using eBooks.Model.Requests;
using eBooks.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBooks.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KupciController : ControllerBase
    {
        private readonly IKupciService _service;

        public KupciController(IKupciService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Kupci>> Get([FromQuery]Model.Requests.KupciSearchRequest request)
        {
            return _service.Get(request);
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<Model.Kupci> GetByUsername([FromQuery] string username)
        {
            return _service.GetByUsername(username);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Kupci> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id}")]
        public Model.Kupci Update(int id, Model.Requests.KupciUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpPost]
        public Model.Kupci Insert(Model.Requests.KupciUpsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
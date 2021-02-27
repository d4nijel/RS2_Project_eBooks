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
    public class GradoviController : BaseController<Model.Gradovi, object>
    {
        public GradoviController(IService<Gradovi, object> service) : base(service)
        {
        }
    }
}
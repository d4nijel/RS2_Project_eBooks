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
    public class AutoriKnjigeController : BaseCRUDController<Model.AutoriKnjige, object, Model.AutoriKnjige, Model.AutoriKnjige>
    {
        public AutoriKnjigeController(ICRUDService<AutoriKnjige, object, AutoriKnjige, AutoriKnjige> service) : base(service)
        {
        }
    }
}
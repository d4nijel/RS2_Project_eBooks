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
    public class AutoriController : BaseCRUDController<Model.Autori, Model.Requests.AutoriSearchRequest, Model.Requests.AutoriUpsertRequest, Model.Requests.AutoriUpsertRequest>
    {
        public AutoriController(ICRUDService<Autori, AutoriSearchRequest, AutoriUpsertRequest, AutoriUpsertRequest> service) : base(service)
        {
        }
    }
}
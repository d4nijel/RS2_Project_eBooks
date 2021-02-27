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
    public class IzdavaciController : BaseCRUDController<Model.Izdavaci, Model.Requests.IzdavaciSearchRequest, Model.Requests.IzdavaciUpsertRequest, Model.Requests.IzdavaciUpsertRequest>
    {
        public IzdavaciController(ICRUDService<Izdavaci, IzdavaciSearchRequest, IzdavaciUpsertRequest, IzdavaciUpsertRequest> service) : base(service)
        {
        }
    }
}
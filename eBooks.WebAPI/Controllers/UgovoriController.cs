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
    public class UgovoriController : BaseCRUDController<Model.Ugovori, Model.Requests.UgovoriSearchRequest, Model.Requests.UgovoriUpsertRequest, Model.Requests.UgovoriUpsertRequest>
    {
        public UgovoriController(ICRUDService<Ugovori, UgovoriSearchRequest, UgovoriUpsertRequest, UgovoriUpsertRequest> service) : base(service)
        {
        }
    }
}
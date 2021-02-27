using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get(Model.Requests.KorisniciSearchRequest request);
        Model.Korisnici GetById(int id);

        Model.Korisnici Insert(Model.Requests.KorisniciUpsertRequest request);
        Model.Korisnici Update(int id, Model.Requests.KorisniciUpsertRequest request);

        Model.Korisnici Autentificiraj(string username, string password);
    }
}

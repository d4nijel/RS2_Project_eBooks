using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.WebAPI.Services
{
    public interface IKupciService
    {
        List<Model.Kupci> Get(Model.Requests.KupciSearchRequest request);
        Model.Kupci GetById(int id);
        Model.Kupci GetByUsername(string request);
        Model.Kupci Insert(Model.Requests.KupciUpsertRequest request);
        Model.Kupci Update(int id, Model.Requests.KupciUpsertRequest request);
    }
}

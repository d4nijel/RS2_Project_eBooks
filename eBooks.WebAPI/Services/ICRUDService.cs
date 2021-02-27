﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.WebAPI.Services
{
    public interface ICRUDService<TModel, TSearch, TInsert, TUpdate> : IService<TModel, TSearch>
    {
        TModel Insert(TInsert request);
        TModel Update(int id, TUpdate request);
    }
}

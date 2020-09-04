using hrapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hrapi.Repository
{
    public interface ICatagoriesRepository
    {

        Task<int> Create(Catagories catagories);
        Task<List<Catagories>> GetAll();
    }
}

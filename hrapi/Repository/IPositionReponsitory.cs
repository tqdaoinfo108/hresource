using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface IPositionReponsitory
    {
        Task<int> Create(Positions value);
        Task<int> Update(int id, Positions value);
        Task<int> Delete(int id);
        Task<Positions> GetById(int id);
        Task<List<Positions>> GetAll();
    }
}

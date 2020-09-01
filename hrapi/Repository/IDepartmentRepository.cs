using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface IDepartmentRepository
    {
        Task<int> Create(Departments companys);
        Task<int> Update(int id, Departments companys);
        Task<int> Delete(int id);
        Task<Departments> GetById(int id);
        Task<List<Departments>> GetAll();
    }
}

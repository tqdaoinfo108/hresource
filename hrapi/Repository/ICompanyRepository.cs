using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface ICompanyRepository
    {
        Task<int> Create(Companys companys);
        Task<int> Update(int id,Companys companys);
        Task<int> Delete(int id);
        Task<List<Companys>> GetAll();

    }
}

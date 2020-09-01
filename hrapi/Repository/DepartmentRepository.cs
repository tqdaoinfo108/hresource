using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
      
        private IApplicationDbContext _dbcontext;

        public DepartmentRepository(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> Create(Departments departments)
        {
            _dbcontext.departments.Add(departments);
            await _dbcontext.SaveChanges();
            return departments.DepartmentID;
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Departments>> GetAll()
        {
            var value = await _dbcontext.departments.ToListAsync<Departments>();
            return value;
        }

        public Task<Departments> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int id, Departments companys)
        {
            throw new NotImplementedException();
        }
    }
}

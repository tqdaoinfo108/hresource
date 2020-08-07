using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Repository
{
    public class CompanyRepository : ICompanyRepository
    {

        private IApplicationDbContext _dbcontext;

        public CompanyRepository(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> Create(Companys companys)
        {
            _dbcontext.companys.Add(companys);
            await _dbcontext.SaveChanges();
            return companys.CompanyID;
        }

        public async Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Companys>> GetAll()
        {
            var value = await _dbcontext.companys.ToListAsync<Companys>();
            return value;
        }

        public async Task<int> Update(int id, Companys companys)
        {
            throw new NotImplementedException();
        }
    }
}

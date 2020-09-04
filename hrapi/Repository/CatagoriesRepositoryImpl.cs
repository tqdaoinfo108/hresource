using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hrapi.Repository
{
    public class CatagoriesRepositoryImpl : ICatagoriesRepository
    {
        private IApplicationDbContext _dbcontext;

        public CatagoriesRepositoryImpl(IApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public async Task<int> Create(Catagories categories)
        {
            _dbcontext.catagories.Add(categories);
            await _dbcontext.SaveChanges();
            return categories.CatagoriesID;
        }

        public async Task<List<Catagories>> GetAll()
        {
            var ctg = await _dbcontext.catagories.ToListAsync();
            return ctg;
        }
     
    }
}

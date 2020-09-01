using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Repository
{
    public class PositionReponsitory : IPositionReponsitory
    {
        
        private IApplicationDbContext _dbcontext;

        public PositionReponsitory(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> Create(Positions value)
        {
            _dbcontext.positions.Add(value);
            await _dbcontext.SaveChanges();
            return value.PositionID;
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Positions>> GetAll()
        {
            var value = await _dbcontext.positions.ToListAsync<Positions>();
            return value;
        }

        public Task<Positions> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int id, Positions value)
        {
            throw new NotImplementedException();
        }
    }
}

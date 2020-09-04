using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hrapi.Repository
{
    public class EventRepositoryImpl : IEventRepository
    {
        private IApplicationDbContext _dbcontext;

        public EventRepositoryImpl(IApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public async Task<int> Create(Event ev)
        {
            _dbcontext.events.Add(ev);
            await _dbcontext.SaveChanges();
            return ev.EventID;
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int id, Event events)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Event>> GetAll()
        {
            var evs = await _dbcontext.events.ToListAsync();
            return evs;
        }

        public async Task<Event> FindById(int id)
        {
            var ev = await _dbcontext.events.Where(x => x.EventID == id).FirstOrDefaultAsync();
            return ev;
        }
    }
}

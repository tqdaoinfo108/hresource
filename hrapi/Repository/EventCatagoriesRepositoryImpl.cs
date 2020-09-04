using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hrapi.Repository
{
    public class EventCatagoriesRepositoryImpl : IEventCatagoriesRepository
    {
        private IApplicationDbContext _dbcontext;

        public EventCatagoriesRepositoryImpl(IApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public async Task<int> Create(EventCatagories eventCatagories)
        {
            _dbcontext.eventCatagories.Add(eventCatagories);
            await _dbcontext.SaveChanges();
            return eventCatagories.EventCatagoriesID;
        }

        public async Task<List<EventCatagories>> GetAll()
        {
            var evc = await _dbcontext.eventCatagories.ToListAsync();
            return evc;
        }
    }
}

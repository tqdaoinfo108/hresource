using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hrapi.Repository
{
    public class EventStaffRepositoryImpl : IEventStaffRepository
    {
        private IApplicationDbContext _dbcontext;

        public EventStaffRepositoryImpl(IApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public async Task<int> Create(EventStaffs eventStaffs)
        {
            _dbcontext.eventStaffs.Add(eventStaffs);
            await _dbcontext.SaveChanges();
            return eventStaffs.EventStaffsID;
        }

        public async Task<List<EventStaffs>> GetAll()
        {
            var evs = await _dbcontext.eventStaffs.ToListAsync();
            return evs;
        }
    }
}

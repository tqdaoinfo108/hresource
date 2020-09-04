using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface IEventStaffRepository
    {
        Task<int> Create(EventStaffs eventStaffs);
        Task<List<EventStaffs>> GetAll();
    }
}

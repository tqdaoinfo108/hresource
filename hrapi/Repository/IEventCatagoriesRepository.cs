using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface IEventCatagoriesRepository
    {
        Task<int> Create(EventCatagories eventCatagories);
        Task<List<EventCatagories>> GetAll();
    }
}

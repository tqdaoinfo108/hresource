using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface IEventRepository
    {

        Task<int> Create(Event events);
        Task<int> Update(int id, Event events);
        Task<int> Delete(int id);
        Task<Event> FindById(int id);
        Task<List<Event>> GetAll();

    }
}

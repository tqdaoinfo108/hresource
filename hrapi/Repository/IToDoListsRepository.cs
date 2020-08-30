using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface IToDoListsRepository
    {
        Task<int> Create(ToDoLists value);
        Task<int> Update(int id, ToDoLists value);
        Task<int> Delete(int id);
        Task<ToDoLists> GetById(int id);
        Task<List<ToDoLists>> GetAll();
    }
}

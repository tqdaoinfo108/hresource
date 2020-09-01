using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Repository
{
    public class ToDoListsRepository : IToDoListsRepository
    {
        private IApplicationDbContext _dbcontext;

        public ToDoListsRepository(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<bool> ChangeStateTodoList(int id)
        {
            var modelUpdate = await _dbcontext.toDoLists.Where(x => x.ToDoListID == id).FirstOrDefaultAsync();
            if (modelUpdate == null) return false ;
            // change model
            modelUpdate.IsComplete = !modelUpdate.IsComplete;

            await _dbcontext.SaveChanges();
            return modelUpdate.IsComplete;
        }

        public async Task<int> Create(ToDoLists value)
        {
            _dbcontext.toDoLists.Add(value);
            await _dbcontext.SaveChanges();
            return value.ToDoListID;
        }

        public async Task<int> Delete(int id)
        {
            var item = _dbcontext.toDoLists.Where(x => x.ToDoListID == id).FirstOrDefault();
            if (item == null) return 0;
            _dbcontext.toDoLists.Remove(item);
            await _dbcontext.SaveChanges();
            return  1;
        }

        public async Task<List<ToDoLists>> GetAll()
        {
            var list = await _dbcontext.toDoLists.ToListAsync<ToDoLists>();
            return list;
        }

        public async Task<ToDoLists> GetById(int id)
        {
            var item = await _dbcontext.toDoLists.Where(x => x.ToDoListID == id).FirstOrDefaultAsync();
            return item;
        }

        public async Task<int> Update( ToDoLists value)
        {
            var modelUpdate = await _dbcontext.toDoLists.Where(x => x.ToDoListID == value.ToDoListID).FirstOrDefaultAsync();
            if (modelUpdate == null) return 0;
            // change model
            modelUpdate = value;

            await _dbcontext.SaveChanges();
            return modelUpdate.ToDoListID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Core.Models;
using ToDoApp.Core.Repositories;

namespace ToDoApp.Repository.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public Task AddAsync(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Todo>> GetAllAsync()
        {
            var list = new List<Todo>
            {
                new Todo
                {
                    Id = 1,
                    Title = "Sample Todo",
                    Description = "This is a sample todo item.",
                    CreatedData = DateTime.Now,
                    DueDate = DateTime.Now,
                    IsCompleted = false
                }
            };

            return Task.FromResult(list);
        }

        public Task<Todo?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}

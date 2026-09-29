using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Core.Models;
using ToDoApp.Core.Repositories;
using ToDoApp.Core.Services;

namespace ToDoApp.Service.Services
{
    internal class TodoServices : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoServices(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        public Task AddAsync(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Todo>> GetAllAsync()
        {
            return await _todoRepository.GetAllAsync();
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

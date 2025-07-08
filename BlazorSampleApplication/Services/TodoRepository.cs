using BlazorSampleApplication.DbModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorSampleApplication.Services
{
    public class TodoRepository
    {
        readonly BlazorToDoContext _context;
        public TodoRepository(BlazorToDoContext context)
        {
            _context = context;
        }

        public async Task<List<Todo>> GetTodosAsync()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task<Todo?> GetTodoByIdAsync(string id)
        {
            return await _context.Todos.FindAsync(id);
        }

        public async Task<Todo> AddTodoAsync(Todo todo)
        {
            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public async Task<bool> UpdateTodoAsync(Todo todo)
        {
            var existing = await _context.Todos.FindAsync(todo.Id);
            if (existing == null)
                return false;

            existing.Title = todo.Title;
            existing.Description = todo.Description;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTodoAsync(string id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo == null)
                return false;

            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

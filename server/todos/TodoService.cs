using System.Collections.Generic;
using System.Linq;

namespace TodoMvc.Todos
{
    public class TodoService
    {
        public IEnumerable<TodoItem> GetAll()
        {
            return new List<TodoItem> {
                new TodoItem(1, "First todo", "Start stuff"),
                new TodoItem(2, "Second", "Fix bugs"),
                new TodoItem(3, "Third", "Finish stuff")
            };
        }

        public TodoItem GetById(long id)
        {
            return GetAll().Single(it => it.id == id);
        }
    }
}
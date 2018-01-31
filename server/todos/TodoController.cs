using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace TodoMvc.Todos
{
    [Route("/api/[controller]")]
    public class TodosController : Controller
    {
        private readonly TodoService _service;

        public TodosController(TodoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var result = _service.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
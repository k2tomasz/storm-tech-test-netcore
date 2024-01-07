using System.Collections.Generic;
using System.Net.WebSockets;
using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Data.Entities;
using Todo.Models.TodoItems;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.Controllers
{
    [Route("api/todoitems")]
    [ApiController]
    public class TodoItemApiController(ApplicationDbContext dbContext) : ControllerBase
    {
        [HttpPost]
        public async void Post([FromBody] TodoItemCreateFields fields)
        {

            var item = new TodoItem(fields.TodoListId, fields.ResponsiblePartyId, fields.Title, fields.Importance);

            await dbContext.AddAsync(item);
            await dbContext.SaveChangesAsync();
        }

    }
}

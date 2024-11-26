using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Lab2.Repositories;
using System.Collections.Generic;

namespace Lab2.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class HomeController : ControllerBase
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetAllData()
        {
            return Ok(_repository.GetItems());
        }

        [HttpPut("{id}")]
        public ActionResult UpdateData(int id, [FromBody] string newValue)
        {
            var item = _repository.GetItemById(id);
            if (item == null)
                return NotFound();

            item.Value = newValue;
            _repository.UpdateItem(item);

            Console.WriteLine($"Data updated: {id} = {newValue}");
            return NoContent();
        }
    }
}

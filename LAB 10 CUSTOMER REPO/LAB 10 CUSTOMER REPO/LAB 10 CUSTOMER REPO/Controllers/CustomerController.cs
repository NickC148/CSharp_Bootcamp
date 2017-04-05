using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LAB_10_CUSTOMER_REPO.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LAB_10_CUSTOMER_REPO.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepo _custRepo;

        public CustomerController(ICustomerRepo todoRepository)
        {
            _custRepo = todoRepository;
        }

        [HttpGet]
        public IEnumerable<CustomerItem> GetAll()
        {
            return _custRepo.GetAll();
        }

        [HttpGet("{id}", Name = "GetCust")]
        public IActionResult GetById(long id)
        {
            var item = _custRepo.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CustomerItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _custRepo.Add(item);

            return CreatedAtRoute("GetCust", new { id = item.CustomerId }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] CustomerItem item)
        {
            if (item == null || item.CustomerId != id)
            {
                return BadRequest();
            }

            var cust = _custRepo.Find(id);
            if (cust == null)
            {
                return NotFound();
            }

            //todo.Name = item.Name;
            cust.FirstName = item.FirstName;
            cust.LastName = item.LastName;
            cust.Email = item.Email;
            cust.Phone = item.Phone;
            cust.Address = item.Address;
            cust.City = item.City;
            cust.State = item.State;
            cust.PostalAddress = item.PostalAddress;

            _custRepo.Update(cust);
            return new NoContentResult();
        }

        /// <summary>
        /// Deletes Customer from DB for stuff and things
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var cust = _custRepo.Find(id);
            if (cust == null)
            {
                return NotFound();
            }

            _custRepo.Remove(id);
            return new NoContentResult();
        }
    }
}

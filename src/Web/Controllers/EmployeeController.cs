using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entities;

namespace Web.Controllers.Api
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        public AppDbContext _db;

        public EmployeeController(AppDbContext db)
        { 
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _db.Employee.ToList();
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            Employee product = _db.Employee.FirstOrDefault(x => x.Id == id);
            return product;
        }

        [HttpPost]
        public IActionResult Post(Employee employee) // [FromBody]
        {
            if (ModelState.IsValid)
            {
                _db.Employee.Add(employee);
                _db.SaveChanges();
                return Ok(employee);
            }

            return BadRequest(ModelState);
        }

    }
}

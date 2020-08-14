using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<EmployeePosition> Get()
        {
            var result = _db.EmployeePosition
                .Include(x => x.Employee)
                .Include(x => x.Position)
                .Where(x => !x.DateTo.HasValue).ToList();
            return result;
        }

        [HttpGet("{id}")]
        public EmployeePosition Get(int id)
        {
            var result = _db.EmployeePosition
                .Where(x => x.Employee.Id == id && !x.DateTo.HasValue)
                .FirstOrDefault();
            return result;
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

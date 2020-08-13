using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entities;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/employee-position")]
    public class EmployeePositionController : ControllerBase
    {
        public AppDbContext _db;

        public EmployeePositionController(AppDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<IEnumerable<EmployeePosition>> GetAllEmployees()
        {
            IEnumerable<EmployeePosition> result = await _db.EmployeePosition.Where(x => true).ToArrayAsync();
            return result;
        }
    }
}

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
    [Route("api/employees")]
    public class EmployeeController
    {
        public AppDbContext _db;

        public EmployeeController(AppDbContext db)
        {
            _db = db;
        }

        //[HttpPost]
        //public async Task<Employee> CreateEmployee([FromBody] Employee employee)
        //{
        //    Employee citation = new Employee();
        //    try
        //    {
        //        //insert to DB to table Citation new citate
        //        citation.allData = employee.otherData;
        //        citation.idUser = _userManager.GetUserId(User);
        //        citation.date = DateTime.Now;
        //        _db.Citation.Add(citation);

        //        await _db.SaveChangesAsync();
        //        //call method for add author of citate
        //        employee.authors = await SaveAuthorsForBibl(obj.authors, citation.id);
        //        employee.date = citation.date;
        //        employee.id = citation.id;
        //    }
        //    catch (Exception ex)
        //    { employee.exeption = ex; }

        //    return employee;
        //}


        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            IEnumerable<Employee> result = await _db.Employee.Where(x => true).ToArrayAsync();
            return result;
        }

    }
}

using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entities;

namespace Web.Controllers.Api
{
    [Route("api/employee")]
    public class EmployeeController
    {
        public AppDbContext _db;

        public EmployeeController(AppDbContext db)
        { 
            _db = db;
        }

        [HttpPost]
        public async Task<Employee> SaveData([FromBody] Employee employee)
        {
            //Citation citation = new Citation();
            //try
            //{
            //    //insert to DB to table Citation new citate
            //    citation.allData = obj.otherData;
            //    citation.idUser = _userManager.GetUserId(User);
            //    citation.date = DateTime.Now;
            //    _db.Citation.Add(citation);

            //    await _db.SaveChangesAsync();
            //    //call method for add author of citate
            //    obj.authors = await SaveAuthorsForBibl(obj.authors, citation.id);
            //    obj.date = citation.date;
            //    obj.id = citation.id;
            //}
            //catch (Exception ex)
            //{ obj.exeption = ex; }
            
            return employee;
        }


    }
}

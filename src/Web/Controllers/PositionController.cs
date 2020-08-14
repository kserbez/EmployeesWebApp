using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entities;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/position")]
    public class PositionController : ControllerBase
    {
        public AppDbContext _db;

        public PositionController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Position> Get()
        {
            return _db.Position.ToList();
        }

        [HttpGet("{id}")]
        public Position Get(int id)
        {
            Position position = _db.Position.FirstOrDefault(x => x.Id == id);
            return position;
        }

        [HttpPost]
        public IActionResult Post(Position position) // [FromBody]
        {
            if (ModelState.IsValid)
            {
                _db.Position.Add(position);
                _db.SaveChanges();
                return Ok(position);
            }

            return BadRequest(ModelState);
        }

    }
}

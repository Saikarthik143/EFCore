using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsonREpo.Models;
using HandsonREpo.Repositories;

namespace HandsonREpo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepo repo = new EmployeeRepo();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(string id)
        {
            return Ok(repo.GetById(id));
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Employee item)
        {
            repo.Add(item);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Employee item)
        {
            repo.Update(item);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            repo.Delete(id);
            return Ok("Record Deleted");
        }
    }
}
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
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        ProjectRepo repo = new ProjectRepo();
        [HttpGet]
        [Route("Get")]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }
        [HttpGet]
        [Route("GetId/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(repo.Get(id));
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Project item)
        {
            repo.Add(item);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Project item)
        {
            repo.Update(item);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return Ok("Deleted");
        }
    }
}
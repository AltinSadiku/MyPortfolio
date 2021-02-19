using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.API.Data;
using MyPortfolio.API.Models;


namespace MyPortfolio.API.Controllers
{

     [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        
        private readonly DataContext _context;

        public ProjectController(DataContext context){
            _context = context;
        }

        
        // GET api/values
        [HttpGet]
        public IActionResult GetProject()
        {
            var project = _context.Projects.ToList();
            return Ok(project);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<int> GetProject(int id)
        {
            var project= _context.Projects.FirstOrDefault(x => x.Id == id);

            return Ok(project);
        }

        // POST api/values
        [HttpPost]
        public void Post( Project project)
        {
            var projects = _context.Projects.Add(project);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, About about)
        {
            var project = _context.Projects.Find(id);

            project.Title = about.Title;
            project.Description = project.Description;

            _context.Update(project);
            _context.SaveChanges();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var project = _context.Projects.Find(id);

            _context.Remove(project);

            _context.SaveChanges();
          


        }
    }
}
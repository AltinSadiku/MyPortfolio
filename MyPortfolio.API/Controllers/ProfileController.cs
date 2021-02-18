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
    public class ProfileController : ControllerBase
    {

        private readonly DataContext _context;

        public ProfileController(DataContext context){
            _context = context;
        }

        
        // GET api/values
        [HttpGet]
        public IActionResult GetProfile()
        {
            var abouts = _context.Abouts.ToList();
            return Ok(abouts); 
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public ActionResult<string> GetName(string name)
        {
            var profileName = _context.Abouts.FirstOrDefault(x => x.Name == name);

            return Ok(profileName);
        }

        // POST api/values
        [HttpPost]
        public void Post( About about)
        {
            var profile = _context.Abouts.Add(about);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, About about)
        {
            var profile = _context.Abouts.Find(id);

            profile.Name = about.Name;
            profile.Title = about.Title;
            profile.Description = about.Description;
            profile.Location = about.Location;

            _context.Update(profile);
            _context.SaveChanges();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var profile = _context.Abouts.Find(id);

            _context.Remove(profile);

            _context.SaveChanges();
          


        }

    }
}
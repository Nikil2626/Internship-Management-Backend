using Microsoft.AspNetCore.Mvc;
using Project2.Data;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;

        public InternController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }
        // GET: api/<InternController>
        [HttpGet]
        public IEnumerable<Intern> Get()
        {
            return _CRUDContext.Interns;
        }

        // GET api/<InternController>/5
        [HttpGet("{id}")]
        public Intern Get(int id)
        {
            return _CRUDContext.Interns.SingleOrDefault(x => x.InternId == id);
        }

        // POST api/<InternController>
        [HttpPost]
        public void Post([FromBody] Intern interns)
        {
            _CRUDContext.Interns.Add(interns);
            _CRUDContext.SaveChanges();
        }

        // PUT api/<InternController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Intern interns)
        {
            _CRUDContext.Interns.Update(interns);
            _CRUDContext.SaveChanges();
        }

        [HttpPost("{uname}/{pwd}")]
        public bool Login(string uname, string pwd)
        {
            var ValidUser = _CRUDContext.Interns.FirstOrDefault(p => p.EmailId == uname && p.Password == pwd);
            if (ValidUser != null)
            {
                return true;
            }

            return false;

        }
        // DELETE api/<InternController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Interns.FirstOrDefault(x => x.InternId == id);
            if (item != null)
            {
                _CRUDContext.Interns.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}

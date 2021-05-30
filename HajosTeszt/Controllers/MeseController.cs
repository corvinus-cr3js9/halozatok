using HajosTeszt.MeseModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HajosTeszt.Controllers
{
    [Route("api/tales")]
    [ApiController]
    public class MeseController : ControllerBase
    {
        // GET: api/tales
        [HttpGet]
        public IEnumerable<Tale> Get()
        {
            MeseContext context = new MeseContext();
            return context.Tales.ToList();
        }

        // GET api/tales/5
        [HttpGet("{id}")]
        public Tale Get(int id)
        {
            MeseContext context = new MeseContext();
            var keresettMese = (from x in context.Tales
                                where x.Id == id
                                select x).FirstOrDefault();
            return keresettMese;
        }

        // POST api/tales>
        [HttpPost]
        public void Post([FromBody] Tale újMese)
        {
            MeseContext context = new MeseContext();
            context.Tales.Add(újMese);
            context.SaveChanges();
        }

        // PUT api/tales/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/tales/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MeseContext context = new MeseContext();
            var törlendőMese = (from x in context.Tales
                                where x.Id == id
                                select x).FirstOrDefault();
            context.Remove(törlendőMese);
            context.SaveChanges();
        }
        [HttpGet]
        [Route("count")]
        public int M1()
        {
            MeseContext context = new MeseContext();
            int mesékszáma = context.Tales.Count();
            return mesékszáma;
        }

    }

}

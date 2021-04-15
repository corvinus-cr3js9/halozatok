using HajosTeszt.Modles;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HajosTeszt.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
         [HttpGet]
         [Route("questions/all")]
         public ActionResult M1()
        {
            hajostesztContext context = new hajostesztContext();
            var kérdések = from x in context.Questions
                           select x.QuestionText;
            return new JsonResult(kérdések); //A JsonResult nagyjából tetszőleges objektumot JSON formátumba szerializál,
                                             //és a HTTP válasz content-type-ját is beállítja application/json-re, így ezzel sem kell külön törődnünk.
                                             //A kapott JSON könnyen feldolgozható Javascript oldalon.
        }


    }
}

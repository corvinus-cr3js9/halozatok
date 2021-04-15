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
    public class TesztController : ControllerBase
    {
        [HttpGet]  //GET típusú HTTP kérésre fog válaszolni a függvényünk
        [Route("corvinus/nagybetus/{szoveg}")] //azt állítja be, hogy milyen route-on legyen elérhető az endpoint. Ez most https://[domin]:[port]/corvinus/szerverido lesz így.
        public IActionResult M2( string szoveg) //A metódus neve (M1) nem számít. Akkor számítana csak, ha az előző lépésben nem raktuk volna megjegyzésbe a [Route("api/[controller]")] attribútumot.
                                  //Ebben az esetben a https://[domin]:[port]/api/M1 címen lenne elérhető. Úgy is lehet, talán a függvényenként beállított route áttekinthetőbb. Ízlések és pofonok :)
        {
            string pontosIdő = DateTime.Now.ToShortTimeString();
            //A metódus IActionResult típusú értéket ad vissza. A ContentResult típusú objektum, ami a return-ben jön létre, ennek megfelel.
            return new ContentResult //A string típusú Content maga a visszaküldendő válasz.
            {
                ContentType = System.Net.Mime.MediaTypeNames.Text.Plain, //"text/plain"
                //A ContentType pedig a válasz MIME-ja. Meg lehet adni string-ként is – ContentType = “text/plain” – ,
                //de a beépített enumerációval nem kell emlékezni, hogy pontosan hogy kell írni a különböző tartalmakhoz tartozó stringeket.
                Content = szoveg.ToUpper()
            }; 
        }
    }
}

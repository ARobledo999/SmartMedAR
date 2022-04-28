using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartMed.Model;

using SmartMed.Data;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartMed.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : ControllerBase
    {
       
        // GET: api/<MedicationController>
        [HttpGet]
        [Produces("application/json")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(IListMedications), StatusCodes.Status200OK)]

        public ActionResult Get()
        {

            using (var db = new SmartContext())
            {
                var result = db.TbMedication.ToList();

                return Ok(result);
            }


        }


        // POST api/<MedicationController>
        [HttpPost]
        public async void Post([FromBody] TbMedication medications)
        {

            medications.CreateDate = DateTime.Now;
            using (var db = new SmartContext())
            {

                db.TbMedication.Add(medications);
                db.SaveChanges();
            }
        }
        // DELETE api/<MedicationController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            using (var db = new SmartContext())
            {
                var item = db.TbMedication.Where(x => x.ID == id).FirstOrDefault();
                if (item != null)
                {
                    db.Remove(item);
                    db.SaveChanges();
                }
            }
        }
    }
}
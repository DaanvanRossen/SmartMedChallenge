using Microsoft.AspNetCore.Mvc;
using SmartMedChallenge.Models;

namespace SmartMedChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : ControllerBase
    {
        private SmartMedContext db = new SmartMedContext();

        public MedicationController()
        {}

        [HttpGet(Name = "GetMedication")]
        public IActionResult GetMedication()
        {
            return Ok(db.Medication.ToArray());
        }

        [HttpPost]
        public IActionResult InsertMedication(Medication medication)
        {
            db.Add(medication);
            try
            {
                db.SaveChanges();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return BadRequest(ex);
            }
            return Ok();
        }

        [HttpDelete(Name = "DeleteMedication")]
        public void DeleteMedication(Medication medication)
        {
            db.Remove(medication);
            db.SaveChanges();
        }

    }
}

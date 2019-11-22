using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIFireAlarm.Models;

//TODO 06: Add > New Scaffolded item => api controller met Entity support
//TODO 07: LaunchSettings.json aanpassen naar juiste url
//TODO0 09: bekijk methods
//TODO 10: Testen met postman
//TODO 11: Disable SSL in postman
namespace WebAPIFireAlarm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FireAlarmsController : ControllerBase
    {
        private readonly FireAlarmContext _context;

        public FireAlarmsController(FireAlarmContext context)
        {
            _context = context;

            //TODO 08: Maak 1 firealarm
            if (context.FireAlarmList.Count() == 0)
            {
                FireAlarm fireAlarm = new FireAlarm()
                {
                    //Id => niet invullen, gaat vanzelf door entity framework
                    Location = "IWT - Kortrijk - Maaklab",
                    Reason = "smoke detected",
                    Active = false
                };

                context.FireAlarmList.Add(fireAlarm);
                context.SaveChanges();
            }
        }

        // GET: api/FireAlarms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FireAlarm>>> GetFireAlarmList()
        {
            return await _context.FireAlarmList.ToListAsync();
        }

        // GET: api/FireAlarms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FireAlarm>> GetFireAlarm(ulong id)
        {
            var fireAlarm = await _context.FireAlarmList.FindAsync(id);

            if (fireAlarm == null)
            {
                return NotFound();
            }

            return fireAlarm;
        }

        // PUT: api/FireAlarms/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFireAlarm(ulong id, FireAlarm fireAlarm)
        {
            if (id != fireAlarm.Id)
            {
                return BadRequest();
            }

            _context.Entry(fireAlarm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FireAlarmExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //return NoContent();

            return fireAlarm;
        }

        // POST: api/FireAlarms
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<FireAlarm>> PostFireAlarm(FireAlarm fireAlarm)
        {
            _context.FireAlarmList.Add(fireAlarm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFireAlarm", new { id = fireAlarm.Id }, fireAlarm);
        }

        // DELETE: api/FireAlarms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FireAlarm>> DeleteFireAlarm(ulong id)
        {
            var fireAlarm = await _context.FireAlarmList.FindAsync(id);
            if (fireAlarm == null)
            {
                return NotFound();
            }

            _context.FireAlarmList.Remove(fireAlarm);
            await _context.SaveChangesAsync();

            return fireAlarm;
        }

        private bool FireAlarmExists(ulong id)
        {
            return _context.FireAlarmList.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;
using WebAPI.Model.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        // GET api/bet
        [HttpGet]
        public ActionResult<IEnumerable<Bet>> Get()
        {
            using (var dbContext = new EzBetDbContext())
            {
                return dbContext.Bets.ToList();
            }
        }

        // GET api/bet/5
        [HttpGet("{id}")]
        public ActionResult<Bet> Get(int id)
        {
            using (var dbContext = new EzBetDbContext())
            {
                var bet = dbContext.Find<Bet>(id);
                if (bet == null)
                {
                    return NotFound();
                }
                return bet;
            }
        }

        // POST api/bet
        [HttpPost]
        public void Post([FromBody] Bet value)
        {
        }

        // PUT api/bet/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bet value)
        {
        }

        // DELETE api/bet/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var dbContext = new EzBetDbContext())
            {
                var betToDelete = dbContext.Find<Bet>(id);
                dbContext.Remove(betToDelete);
            }
        }
    }
}

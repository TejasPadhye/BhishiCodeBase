using BrahmvrundBhishi_API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrahmvrundBhishi_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LuckyMembersController : ControllerBase
    {
        // GET: api/<LuckyMembersController>
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IList<MembersSeasonsWinnersMw> Get()
        {
            using (BRAHMVRUNDContext context = new BRAHMVRUNDContext())
            {
                var existingWinners = context.MembersSeasonsWinnersMws.Select(d => new MembersSeasonsWinnersMw()
                {
                    MemberId = d.MemberId,
                    SeasonId = d.SeasonId,
                    LuckyDrawDate = d.LuckyDrawDate,
                    IsNotificationSent = d.IsNotificationSent
                }).ToList();
                return existingWinners;
            }
        }

        // GET api/<LuckyMembersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LuckyMembersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LuckyMembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LuckyMembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using BrahmvrundBhishi_API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrahmvrundBhishi_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        // GET: api/<MembersController>
        //[EnableCors("AllowOrigin")]
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    using (BRAHMVRUNDContext context = new BRAHMVRUNDContext())
        //    {
        //        return context.MembersDataMds.Where(x => x.IsActive == "Y" ).Select(y => y.MemberName).ToList();
        //    }

        //}

        [EnableCors("AllowOrigin")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            using(BRAHMVRUNDContext context = new BRAHMVRUNDContext())
            {
                int currentSeason = context.SeasonsDataSds.Where(x => x.SeasonEndDate == null).Select(y => y.SeasonId).FirstOrDefault();
                var existingWinners = context.MembersSeasonsWinnersMws.Where(x => x.SeasonId == currentSeason).Select(y => y.MemberId).ToList();

                return context.MembersDataMds.Where(x => x.IsActive == "Y" && !existingWinners.Contains(x.MemberId)).Select(y => y.MemberName).ToList();
            }
                
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            using (BRAHMVRUNDContext context = new BRAHMVRUNDContext())
            {
                return context.MembersDataMds.Where(x => x.IsActive == "Y" && x.MemberId == id).Select(y => y.MemberName).FirstOrDefault();
            }
        }

        // POST api/<MembersController>
        [HttpPost]
        public bool PostMemberData([FromBody] string memberName)
        {
            bool isSuccess = false;
            using (BRAHMVRUNDContext context = new BRAHMVRUNDContext())
            {
                int memberId = context.MembersDataMds.Where(x => x.IsActive == "Y" && x.MemberName == memberName).Select(y => y.MemberId).FirstOrDefault();
                int currentSeason = context.SeasonsDataSds.Where(x => x.SeasonEndDate == null).Select(y => y.SeasonId).FirstOrDefault();

                MembersSeasonsWinnersMw winner = new MembersSeasonsWinnersMw()
                {
                    MemberId = memberId,
                    SeasonId = currentSeason,
                    LuckyDrawDate = DateTime.Today,
                    IsNotificationSent = "N",
                    CreatedOn = DateTime.Today,
                    CreatedBy = "System",
                    UpdatedOn = DateTime.Today,
                    UpdatedBy = "System"
                };

                context.MembersSeasonsWinnersMws.Add(winner);
                context.SaveChanges();
                isSuccess = true;

            }
            return isSuccess;
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

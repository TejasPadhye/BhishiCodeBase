using System;
using System.Collections.Generic;

namespace BrahmvrundBhishi_API.Models
{
    public partial class MembersSeasonsWinnersMw
    {
        public int MembersSeasonsWinnersId { get; set; }
        public int? MemberId { get; set; }
        public int? SeasonId { get; set; }
        public DateTime LuckyDrawDate { get; set; }
        public string IsNotificationSent { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; } = null!;

        public virtual MembersDataMd? Member { get; set; }
        public virtual SeasonsDataSd? Season { get; set; }
    }
}

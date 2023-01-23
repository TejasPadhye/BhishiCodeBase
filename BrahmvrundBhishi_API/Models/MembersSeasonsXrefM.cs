using System;
using System.Collections.Generic;

namespace BrahmvrundBhishi_API.Models
{
    public partial class MembersSeasonsXrefM
    {
        public int MembersSeasonsId { get; set; }
        public int? MemberId { get; set; }
        public int? MemberFromSeasonId { get; set; }
        public int? MemberDeactivatedSeasonId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; } = null!;

        public virtual MembersDataMd? Member { get; set; }
        public virtual SeasonsDataSd? MemberDeactivatedSeason { get; set; }
        public virtual SeasonsDataSd? MemberFromSeason { get; set; }
    }
}

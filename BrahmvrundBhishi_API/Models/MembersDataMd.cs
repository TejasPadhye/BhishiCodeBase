using System;
using System.Collections.Generic;

namespace BrahmvrundBhishi_API.Models
{
    public partial class MembersDataMd
    {
        public MembersDataMd()
        {
            MembersEmailXrefMes = new HashSet<MembersEmailXrefMe>();
            MembersSeasonsWinnersMws = new HashSet<MembersSeasonsWinnersMw>();
            MembersSeasonsXrefMs = new HashSet<MembersSeasonsXrefM>();
        }

        public int MemberId { get; set; }
        public string MemberName { get; set; } = null!;
        public int? EmailDetailsId { get; set; }
        public string IsActive { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; } = null!;

        public virtual EmailDetailsEd? EmailDetails { get; set; }
        public virtual ICollection<MembersEmailXrefMe> MembersEmailXrefMes { get; set; }
        public virtual ICollection<MembersSeasonsWinnersMw> MembersSeasonsWinnersMws { get; set; }
        public virtual ICollection<MembersSeasonsXrefM> MembersSeasonsXrefMs { get; set; }
    }
}

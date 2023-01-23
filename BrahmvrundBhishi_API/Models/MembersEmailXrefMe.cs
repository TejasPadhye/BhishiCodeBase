using System;
using System.Collections.Generic;

namespace BrahmvrundBhishi_API.Models
{
    public partial class MembersEmailXrefMe
    {
        public int MembersEmailId { get; set; }
        public int? MemberId { get; set; }
        public int? EmailDetailsId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; } = null!;

        public virtual EmailDetailsEd? EmailDetails { get; set; }
        public virtual MembersDataMd? Member { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace BrahmvrundBhishi_API.Models
{
    public partial class EmailDetailsEd
    {
        public EmailDetailsEd()
        {
            MembersDataMds = new HashSet<MembersDataMd>();
            MembersEmailXrefMes = new HashSet<MembersEmailXrefMe>();
        }

        public int EmailDetailsId { get; set; }
        public string EmailId { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; } = null!;

        public virtual ICollection<MembersDataMd> MembersDataMds { get; set; }
        public virtual ICollection<MembersEmailXrefMe> MembersEmailXrefMes { get; set; }
    }
}

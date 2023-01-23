using System;
using System.Collections.Generic;

namespace BrahmvrundBhishi_API.Models
{
    public partial class SeasonsDataSd
    {
        public SeasonsDataSd()
        {
            MembersSeasonsWinnersMws = new HashSet<MembersSeasonsWinnersMw>();
            MembersSeasonsXrefMMemberDeactivatedSeasons = new HashSet<MembersSeasonsXrefM>();
            MembersSeasonsXrefMMemberFromSeasons = new HashSet<MembersSeasonsXrefM>();
        }

        public int SeasonId { get; set; }
        public DateTime SeasonStartDate { get; set; }
        public DateTime? SeasonEndDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; } = null!;

        public virtual ICollection<MembersSeasonsWinnersMw> MembersSeasonsWinnersMws { get; set; }
        public virtual ICollection<MembersSeasonsXrefM> MembersSeasonsXrefMMemberDeactivatedSeasons { get; set; }
        public virtual ICollection<MembersSeasonsXrefM> MembersSeasonsXrefMMemberFromSeasons { get; set; }
    }
}

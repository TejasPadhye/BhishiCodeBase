using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BrahmvrundBhishi_API.Models
{
    public partial class BRAHMVRUNDContext : DbContext
    {
        public BRAHMVRUNDContext()
        {
        }

        public BRAHMVRUNDContext(DbContextOptions<BRAHMVRUNDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmailDetailsEd> EmailDetailsEds { get; set; } = null!;
        public virtual DbSet<MembersDataMd> MembersDataMds { get; set; } = null!;
        public virtual DbSet<MembersEmailXrefMe> MembersEmailXrefMes { get; set; } = null!;
        public virtual DbSet<MembersSeasonsWinnersMw> MembersSeasonsWinnersMws { get; set; } = null!;
        public virtual DbSet<MembersSeasonsXrefM> MembersSeasonsXrefMs { get; set; } = null!;
        public virtual DbSet<SeasonsDataSd> SeasonsDataSds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BRAHMVRUND;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailDetailsEd>(entity =>
            {
                entity.HasKey(e => e.EmailDetailsId)
                    .HasName("PK__EMAIL_DE__5FFF8FEE74C58E98");

                entity.ToTable("EMAIL_DETAILS_ED");

                entity.Property(e => e.EmailDetailsId).HasColumnName("EMAIL_DETAILS_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("UPDATED_ON");
            });

            modelBuilder.Entity<MembersDataMd>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__MEMBERS___B1223B70CCB83533");

                entity.ToTable("MEMBERS_DATA_MD");

                entity.Property(e => e.MemberId).HasColumnName("MEMBER_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.EmailDetailsId).HasColumnName("EMAIL_DETAILS_ID");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IS_ACTIVE");

                entity.Property(e => e.MemberName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MEMBER_NAME");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("UPDATED_ON");

                entity.HasOne(d => d.EmailDetails)
                    .WithMany(p => p.MembersDataMds)
                    .HasForeignKey(d => d.EmailDetailsId)
                    .HasConstraintName("FK__MEMBERS_D__EMAIL__38996AB5");
            });

            modelBuilder.Entity<MembersEmailXrefMe>(entity =>
            {
                entity.HasKey(e => e.MembersEmailId)
                    .HasName("PK__MEMBERS___4E7FCCA55D708325");

                entity.ToTable("MEMBERS_EMAIL_XREF_ME");

                entity.Property(e => e.MembersEmailId).HasColumnName("MEMBERS_EMAIL_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.EmailDetailsId).HasColumnName("EMAIL_DETAILS_ID");

                entity.Property(e => e.MemberId).HasColumnName("MEMBER_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("UPDATED_ON");

                entity.HasOne(d => d.EmailDetails)
                    .WithMany(p => p.MembersEmailXrefMes)
                    .HasForeignKey(d => d.EmailDetailsId)
                    .HasConstraintName("FK__MEMBERS_E__EMAIL__4316F928");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MembersEmailXrefMes)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__MEMBERS_E__MEMBE__4222D4EF");
            });

            modelBuilder.Entity<MembersSeasonsWinnersMw>(entity =>
            {
                entity.HasKey(e => e.MembersSeasonsWinnersId)
                    .HasName("PK__MEMBERS___DC88008EFB2F8C6E");

                entity.ToTable("MEMBERS_SEASONS_WINNERS_MW");

                entity.Property(e => e.MembersSeasonsWinnersId).HasColumnName("MEMBERS_SEASONS_WINNERS_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.IsNotificationSent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IS_NOTIFICATION_SENT");

                entity.Property(e => e.LuckyDrawDate)
                    .HasColumnType("date")
                    .HasColumnName("LUCKY_DRAW_DATE");

                entity.Property(e => e.MemberId).HasColumnName("MEMBER_ID");

                entity.Property(e => e.SeasonId).HasColumnName("SEASON_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("UPDATED_ON");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MembersSeasonsWinnersMws)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__MEMBERS_S__MEMBE__45F365D3");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.MembersSeasonsWinnersMws)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK__MEMBERS_S__SEASO__46E78A0C");
            });

            modelBuilder.Entity<MembersSeasonsXrefM>(entity =>
            {
                entity.HasKey(e => e.MembersSeasonsId)
                    .HasName("PK__MEMBERS___E5F0B96C51AD6173");

                entity.ToTable("MEMBERS_SEASONS_XREF_MS");

                entity.Property(e => e.MembersSeasonsId).HasColumnName("MEMBERS_SEASONS_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.MemberDeactivatedSeasonId).HasColumnName("MEMBER_DEACTIVATED_SEASON_ID");

                entity.Property(e => e.MemberFromSeasonId).HasColumnName("MEMBER_FROM_SEASON_ID");

                entity.Property(e => e.MemberId).HasColumnName("MEMBER_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("UPDATED_ON");

                entity.HasOne(d => d.MemberDeactivatedSeason)
                    .WithMany(p => p.MembersSeasonsXrefMMemberDeactivatedSeasons)
                    .HasForeignKey(d => d.MemberDeactivatedSeasonId)
                    .HasConstraintName("FK__MEMBERS_S__MEMBE__3F466844");

                entity.HasOne(d => d.MemberFromSeason)
                    .WithMany(p => p.MembersSeasonsXrefMMemberFromSeasons)
                    .HasForeignKey(d => d.MemberFromSeasonId)
                    .HasConstraintName("FK__MEMBERS_S__MEMBE__3E52440B");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MembersSeasonsXrefMs)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK__MEMBERS_S__MEMBE__3D5E1FD2");
            });

            modelBuilder.Entity<SeasonsDataSd>(entity =>
            {
                entity.HasKey(e => e.SeasonId)
                    .HasName("PK__SEASONS___CC8E723C81166C04");

                entity.ToTable("SEASONS_DATA_SD");

                entity.Property(e => e.SeasonId).HasColumnName("SEASON_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.SeasonEndDate)
                    .HasColumnType("date")
                    .HasColumnName("SEASON_END_DATE");

                entity.Property(e => e.SeasonStartDate)
                    .HasColumnType("date")
                    .HasColumnName("SEASON_START_DATE");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("UPDATED_ON");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

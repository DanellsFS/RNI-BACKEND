using Microsoft.EntityFrameworkCore;
using UninunezRNIBackend.Models.Domain;

namespace UninunezRNIBackend.Data
{
    public class UninunezRNIDbContext : DbContext
    {
        public UninunezRNIDbContext(DbContextOptions<UninunezRNIDbContext> options) : base(options)
        {
        }

        public DbSet<AgreementRequest> AgreementRequests { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AgreementRequest>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
                entity.Property(e => e.ProposerName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.ProposerEmail).HasMaxLength(100).IsRequired();
                entity.Property(e => e.ProposerPhone).HasMaxLength(20);
                entity.Property(e => e.ProposedOrgnization).HasMaxLength(200).IsRequired();
            });
        }
    }
}

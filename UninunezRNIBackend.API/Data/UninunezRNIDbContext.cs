using Microsoft.EntityFrameworkCore;
using UninunezRNIBackend.Models.Domain;

namespace UninunezRNIBackend.Data
{
    public class UninunezRNIDbContext : DbContext
    {
        public UninunezRNIDbContext(DbContextOptions<UninunezRNIDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<AgreementRequest> AgreementRequests { get; set; }

    }
}

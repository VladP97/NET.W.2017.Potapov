namespace DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BankContext : DbContext
    {
        public BankContext()
            : base("name=BankContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Balance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AccountType>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.AccountType)
                .WillCascadeOnDelete(false);
        }
    }
}

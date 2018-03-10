namespace CookiesParadise
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Cookies : DbContext
    {
        public Cookies()
            : base("name=Cookies")
        {
        }

        public virtual DbSet<Asis_CookiesTypes> Asis_CookiesTypes { get; set; }
        public virtual DbSet<Asis_Cookies> Asis_Cookies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asis_CookiesTypes>()
                .HasMany(e => e.Asis_Cookies)
                .WithRequired(e => e.Asis_CookiesTypes)
                .HasForeignKey(e => e.ItemTypeId);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HajosTeszt.MeseModels
{
    public partial class MeseContext : DbContext
    {
        public MeseContext()
        {
        }

        public MeseContext(DbContextOptions<MeseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tale> Tales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=sql153698.database.windows.net;Initial Catalog=Mese;Persist Security Info=True;User ID=dominiksadt;Password=Aysxdc0625");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Tale>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Tale");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tale1)
                    .IsRequired()
                    .HasColumnName("Tale");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

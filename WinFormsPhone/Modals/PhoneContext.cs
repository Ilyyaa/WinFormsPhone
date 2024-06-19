using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PhoneDB.Modals;

public partial class PhoneContext : DbContext
{
    public PhoneContext()
    {
    }

    public PhoneContext(DbContextOptions<PhoneContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Phonebook> Phonebooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost; Database=phone; username=postgres; password=00000; persist security info=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Phonebook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("phonebook_pkey");

            entity.ToTable("phonebook");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Flat).HasColumnName("flat");
            entity.Property(e => e.House)
                .HasColumnName("house");
            entity.Property(e => e.Lastname)
                .HasMaxLength(30)
                .HasColumnName("lastname");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(30)
                .HasColumnName("patronymic");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .HasColumnName("phone");
            entity.Property(e => e.Street)
                .HasMaxLength(60)
                .HasColumnName("street");
            //entity.HasCheckConstraint("", "phone ~ '^\\d{10}$'");
            //entity.HasCheckConstraint("", "house > 0");
            //entity.HasCheckConstraint("", "flat > 0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

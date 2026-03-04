using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace demm040326.Models;

public partial class Dem040326Context : DbContext
{
    public Dem040326Context()
    {
    }

    public Dem040326Context(DbContextOptions<Dem040326Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Adress> Adresses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusOrder> StatusOrders { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Tovar> Tovars { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=91.222.238.6;username=rover_user;password=root123;database=dem04.03.26", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Adress>(entity =>
        {
            entity.HasKey(e => e.Idadress).HasName("PRIMARY");

            entity.ToTable("adress");

            entity.Property(e => e.Idadress).HasColumnName("idadress");
            entity.Property(e => e.City)
                .HasMaxLength(45)
                .HasColumnName("city");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.NumberHouse).HasColumnName("number_house");
            entity.Property(e => e.Stret)
                .HasMaxLength(45)
                .HasColumnName("stret");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Idcategory).HasName("PRIMARY");

            entity.ToTable("category");

            entity.Property(e => e.Idcategory).HasColumnName("idcategory");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Idmanufacturer).HasName("PRIMARY");

            entity.ToTable("manufacturer");

            entity.Property(e => e.Idmanufacturer).HasColumnName("idmanufacturer");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder).HasName("PRIMARY");

            entity.ToTable("Order");

            entity.HasIndex(e => e.IdAdress, "id_adres_idx");

            entity.HasIndex(e => e.IdClient, "id_client_idx");

            entity.HasIndex(e => e.IdStatus, "id_status_idx");

            entity.Property(e => e.IdOrder).HasColumnName("idOrder");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.DateEndOrder).HasColumnName("date_end_order");
            entity.Property(e => e.DateOrder).HasColumnName("date_order");
            entity.Property(e => e.IdAdress).HasColumnName("id_adress");
            entity.Property(e => e.IdClient).HasColumnName("id_client");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");

            entity.HasOne(d => d.IdAdressNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdAdress)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_adres");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdClient)
                .HasConstraintName("id_client");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_status");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.IdOrderItems).HasName("PRIMARY");

            entity.ToTable("Order_items");

            entity.HasIndex(e => e.IdOrder, "ID_ORDER_idx");

            entity.HasIndex(e => e.IdTovar, "ID_TOVAR_idx");

            entity.Property(e => e.IdOrderItems).HasColumnName("idOrder_items");
            entity.Property(e => e.IdOrder).HasColumnName("id_Order");
            entity.Property(e => e.IdTovar).HasColumnName("id_tovar");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ID_ORDER");

            entity.HasOne(d => d.IdTovarNavigation).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.IdTovar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ID_TOVAR");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("Role");

            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StatusOrder>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.ToTable("Status_order");

            entity.Property(e => e.IdStatus).HasColumnName("idStatus");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Idsupplier).HasName("PRIMARY");

            entity.ToTable("supplier");

            entity.Property(e => e.Idsupplier).HasColumnName("idsupplier");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Tovar>(entity =>
        {
            entity.HasKey(e => e.IdTov).HasName("PRIMARY");

            entity.ToTable("tovar");

            entity.HasIndex(e => e.CategoryId, "id_cat_idx");

            entity.HasIndex(e => e.ManufId, "id_man_idx");

            entity.HasIndex(e => e.SupplierId, "id_suppl_idx");

            entity.Property(e => e.IdTov).HasColumnName("id_tov");
            entity.Property(e => e.Article)
                .HasMaxLength(45)
                .HasColumnName("article");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Discription)
                .HasMaxLength(590)
                .HasColumnName("discription");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.ManufId).HasColumnName("manuf_id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Salepercent).HasColumnName("salepercent");
            entity.Property(e => e.Sizeorder).HasColumnName("sizeorder");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.Unit)
                .HasMaxLength(45)
                .HasColumnName("unit");

            entity.HasOne(d => d.Category).WithMany(p => p.Tovars)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_cat");

            entity.HasOne(d => d.Manuf).WithMany(p => p.Tovars)
                .HasForeignKey(d => d.ManufId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_man");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Tovars)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_suppl");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.IdRole, "id_role_idx");

            entity.Property(e => e.Iduser).HasColumnName("iduser");
            entity.Property(e => e.Fio)
                .HasMaxLength(45)
                .HasColumnName("FIO");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

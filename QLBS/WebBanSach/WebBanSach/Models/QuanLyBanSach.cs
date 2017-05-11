namespace WebBanSach.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyBanSach : DbContext
    {
        public QuanLyBanSach()
            : base("name=QuanLyBanSach")
        {
        }

        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<GroupBook> GroupBooks { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Support> Supports { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Translator> Translators { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auth>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Auth>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.Auth)
                .HasForeignKey(e => e.Auth_Id);

            modelBuilder.Entity<Book>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Book>()
                .Property(e => e.PriceNew)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Book>()
                .Property(e => e.GroupBook_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Auth_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Translator_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Publisher_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<GroupBook>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<GroupBook>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.GroupBook)
                .HasForeignKey(e => e.GroupBook_Id);

            modelBuilder.Entity<Menu>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.User_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Province>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Shops)
                .WithOptional(e => e.Province)
                .HasForeignKey(e => e.Province_Id);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.Province_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Support>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Support>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Support>()
                .Property(e => e.Nick)
                .IsUnicode(false);

            modelBuilder.Entity<Translator>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_Id);
        }
    }
}

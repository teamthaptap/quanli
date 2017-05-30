namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ThaoMocShop : DbContext
    {
        public ThaoMocShop()
            : base("name=ThaoMocShop")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<HangSP> HangSPs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiNguoiDung> LoaiNguoiDungs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMuc>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.DanhMuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangSP>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.HangSP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.GiaCu)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.GiaMoi)
                .IsUnicode(false);
        }
    }
}

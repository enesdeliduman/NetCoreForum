using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Entites;

namespace NetCoreForum.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }  // Kategori tablosu
        public DbSet<Message> Messages { get; set; }  // Mesajlaşmalar tablosu
        public DbSet<Notification> Notifications { get; set; }  // Mesajlaşmalar tablosu
        public DbSet<Reply> Replies { get; set; }  // Cevap tablosu
        public DbSet<Report> Reports { get; set; }  // Şikayetler tablosu
        public DbSet<SiteSetting> SiteSettings { get; set; }  // Site ayarları tablosu (logo, site adı vs.)
        public DbSet<Topic> Topics { get; set; }  // Konu tablosu
        public DbSet<TopicType> TopicTypes { get; set; }  // Konu tablosu

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Topic silindiğinde Reply silinsin (Cascade Delete)
            modelBuilder.Entity<Reply>()
                .HasOne(r => r.Topic)
                .WithMany(t => t.Replies)
                .HasForeignKey(r => r.TopicID)
                .OnDelete(DeleteBehavior.Cascade);

            // AppUser silindiğinde Reply etkilenmesin (Restrict)
            modelBuilder.Entity<Reply>()
                .HasOne(r => r.AppUser)
                .WithMany(u => u.Replies)
                .HasForeignKey(r => r.AppUserID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Entites;

namespace NetCoreForum.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Log> Logs { get; set; } 
        public DbSet<Message> Messages { get; set; } 
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PendingUser> PendingUsers { get; set; } 
        public DbSet<Reply> Replies { get; set; } 
        public DbSet<Report> Reports { get; set; } 
        public DbSet<SiteSettings> SiteSettings { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<TopicType> TopicTypes { get; set; } 
        public DbSet<Warning> Warnings { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reply>()
                .HasOne(r => r.Topic)
                .WithMany(t => t.Replies)
                .HasForeignKey(r => r.TopicID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reply>()
                .HasOne(r => r.AppUser)
                .WithMany(u => u.Replies)
                .HasForeignKey(r => r.AppUserID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

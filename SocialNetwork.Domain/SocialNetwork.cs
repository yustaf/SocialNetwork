namespace SocialNetwork.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SocialNetwork : DbContext
    {
        public SocialNetwork()
            : base("name=SocialNetwork")
        {
        }

        public virtual DbSet<Authorization> Authorization { get; set; }
        public virtual DbSet<Friend> Friend { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Message1)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .Property(e => e.PatronymicName)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Authorization)
                .WithRequired(e => e.Profile)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Friend)
                .WithRequired(e => e.Profile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Friend1)
                .WithRequired(e => e.Profile1)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Message)
                .WithRequired(e => e.Profile)
                .HasForeignKey(e => e.FriendId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Message1)
                .WithRequired(e => e.Profile1)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}

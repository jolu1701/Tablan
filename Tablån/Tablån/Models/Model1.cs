namespace Tablån.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Channels> Channels { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Shows> Shows { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channels>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Channels>()
                .HasMany(e => e.Shows)
                .WithOptional(e => e.Channels)
                .HasForeignKey(e => e.Channel_id);

            modelBuilder.Entity<Genres>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Genres>()
                .HasMany(e => e.Shows)
                .WithOptional(e => e.Genres)
                .HasForeignKey(e => e.Genre_id);

            modelBuilder.Entity<Shows>()
                .Property(e => e.Title)
                .IsFixedLength();

            modelBuilder.Entity<Shows>()
                .Property(e => e.Info)
                .IsFixedLength();
        }
    }
}

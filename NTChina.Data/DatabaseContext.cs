using System.Data.Entity;
using NTChina.Data.Configuration;
using NTChina.Entity;

namespace NTChina.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Database") { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberConfiguration());
            modelBuilder.Configurations.Add(new NodeConfiguration());
            modelBuilder.Configurations.Add(new TopicConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

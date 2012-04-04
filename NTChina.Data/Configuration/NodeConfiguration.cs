using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using NTChina.Entity;

namespace NTChina.Data.Configuration
{
    public class NodeConfiguration : EntityTypeConfiguration<Node>
    {
        
        public NodeConfiguration()
        {
            HasKey(n => n.Id);
            Property(n => n.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            ToTable("Nodes");
        }
    }
}

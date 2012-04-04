using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using NTChina.Domain;

namespace NTChina.Data.Sqlserver.Configuration
{
    public class NodeConfiguration : EntityTypeConfiguration<Node>
    {
        
        public NodeConfiguration()
        {
            HasKey(n => n.Id);
            HasMany(n => n.Topics).WithMany(t => t.Nodes).Map(m=>
            {
                m.MapLeftKey("TopicId");
                m.MapRightKey("NodeId");
                m.ToTable("NodeTopicRelationship");
            });

            Property(n => n.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            ToTable("Nodes");
        }
    }
}

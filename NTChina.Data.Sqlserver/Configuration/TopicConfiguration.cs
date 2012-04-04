using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using NTChina.Domain;

namespace NTChina.Data.Sqlserver.Configuration
{
    public class TopicConfiguration : EntityTypeConfiguration<Topic>
    {
        public TopicConfiguration()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}

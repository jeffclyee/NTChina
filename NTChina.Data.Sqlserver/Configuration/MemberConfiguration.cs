using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using NTChina.Domain;

namespace NTChina.Data.Sqlserver.Configuration
{
    public class MemberConfiguration : EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            HasKey(m => m.Id);
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.MemberName).IsUnicode().IsRequired().HasMaxLength(32);
            Property(m => m.Password).IsUnicode().IsRequired().HasMaxLength(32);
            Property(m => m.Email).IsUnicode().IsRequired().HasMaxLength(256);

            ToTable("Members");
        }
    }
}

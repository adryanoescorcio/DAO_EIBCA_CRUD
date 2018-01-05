using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class UfMap : EntityTypeConfiguration<Uf>
    {
        public UfMap()
        {
            // Primary Key
            this.HasKey(t => t.UfId);

            // Properties
            this.Property(t => t.UfId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UfSigla)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.UfNome)
                .IsRequired()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("uf");
            this.Property(t => t.UfId).HasColumnName("ufid");
            this.Property(t => t.UfSigla).HasColumnName("ufsigla");
            this.Property(t => t.UfNome).HasColumnName("ufnome");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class DenominacaoMap : EntityTypeConfiguration<Denominacao>
    {
        public DenominacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.DenominacaoId);

            // Properties
            this.Property(t => t.DenominacaoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DenominacaoNome)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("denominacao");
            this.Property(t => t.DenominacaoId).HasColumnName("denominacaoid");
            this.Property(t => t.DenominacaoNome).HasColumnName("denominacaonome");
        }
    }
}

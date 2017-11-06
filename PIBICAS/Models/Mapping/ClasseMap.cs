using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class ClasseMap : EntityTypeConfiguration<Classe>
    {
        public ClasseMap()
        {
            // Primary Key
            this.HasKey(t => t.ClasseId);

            // Properties
            this.Property(t => t.ClasseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ClasseCodigo)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.ClasseCargaHoraria)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.ClasseStatus)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.ClasseUsuario)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ClasseTipoOperacao)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.ClasseRastro)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Classe");
            this.Property(t => t.ClasseId).HasColumnName("ClasseId");
            this.Property(t => t.ClasseMembresiaId).HasColumnName("ClasseMembresiaId");
            this.Property(t => t.ClasseCodigo).HasColumnName("ClasseCodigo");
            this.Property(t => t.ClasseDataInicio).HasColumnName("ClasseDataInicio");
            this.Property(t => t.ClasseDataFim).HasColumnName("ClasseDataFim");
            this.Property(t => t.ClasseObservacao).HasColumnName("ClasseObservacao");
            this.Property(t => t.ClasseCargaHoraria).HasColumnName("ClasseCargaHoraria");
            this.Property(t => t.ClasseStatus).HasColumnName("ClasseStatus");
            this.Property(t => t.ClasseUsuario).HasColumnName("ClasseUsuario");
            this.Property(t => t.ClasseTempo).HasColumnName("ClasseTempo");
            this.Property(t => t.ClasseTipoOperacao).HasColumnName("ClasseTipoOperacao");
            this.Property(t => t.ClasseRastro).HasColumnName("ClasseRastro");

            // Relationships
            this.HasRequired(t => t.Membresia)
                .WithMany(t => t.Classes)
                .HasForeignKey(d => d.ClasseMembresiaId);

        }
    }
}

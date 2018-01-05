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
                .HasMaxLength(20);

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
            this.ToTable("classe");
            this.Property(t => t.ClasseId).HasColumnName("classeid");
            this.Property(t => t.ClasseMembresiaId).HasColumnName("classemembresiaid");
            this.Property(t => t.ClasseCodigo).HasColumnName("classecodigo");
            this.Property(t => t.ClasseDataInicio).HasColumnName("classedatainicio");
            this.Property(t => t.ClasseDataFim).HasColumnName("classedatafim");
            this.Property(t => t.ClasseObservacao).HasColumnName("classeobservacao");
            this.Property(t => t.ClasseCargaHoraria).HasColumnName("classecargahoraria");
            this.Property(t => t.ClasseStatus).HasColumnName("classestatus");
            this.Property(t => t.ClasseUsuario).HasColumnName("classeusuario");
            this.Property(t => t.ClasseTempo).HasColumnName("classetempo");
            this.Property(t => t.ClasseTipoOperacao).HasColumnName("classetipooperacao");
            this.Property(t => t.ClasseRastro).HasColumnName("classerastro");

            // Relationships
            this.HasRequired(t => t.Membresia)
                .WithMany(t => t.Classes)
                .HasForeignKey(d => d.ClasseMembresiaId);

        }
    }
}

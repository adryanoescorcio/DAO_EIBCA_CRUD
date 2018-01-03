using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class FrequenciaMap : EntityTypeConfiguration<Frequencia>
    {
        public FrequenciaMap()
        {
            // Primary Key
            this.HasKey(t => t.FrequenciaId);

            // Properties
            this.Property(t => t.FrequenciaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FrequenciaSituacao)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.FrequenciaUsuario)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FrequenciaTipoOperacao)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.FrequenciaRastro)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FrequenciaUnique)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Frequencia");
            this.Property(t => t.FrequenciaId).HasColumnName("FrequenciaId");
            this.Property(t => t.PlanoId).HasColumnName("PlanoId");
            this.Property(t => t.ClasseId).HasColumnName("ClasseId");
            this.Property(t => t.ListaId).HasColumnName("ListaId");
            this.Property(t => t.FrequenciaSituacao).HasColumnName("FrequenciaSituacao");
            this.Property(t => t.FrequenciaUsuario).HasColumnName("FrequenciaUsuario");
            this.Property(t => t.FrequenciaData).HasColumnName("FrequenciaData");
            this.Property(t => t.FrequenciaTempo).HasColumnName("FrequenciaTempo");
            this.Property(t => t.FrequenciaTipoOperacao).HasColumnName("FrequenciaTipoOperacao");
            this.Property(t => t.FrequenciaRastro).HasColumnName("FrequenciaRastro");
            this.Property(t => t.FrequenciaUnique).HasColumnName("FrequencaUnique");

            // Relationships
            this.HasRequired(t => t.Classe)
                .WithMany(t => t.Frequencias)
                .HasForeignKey(d => d.ClasseId);
            this.HasRequired(t => t.Plano)
                .WithMany(t => t.Frequencias)
                .HasForeignKey(d => d.PlanoId);
            this.HasRequired(t => t.Lista)
                .WithMany(t => t.Frequencias)
                .HasForeignKey(d => d.ListaId);

        }
    }
}

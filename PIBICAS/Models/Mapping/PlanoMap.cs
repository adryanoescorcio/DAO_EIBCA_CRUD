using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class PlanoMap : EntityTypeConfiguration<Plano>
    {
        public PlanoMap()
        {
            // Primary Key
            this.HasKey(t => t.PlanoId);

            // Properties
            this.Property(t => t.PlanoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PlanoDescricao)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PlanoProfessor)
                .HasMaxLength(100);

            this.Property(t => t.PlanoUsuario)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PlanoTipoOperacao)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.PlanoRastro)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Plano");
            this.Property(t => t.PlanoId).HasColumnName("PlanoId");
            this.Property(t => t.PlanoClasseId).HasColumnName("PlanoClasseId");
            this.Property(t => t.PlanoDescricao).HasColumnName("PlanoDescricao");
            this.Property(t => t.PlanoProfessor).HasColumnName("PlanoProfessor");
            this.Property(t => t.PlanoDataPrevista).HasColumnName("PlanoDataPrevista");
            this.Property(t => t.PlanoHoraAula).HasColumnName("PlanoHoraAula");
            this.Property(t => t.PlanoObservacao).HasColumnName("PlanoObservacao");
            this.Property(t => t.PlanoUsuario).HasColumnName("PlanoUsuario");
            this.Property(t => t.PlanoTempo).HasColumnName("PlanoTempo");
            this.Property(t => t.PlanoTipoOperacao).HasColumnName("PlanoTipoOperacao");
            this.Property(t => t.PlanoRastro).HasColumnName("PlanoRastro");

            // Relationships
            this.HasRequired(t => t.Classe)
                .WithMany(t => t.Planoes)
                .HasForeignKey(d => d.PlanoClasseId);

        }
    }
}

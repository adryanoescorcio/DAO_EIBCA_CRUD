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
            this.ToTable("plano");
            this.Property(t => t.PlanoId).HasColumnName("planoid");
            this.Property(t => t.PlanoClasseId).HasColumnName("planoclasseid");
            this.Property(t => t.PlanoDescricao).HasColumnName("planodescricao");
            this.Property(t => t.PlanoProfessor).HasColumnName("planoprofessor");
            this.Property(t => t.PlanoDataPrevista).HasColumnName("planodataprevista");
            this.Property(t => t.PlanoHoraAula).HasColumnName("planohoraaula");
            this.Property(t => t.PlanoObservacao).HasColumnName("planoobservacao");
            this.Property(t => t.PlanoUsuario).HasColumnName("planousuario");
            this.Property(t => t.PlanoTempo).HasColumnName("planotempo");
            this.Property(t => t.PlanoTipoOperacao).HasColumnName("planotipooperacao");
            this.Property(t => t.PlanoRastro).HasColumnName("planorastro");

            // Relationships
            this.HasRequired(t => t.Classe)
                .WithMany(t => t.Planoes)
                .HasForeignKey(d => d.PlanoClasseId);

        }
    }
}

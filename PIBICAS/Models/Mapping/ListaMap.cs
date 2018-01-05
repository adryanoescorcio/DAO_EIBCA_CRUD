using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class ListaMap : EntityTypeConfiguration<Lista>
    {
        public ListaMap()
        {
            // Primary Key
            this.HasKey(t => t.ListaId);

            // Properties
            this.Property(t => t.ListaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("lista");
            this.Property(t => t.ListaId).HasColumnName("listaid");
            this.Property(t => t.ListaClasseId).HasColumnName("listaclasseid");
            this.Property(t => t.ListaAlunoId).HasColumnName("listaalunoid");

            // Relationships
            this.HasRequired(t => t.Aluno)
                .WithMany(t => t.Listas)
                .HasForeignKey(d => d.ListaAlunoId);
            this.HasRequired(t => t.Classe)
                .WithMany(t => t.Listas)
                .HasForeignKey(d => d.ListaClasseId);

        }
    }
}

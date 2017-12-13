using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class ClassePlanoAulaMap : EntityTypeConfiguration<ClassePlanoAula>
    {
        public ClassePlanoAulaMap()
        {
            // Primary Key
            this.HasKey(t => t.ClassePlanoAulaId);

            // Properties
            this.Property(t => t.ClassePlanoAulaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("ClassePlanoAula");
            this.Property(t => t.ClassePlanoAulaId).HasColumnName("ClassePlanoAulaId");
            this.Property(t => t.ClasseId).HasColumnName("ClasseId");
            this.Property(t => t.PlanoAulaId).HasColumnName("PlanoAulaId");

            // Relationships
            this.HasRequired(t => t.Classe)
                .WithMany(t => t.ClassePlanoAulas)
                .HasForeignKey(d => d.ClasseId);

            // Relationships
            this.HasRequired(t => t.Plano)
                .WithMany(t => t.ClassePlanoAulas)
                .HasForeignKey(d => d.PlanoAulaId);

        }
    }
}

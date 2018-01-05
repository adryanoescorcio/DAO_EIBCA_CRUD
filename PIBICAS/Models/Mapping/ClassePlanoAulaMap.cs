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
            this.ToTable("classeplanoaula");
            this.Property(t => t.ClassePlanoAulaId).HasColumnName("classeplanoaulaid");
            this.Property(t => t.ClasseId).HasColumnName("classeid");
            this.Property(t => t.PlanoAulaId).HasColumnName("planoaulaid");

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

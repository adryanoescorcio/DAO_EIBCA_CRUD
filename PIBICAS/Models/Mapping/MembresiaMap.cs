using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class MembresiaMap : EntityTypeConfiguration<Membresia>
    {
        public MembresiaMap()
        {
            // Primary Key
            this.HasKey(t => t.MembresiaId);

            // Properties
            this.Property(t => t.MembresiaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MembresiaMatricula)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.MembresiaStatus)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("membresia");
            this.Property(t => t.MembresiaId).HasColumnName("membresiaid");
            this.Property(t => t.MembresiaUsuarioId).HasColumnName("membresiausuarioid");
            this.Property(t => t.MembresiaIgrejaID).HasColumnName("membresiaigrejaid");
            this.Property(t => t.MembresiaPerfilID).HasColumnName("membresiaperfilid");
            this.Property(t => t.MembresiaMatricula).HasColumnName("membresiamatricula");
            this.Property(t => t.MembresiaStatus).HasColumnName("membresiastatus");

            // Relationships
            this.HasRequired(t => t.Igreja)
                .WithMany(t => t.Membresias)
                .HasForeignKey(d => d.MembresiaIgrejaID);
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.Membresias)
                .HasForeignKey(d => d.MembresiaUsuarioId);
            this.HasRequired(t => t.Perfil)
                .WithMany(t => t.Membresias)
                .HasForeignKey(d => d.MembresiaPerfilID);

        }
    }
}

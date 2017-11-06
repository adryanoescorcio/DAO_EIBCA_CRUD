using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.UsuarioId);

            // Properties
            this.Property(t => t.UsuarioId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UsuarioNome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UsuarioSobrenome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.UsuarioDetalhes)
                .HasMaxLength(50);

            this.Property(t => t.UsuarioSexo)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.UsuarioEmail)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UsuarioSenha)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.UsuarioCPF)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.UsuarioTrocarSenha)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.UsuarioStatus)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.UsuarioUsuario)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UsuarioTipoOperacao)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.UsuarioRastro)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.UsuarioId).HasColumnName("UsuarioId");
            this.Property(t => t.UsuarioMunicipioId).HasColumnName("UsuarioMunicipioId");
            this.Property(t => t.UsuarioNome).HasColumnName("UsuarioNome");
            this.Property(t => t.UsuarioSobrenome).HasColumnName("UsuarioSobrenome");
            this.Property(t => t.UsuarioDetalhes).HasColumnName("UsuarioDetalhes");
            this.Property(t => t.UsuarioSexo).HasColumnName("UsuarioSexo");
            this.Property(t => t.UsuarioEmail).HasColumnName("UsuarioEmail");
            this.Property(t => t.UsuarioSenha).HasColumnName("UsuarioSenha");
            this.Property(t => t.UsuarioCPF).HasColumnName("UsuarioCPF");
            this.Property(t => t.UsuarioTentativaErro).HasColumnName("UsuarioTentativaErro");
            this.Property(t => t.UsuarioTrocarSenha).HasColumnName("UsuarioTrocarSenha");
            this.Property(t => t.UsuarioDataValidade).HasColumnName("UsuarioDataValidade");
            this.Property(t => t.UsuarioStatus).HasColumnName("UsuarioStatus");
            this.Property(t => t.UsuarioUsuario).HasColumnName("UsuarioUsuario");
            this.Property(t => t.UsuarioTempo).HasColumnName("UsuarioTempo");
            this.Property(t => t.UsuarioTipoOperacao).HasColumnName("UsuarioTipoOperacao");
            this.Property(t => t.UsuarioRastro).HasColumnName("UsuarioRastro");

            // Relationships
            this.HasOptional(t => t.Municipio)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.UsuarioMunicipioId);

        }
    }
}

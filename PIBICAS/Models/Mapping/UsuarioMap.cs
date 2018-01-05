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
                .HasMaxLength(150);

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
            this.ToTable("usuario");
            this.Property(t => t.UsuarioId).HasColumnName("usuarioid");
            this.Property(t => t.UsuarioMunicipioId).HasColumnName("usuariomunicipioid");
            this.Property(t => t.UsuarioNome).HasColumnName("usuarionome");
            this.Property(t => t.UsuarioSobrenome).HasColumnName("usuariosobrenome");
            this.Property(t => t.UsuarioDetalhes).HasColumnName("usuariodetalhes");
            this.Property(t => t.UsuarioSexo).HasColumnName("usuariosexo");
            this.Property(t => t.UsuarioEmail).HasColumnName("usuarioemail");
            this.Property(t => t.UsuarioSenha).HasColumnName("usuariosenha");
            this.Property(t => t.UsuarioCPF).HasColumnName("usuariocpf");
            this.Property(t => t.UsuarioTentativaErro).HasColumnName("usuariotentativaerro");
            this.Property(t => t.UsuarioTrocarSenha).HasColumnName("usuariotrocarsenha");
            this.Property(t => t.UsuarioDataValidade).HasColumnName("usuariodatavalidade");
            this.Property(t => t.UsuarioStatus).HasColumnName("usuariostatus");
            this.Property(t => t.UsuarioUsuario).HasColumnName("usuariousuario");
            this.Property(t => t.UsuarioTempo).HasColumnName("usuariotempo");
            this.Property(t => t.UsuarioTipoOperacao).HasColumnName("usuariotipooperacao");
            this.Property(t => t.UsuarioRastro).HasColumnName("usuariorastro");

            // Relationships
            this.HasOptional(t => t.Municipio)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.UsuarioMunicipioId);

        }
    }
}

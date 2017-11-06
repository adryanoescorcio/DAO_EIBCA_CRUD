using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class UsuarioFuncionalidadeMap : EntityTypeConfiguration<UsuarioFuncionalidade>
    {
        public UsuarioFuncionalidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.UsuarioFuncionalidadeId);

            // Properties
            this.Property(t => t.UsuarioFuncionalidadeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UsuarioFuncionalidadePrincipal)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.UsuarioFuncionalidadeUsuario)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UsuarioFuncionalidadeTipoOperacao)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UsuarioFuncionalidadeRastro)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("UsuarioFuncionalidade");
            this.Property(t => t.UsuarioFuncionalidadeId).HasColumnName("UsuarioFuncionalidadeId");
            this.Property(t => t.UsuarioID).HasColumnName("UsuarioID");
            this.Property(t => t.FuncionalidadeId).HasColumnName("FuncionalidadeId");
            this.Property(t => t.UsuarioFuncionalidadePrincipal).HasColumnName("UsuarioFuncionalidadePrincipal");
            this.Property(t => t.UsuarioFuncionalidadeUsuario).HasColumnName("UsuarioFuncionalidadeUsuario");
            this.Property(t => t.UsuarioFuncionalidadeTempo).HasColumnName("UsuarioFuncionalidadeTempo");
            this.Property(t => t.UsuarioFuncionalidadeTipoOperacao).HasColumnName("UsuarioFuncionalidadeTipoOperacao");
            this.Property(t => t.UsuarioFuncionalidadeRastro).HasColumnName("UsuarioFuncionalidadeRastro");

            // Relationships
            this.HasRequired(t => t.Funcionalidade)
                .WithMany(t => t.UsuarioFuncionalidades)
                .HasForeignKey(d => d.FuncionalidadeId);
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.UsuarioFuncionalidades)
                .HasForeignKey(d => d.UsuarioID);

        }
    }
}

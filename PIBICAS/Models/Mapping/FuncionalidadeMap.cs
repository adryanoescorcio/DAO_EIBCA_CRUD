using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class FuncionalidadeMap : EntityTypeConfiguration<Funcionalidade>
    {
        public FuncionalidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.FuncionalidadeId);

            // Properties
            this.Property(t => t.FuncionalidadeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FuncionalidadeNome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FuncionalidadeUsuario)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FuncionalidadeTipoOperacao)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FuncionalidadeRastro)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("funcionalidade");
            this.Property(t => t.FuncionalidadeId).HasColumnName("funcionalidadeid");
            this.Property(t => t.FuncionalidadeNome).HasColumnName("funcionalidadenome");
            this.Property(t => t.FuncionalidadeUsuario).HasColumnName("funcionalidadeusuario");
            this.Property(t => t.FuncionalidadeTempo).HasColumnName("funcionalidadetempo");
            this.Property(t => t.FuncionalidadeTipoOperacao).HasColumnName("funcionalidadetipooperacao");
            this.Property(t => t.FuncionalidadeRastro).HasColumnName("funcionalidaderastro");
        }
    }
}

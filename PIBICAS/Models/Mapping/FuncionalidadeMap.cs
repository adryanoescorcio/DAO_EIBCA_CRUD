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
            this.ToTable("Funcionalidade");
            this.Property(t => t.FuncionalidadeId).HasColumnName("FuncionalidadeId");
            this.Property(t => t.FuncionalidadeNome).HasColumnName("FuncionalidadeNome");
            this.Property(t => t.FuncionalidadeUsuario).HasColumnName("FuncionalidadeUsuario");
            this.Property(t => t.FuncionalidadeTempo).HasColumnName("FuncionalidadeTempo");
            this.Property(t => t.FuncionalidadeTipoOperacao).HasColumnName("FuncionalidadeTipoOperacao");
            this.Property(t => t.FuncionalidadeRastro).HasColumnName("FuncionalidadeRastro");
        }
    }
}

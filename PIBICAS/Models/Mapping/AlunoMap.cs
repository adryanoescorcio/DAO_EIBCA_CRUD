using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            // Primary Key
            this.HasKey(t => t.AlunoId);

            // Properties
            this.Property(t => t.AlunoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.AlunoNome)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.AlunoCPF)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.AlunoSituacao)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.AlunoRepetir)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.AlunoCelular1)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.AlunoCelular2)
                .HasMaxLength(13);

            this.Property(t => t.AlunoEscolaridade)
                .HasMaxLength(45);

            this.Property(t => t.AlunoEquipe)
                .HasMaxLength(50);

            this.Property(t => t.AlunoCelula)
                .HasMaxLength(50);

            this.Property(t => t.AlunoDiscipulador)
                .HasMaxLength(50);

            this.Property(t => t.AlunoUsuario)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.AlunoTipoOperacao)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.AlunoRastro)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Aluno");
            this.Property(t => t.AlunoId).HasColumnName("AlunoId");
            this.Property(t => t.AlunoNome).HasColumnName("AlunoNome");
            this.Property(t => t.AlunoCPF).HasColumnName("AlunoCPF");
            this.Property(t => t.AlunoSituacao).HasColumnName("AlunoSituacao");
            this.Property(t => t.AlunoRepetir).HasColumnName("AlunoRepetir");
            this.Property(t => t.AlunoDataNascimento).HasColumnName("AlunoDataNascimento");
            this.Property(t => t.AlunoCelular1).HasColumnName("AlunoCelular1");
            this.Property(t => t.AlunoCelular2).HasColumnName("AlunoCelular2");
            this.Property(t => t.AlunoEscolaridade).HasColumnName("AlunoEscolaridade");
            this.Property(t => t.AlunoEquipe).HasColumnName("AlunoEquipe");
            this.Property(t => t.AlunoCelula).HasColumnName("AlunoCelula");
            this.Property(t => t.AlunoDiscipulador).HasColumnName("AlunoDiscipulador");
            this.Property(t => t.AlunoBatismo).HasColumnName("AlunoBatismo");
            this.Property(t => t.AlunoUsuario).HasColumnName("AlunoUsuario");
            this.Property(t => t.AlunoTempo).HasColumnName("AlunoTempo");
            this.Property(t => t.AlunoTipoOperacao).HasColumnName("AlunoTipoOperacao");
            this.Property(t => t.AlunoRastro).HasColumnName("AlunoRastro");
        }
    }
}

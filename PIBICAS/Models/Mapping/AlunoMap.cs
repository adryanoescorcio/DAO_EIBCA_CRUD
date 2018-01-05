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
                .HasMaxLength(100);

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
            this.ToTable("aluno");
            this.Property(t => t.AlunoId).HasColumnName("alunoid");
            this.Property(t => t.AlunoNome).HasColumnName("alunonome");
            this.Property(t => t.AlunoCPF).HasColumnName("alunocpf");
            this.Property(t => t.AlunoSituacao).HasColumnName("alunosituacao");
            this.Property(t => t.AlunoRepetir).HasColumnName("alunorepetir");
            this.Property(t => t.AlunoDataNascimento).HasColumnName("alunodatanascimento");
            this.Property(t => t.AlunoCelular1).HasColumnName("alunocelular1");
            this.Property(t => t.AlunoCelular2).HasColumnName("alunocelular2");
            this.Property(t => t.AlunoEscolaridade).HasColumnName("alunoescolaridade");
            this.Property(t => t.AlunoEquipe).HasColumnName("alunoequipe");
            this.Property(t => t.AlunoCelula).HasColumnName("alunocelula");
            this.Property(t => t.AlunoDiscipulador).HasColumnName("alunodiscipulador");
            this.Property(t => t.AlunoBatismo).HasColumnName("alunobatismo");
            this.Property(t => t.AlunoUsuario).HasColumnName("alunousuario");
            this.Property(t => t.AlunoTempo).HasColumnName("alunotempo");
            this.Property(t => t.AlunoTipoOperacao).HasColumnName("alunotipooperacao");
            this.Property(t => t.AlunoRastro).HasColumnName("alunorastro");
        }
    }
}

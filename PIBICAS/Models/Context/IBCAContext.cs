using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PIBICAS.Models.Mapping;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PIBICAS.Models.Context
{
    public partial class IBCAContext : DbContext
    {
        static IBCAContext()
        {
            Database.SetInitializer<IBCAContext>(null);
        }

        public IBCAContext()
            : base("IBCAContext")
        {
        }

        private const string schemaName = "IBCA";

        public DbSet<Acesso> Acessoes { get; set; }
        public DbSet<Aluno> Alunoes { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<ClassePlanoAula> ClassePlanoAulas { get; set; }
        public DbSet<Denominacao> Denominacaos { get; set; }
        public DbSet<Frequencia> Frequencias { get; set; }
        public DbSet<Funcionalidade> Funcionalidades { get; set; }
        public DbSet<Igreja> Igrejas { get; set; }
        public DbSet<Lista> Listas { get; set; }
        public DbSet<Membresia> Membresias { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Plano> Planoes { get; set; }
        public DbSet<Uf> Ufs { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioFuncionalidade> UsuarioFuncionalidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // modelBuilder.HasDefaultSchema(schemaName);

            modelBuilder.Configurations.Add(new AcessoMap());
            modelBuilder.Configurations.Add(new AlunoMap());
            modelBuilder.Configurations.Add(new ClasseMap());
            modelBuilder.Configurations.Add(new ClassePlanoAulaMap());
            modelBuilder.Configurations.Add(new DenominacaoMap());
            modelBuilder.Configurations.Add(new FrequenciaMap());
            modelBuilder.Configurations.Add(new FuncionalidadeMap());
            modelBuilder.Configurations.Add(new IgrejaMap());
            modelBuilder.Configurations.Add(new ListaMap());
            modelBuilder.Configurations.Add(new MembresiaMap());
            modelBuilder.Configurations.Add(new MunicipioMap());
            modelBuilder.Configurations.Add(new PerfilMap());
            modelBuilder.Configurations.Add(new PlanoMap());
            modelBuilder.Configurations.Add(new UfMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new UsuarioFuncionalidadeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

using System.Data.Entity;

namespace FormularioAspNetMVC.Models
{
    public class CadastroContext : DbContext
    {
        public CadastroContext() : base("DbCadastroPessoa")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CadastroContext>());
            Database.Initialize(false);
        }   

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
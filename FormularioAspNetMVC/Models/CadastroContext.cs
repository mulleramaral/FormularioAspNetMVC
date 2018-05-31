using System.Data.Entity;

namespace FormularioAspNetMVC.Models
{
    public class CadastroContext : DbContext
    {
        public CadastroContext() : base("DbCadastroPessoa")
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
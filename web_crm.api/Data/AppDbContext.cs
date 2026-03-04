using Microsoft.EntityFrameworkCore;
using web_crm.api.Models;

namespace web_crm.api.Data {


    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        // É aqui que colocaremos as tabelas depois (Ex: public DbSet<Produto> Produtos { get; set; })

        public DbSet<ProdutosModel> produtos { get; set; }
        public DbSet<UsuarioModel> usuarios { get; set; }
    }
}


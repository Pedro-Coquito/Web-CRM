using Microsoft.EntityFrameworkCore;

namespace web_crm.api.Data {


        public class AppDbContext : DbContext {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
            }

            // É aqui que colocaremos as tabelas depois (Ex: public DbSet<Produto> Produtos { get; set; })
        }
    }
}
}

using Microsoft.EntityFrameworkCore;
using web_crm.api.Models;

namespace web_crm.api.Data {


    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        // É aqui que colocaremos as tabelas depois (Ex: public DbSet<Produto> Produtos { get; set; })

        public DbSet<ProdutosModel> produtos { get; set; }
        public DbSet<UsuarioModel> usuarios { get; set; }

        public DbSet<FornecedorModel> fornecedor { get; set; }
        public DbSet<FornecedorDocModels> fornecedor_documentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            //converte enum para string
            modelBuilder.Entity<FornecedorModel>().Property(e => e.TipoDepessoa).HasConversion<string>();

            //configura relação 1:1 
            modelBuilder.Entity<FornecedorModel>().HasOne(e => e.Documento).WithOne(d => d.Fornecedor).HasForeignKey<FornecedorDocModels>(d => d.EntidadeId);
        }
    }
}


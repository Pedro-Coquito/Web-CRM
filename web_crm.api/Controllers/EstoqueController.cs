using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web_crm.api.Data;
using web_crm.api.Models;


namespace web_crm.api.Controllers {

    [ApiController]
    [Route("api/estoque")]
    public class EstoqueController : ControllerBase {

        private readonly AppDbContext _bancoDeDados;

        public EstoqueController(AppDbContext bancoDeDados) {

            _bancoDeDados = bancoDeDados;
        }

        [HttpGet]
        public IActionResult ListarProdutos() {
            var listaDeProdutos = _bancoDeDados.produtos.ToList();

            return Ok(listaDeProdutos);
        }

        [HttpPost]
        public IActionResult CadastrarProduto([FromBody] ProdutosModel novoProduto) {

            _bancoDeDados.produtos.Add(novoProduto);
            _bancoDeDados.SaveChanges();

            return Ok(novoProduto);
        }

    }
}

        /*
        [HttpPut]
        
        public IActionResult AtualizarProduto(int id, [FromBody] ProdutosModel produtoAtualizado) {
            var produtoNoBanco = _bancoDeDados.produtos.Find(id);

            if (produtoNoBanco == null) {
                return NotFound(new {
                    mensagem = "Produto Não Encontrado"
                });



                produtoNoBanco.Nome = produtoAtualizado.Nome;
                produtoAtualizado.ValorCompra = produtoAtualizado.ValorCompra;
                produtoAtualizado.Preco = produtoAtualizado.Preco;
                produtoAtualizado.Peso = produtoAtualizado.Peso;


                _bancoDeDados.SaveChanges();

                return Ok(produtoNoBanco);
            }
        }
    }
}

        /*

    public void CadastrarProduto(ProdutosModel produtos) {

            using (var db = DbEnv.GetConnection()) {

                Console.WriteLine("Abrindo conexão");
                db.Open();

                string sql = "INSERT INTO produtos (nomeProdutos, pesoProdutos, valorDeCompra, preco) VALUES (@nome, @peso, @valor, @preco)";

                using (var cmd = new MySqlCommand(sql, db)) {



                    cmd.Parameters.AddWithValue("@nome", produtos.Nome);
                    cmd.Parameters.AddWithValue("@peso", produtos.Peso);
                    cmd.Parameters.AddWithValue("@valor", produtos.ValorCompra);
                    cmd.Parameters.AddWithValue("@preco", produtos.Preco);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine($"{produtos.Nome} Cadastrado.");
                }

            }
        }

    }
} */
        
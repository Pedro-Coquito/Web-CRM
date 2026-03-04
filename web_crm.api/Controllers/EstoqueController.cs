using System;
using Pomelo.EntityFrameworkCore;
using web_crm.api.Models;


namespace web_crm.api.Controllers {
    internal class EstoqueController {

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
}

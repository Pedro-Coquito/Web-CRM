using Pomelo.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace web_crm.api.Controllers{ 
    public class UsersController {


        public void CadastrarUser(UsuarioModel users) {

            using (var db = DbEnv.GetConnection()) {

                db.Open();
                Console.WriteLine("CONEXÃO ABERTA");

                string sql = "INSERT INTO users (nameUsers, senhaUsers, atributoUsers) VALUES (@nome, @senha, @atributos)";


                using (var cmd = new MySqlCommand(sql, db)) {

                    cmd.Parameters.AddWithValue("@nome", users.Nome);
                    cmd.Parameters.AddWithValue("@senha", users.Senha);
                    cmd.Parameters.AddWithValue("@atributos", users.Atributos);


                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}

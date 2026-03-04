using System;
using System.Collections.Generic;
using System.Text;

namespace web_crm.api.Models {
    public class UsuarioModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Atributos { get; set; }


        public UsuarioModel() {

        }


        public UsuarioModel(string nome, string senha, string atributos) {
            Nome = nome;
            Senha = senha;
            Atributos = atributos;
        }
        



    }
}

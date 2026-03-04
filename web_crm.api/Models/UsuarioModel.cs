using System.ComponentModel.DataAnnotations.Schema;

namespace web_crm.api.Models {

    [Table("users")]
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

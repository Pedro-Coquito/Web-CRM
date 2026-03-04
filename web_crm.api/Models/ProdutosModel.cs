using System.ComponentModel.DataAnnotations.Schema;



namespace web_crm.api.Models { 

    [Table("produtos")]
    public class ProdutosModel {
        public int Id {  get; private set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Preco { get; set; }
        public double ValorCompra {  get; set; }

        public ProdutosModel() {
          
        }

        public ProdutosModel(string nome, double peso, double preco, double valorCompra) { 
         
            Nome = nome;
            Peso = peso;
            Preco = preco;
            ValorCompra = valorCompra;
            
        
        }

        public void GetId(int id) {
            this.Id = id;   
        }


    }
}

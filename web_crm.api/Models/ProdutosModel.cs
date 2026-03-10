using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace web_crm.api.Models { 

    [Table("produtos")]
    public class ProdutosModel {

        [Key]
        [Column("idProdutos")]
        public int Id {  get; set; }

        [Column("nomeProdutos")]
        public string Nome { get; set; }

        [Column("pesoProdutos")]
        public double Peso { get; set; }

        [Column("preco")]
        public double Preco { get; set; }
        [Column("valorDeCompra")]
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

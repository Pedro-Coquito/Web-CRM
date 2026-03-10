using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_crm.api.Models {

    public enum Tipo_pessoa {
        Fisca,
        Juridica
    }

    [Table("entidades")]
    public class FornecedorModel {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Column("contribuinte_id")]
        public int ContribuinteId { get; set; }

        [Column("Codigo")]
        public string Codigo { get; set; }

        [Column("tipo_pessoa")]
        public Tipo_pessoa TipoDepessoa{ get; set; }

        [Column("cliente_desde")]
        public DateTime ClienteDesde { get; set; }

        [Column("criado_em")]
        public DateTime CriadoEm {  get; set; }


        public FornecedorDocModels Documento{ get; set; }


    }
}

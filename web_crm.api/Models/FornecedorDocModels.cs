using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_crm.api.Models {

    [Table("entidades_documentos")]
    public class FornecedorDocModels {

        [Key]
        [Column("entidade_id")]
        public int EntidadeId { get; set; }

        [Column("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [Column("cpf_cnpj")]
        public string Cpf_Cnpj {  get; set; }

        [Column("rg")]
        public string Rg {  get; set; }

        [Column("orgao_emissor")]
        public string OrgaoEmissor {  get; set; }

        [Column("inscricao_estadual")]
        public string InscricaoEstadual {  get; set; }



        [ForeignKey("entidade_id")]
        public FornecedorModel Fornecedor { get; set; }
    }
}

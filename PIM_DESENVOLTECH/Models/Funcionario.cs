using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIM_DESENVOLTECH.Models
{
    public class Funcionario
    {
        [Column("IdFuncionario")]
        [Display(Name = "Código Funcionario")]
        [Key]
        public int IdFuncionario { get; set; }

        [Column("PK_IdPessoa")]
        [Display(Name = "Código Pessoa")]
        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }

        [Column("NomeCargo")]
        [Display(Name = "Nome Cargo")]
        public string? NomeCargo { get; set; }

        [Column("Salario")]
        [Display(Name = "Salario")]
        public string? Salario { get; set; }

        [Column("DataAdmissao")]
        [Display(Name = "Data Admissão")]
        public DateTime DataAdmissao { get; set; }

        [Column("DataDemissao")]
        [Display(Name = "Data Demissão")]
        public DateTime DataDemissao { get; set; }

        [Column("FuncionarioAtivo")]
        [Display(Name = "Código Funcionario Ativo")]
        public bool FuncionarioAtivo { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIM_DESENVOLTECH.Models
{
    public class Logradouro
    {
        [Column("IdLogradouro")]
        [Display(Name = "Código Logradouro")]
        [Key]
        public int IdLogradouro { get; set; }

        [Column("PK_IdPessoa")]
        [Display(Name = "Código Pessoa")]
        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }

        [Column("PK_IdFuncionario")]
        [Display(Name = "Código Funcionario")]
        [ForeignKey("Funcionario")]
        public int IdFuncionario { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        public string? CEP { get; set; }

        [Column("NumeroRua")]
        [Display(Name = "NumeroRua")]
        public string? NumeroRua { get; set; }

        [Column("Complemento")]
        [Display(Name = "Complemento")]
        public string? Complemento { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public string? Estado { get; set; }         

    }
}

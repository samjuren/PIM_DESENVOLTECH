using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIM_DESENVOLTECH.Models
{
    public class Pessoa
    {
        [Column("IdPessoa")]
        [Display(Name = "Código Pessoa")]
        [Key]
        public int IdPessoa { get; set; }

        [Column("PK_IdFuncionario")]
        [Display(Name = "Código Funcionario")]
        [ForeignKey("Funcionario")]
        public int IdFuncionario { get; set; }

        [Column("IdLogradouro")]
        [Display(Name = "Código Logradouro")]
        [ForeignKey("Logradouro")]
        public int IdLogradouro { get; set; }

        [Column("NomeCompleto")]
        [Display(Name = "Nome Completo")]
        public string? NomeCompleto { get; set; }

        [Column("Idade")]
        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Column("Nascimento")]
        [Display(Name = "Nascimento")]
        public DateTime Nascimento { get; set; }

        [Column("RG")]
        [Display(Name = "RG")]
        public string? RG { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string? CPF { get; set; }
    }
}

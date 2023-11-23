using Microsoft.Extensions.WebEncoders.Testing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM_DESENVOLTECH.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            Descontos = new DescontosSalariais();

        }    


        [Column("IdFuncionario")]
        [Display(Name = "Código Funcionario")]
        [Key]
        public int IdFuncionario { get; set; }

        [Column("NomeCargo")]
        [Display(Name = "Nome Cargo")]
        public string? NomeCargo { get; set; }

        [Column("Salario")]
        [Display(Name = "Salario")]
        public double Salario { get; set; }

        [Column("DataAdmissao")]
        [Display(Name = "Data Admissão")]
        public DateTime DataAdmissao { get; set; }

        [Column("DataDemissao")]
        [Display(Name = "Data Demissão")]
        public DateTime DataDemissao { get; set; }

        [Column("FuncionarioAtivo")]
        [Display(Name = "Código Funcionario Ativo")]
        public bool FuncionarioAtivo { get; set; }

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

        [Column("CEP")]
        [Display(Name = "CEP")]
        public string? CEP { get; set; }

        [Column("NumeroRua")]
        [Display(Name = "NumeroRua")]
        public int? NumeroRua { get; set; }

        [Column("Complemento")]
        [Display(Name = "Complemento")]
        public string? Complemento { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public string? Estado { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Column("Departamento")]
        [Display(Name = "Departamento")]
        public string? Departamento { get; set; }

        [Column("NomeRua")]
        [Display(Name = "NomeRua")]
        public string? NomeRua { get; set; }

        [Column("FK_Login")]
        [Display(Name = "Login")]
        public Login? logins { get; set; }

        [Column("FK_IdLogin")]
        [Display(Name = "Login")]
        public int IdLogin { get; set; }
    }

    
}

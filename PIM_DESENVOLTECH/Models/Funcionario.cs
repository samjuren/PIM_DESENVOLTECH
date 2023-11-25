using Microsoft.EntityFrameworkCore;
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
        [Required(ErrorMessage = "O campo Nome Cargo é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo Nome Cargo deve ter no máximo 50 caracteres.")]
        public string? NomeCargo { get; set; }

        [Column("Salario")]
        [Display(Name = "Salario")]
        [Required(ErrorMessage = "O campo Salário é obrigatório.")]
        public double Salario { get; set; }

        [Column("DataAdmissao")]
        [Display(Name = "Data Admissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "O campo Data Admissão é obrigatório.")]
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
        [Range(18, int.MaxValue, ErrorMessage = "A idade deve ser maior ou igual a 18 anos.")]
        public int Idade { get; set; }

        [Column("Nascimento")]
        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "O campo Nascimento é obrigatório.")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Column("RG")]
        [Display(Name = "RG")]
        [Required(ErrorMessage = "O campo RG é obrigatório.")]
        public string? RG { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
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
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
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

        [NotMapped]
        public bool FolhaPagamentoConfirmada { get; set; }

        [NotMapped]
        public DescontosSalariais Descontos { get; set; }

        public int DescontosId { get; set; }


        public void CalcularDesconto()
        {
            Descontos.ValeTransporte = Salario * 0.06; ;// breno que me passou esses dados fixo 
            Descontos.INSS = Salario * 0.08;
            Descontos.ImpostoDeRenda = Salario * 0.15;

            Salario -= (Descontos.ValeTransporte + Descontos.INSS + Descontos.ImpostoDeRenda);
        }

    }


   
}
    


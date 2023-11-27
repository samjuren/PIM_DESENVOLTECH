using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIM_DESENVOLTECH.Models
{
    public class DescontosSalariais
    {
        [Column("IdDesconto")]
        [Display(Name = "Código Desconto")]
        [Key]
        public int IdDesconto { get; set; }

        [Column("FK_Funcionario")]
        [Display(Name = "FK Funcionario")]
        public Funcionario? Funcionario { get; set; }

        [Column("FK_IdFuncionario")]
        [Display(Name = "Código Funcionario")]
        [ForeignKey("Funcionario")]
        public int IdFuncionario { get; set; }
        
        
       

        [Column("ValeTransporte")]
        [Display(Name = "Vale Transporte")]
        public double ValeTransporte { get; set; }

        [Column("INSS")]
        [Display(Name = "INSS")]
        public double INSS { get; set; }

        [Column("ImpostoDeRenda")]
        [Display(Name = "ImpostoDeRenda")] 
        public double ImpostoDeRenda { get; set; }

        

    }
}

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

        [Column("ValeTransporte")]
        [Display(Name = "Vale Transporte")]
        public double ValeTransporte { get; set; }

        [Column("INSS")]
        [Display(Name = "INSS")]
        public double INSS { get; set; }

        [Column("ImpostoDeRenda")]
        [Display(Name = "ImpostoDeRenda")]
        public double ImpostoDeRenda { get; set; }

        [Column("FuncionarioId")]
        [Display(Name = "Código Funcionario")]
        public int FuncionarioId { get; set; }

        
        [ForeignKey("FuncionarioId")]
        public Funcionario Funcionario { get; set; }
    }

}

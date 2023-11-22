using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIM_DESENVOLTECH.Models
{
    public class RelacaoFerias
    {
        [Column("IdFerias")]
        [Display(Name = "Código Férias")]
        [Key]
        public int IdFerias { get; set; }

        [Column("FeriasInicio")]
        [Display(Name = "FeriasInicio")]
        public DateTime FeriasInicio { get; set; }

        [Column("FeriasFim")]
        [Display(Name = "FeriasFim")]
        public DateTime FeriasFim { get; set; }

        [Column("FK_Funcionario")]
        [Display(Name = "Funcionario")]
        public Funcionario? Funcionario { get; set; }

        [Column("FK_IdFuncionario")]
        [Display(Name = "Código do Funcionario")]
        public int IdFuncionario { get; set; }

    }
}

using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIM_DESENVOLTECH.Models
{
    public class FolhaPonto
    {
        [Column("IdFolhaPonto")]
        [Display(Name = "Código Folha de Ponto")]
        [Key]
        public int IdFolhaPonto { get; set; }

        [Column("HoraPonto")]
        [Display(Name = "Hora Ponto")]
        public DateTime HoraPonto { get; set; }

        [Column("IdFuncionario")]
        [Display(Name = "Código Funcionario")]
        public int IdFuncionario { get; set; }

        [Column("FK_Funcionario")]
        [Display(Name = "PK_FK_Funcionario")]
        public Funcionario? Funcionario { get; set; }

        [Column("FK_IdFuncionario")]
        [Display(Name = "FK_Funcionario")]
        public int FK_Funcionario { get; set; }
    }
}

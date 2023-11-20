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
    }
}

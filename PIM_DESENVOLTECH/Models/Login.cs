using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIM_DESENVOLTECH.Models
{
    [Table("Login")]
    public class Login
    {
        [Column("Id")]
        [Display(Name = "Código")]
        [Key]
        public int Id { get; set; }


        [Column("NomeLogin")]
        [Display(Name = "Usuario")]
        public string? NomeLogin { get; set; }


        [Column("SenhaLogin")]
        [Display(Name = "Senha")]
        public string? SenhaLogin { get; set; }

        [Column("IsAdm")]
        [Display(Name = "IsAdm")]
        public bool IsAdm { get; set; }
    }
}
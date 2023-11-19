using Microsoft.Identity.Client;

namespace PIM_DESENVOLTECH.Models
{
    public class FolhaPonto
    {
        public int IdFolhaPonto { get; set; }
        public DateTime HoraPonto { get; set; }
        public Funcionario Funcionario{ get; set; }
    }
}

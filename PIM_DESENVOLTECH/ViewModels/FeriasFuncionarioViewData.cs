using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.ViewModels
{
    public class FeriasFuncionarioViewData
    {
        public RelacaoFerias relacaoFerias { get; set; }
        public IQueryable<RelacaoFerias> feriasList { get; set; }
        public IQueryable<Funcionario> funcionarioList { get; set; }
        public Funcionario funcionario { get; set; }
    }
}

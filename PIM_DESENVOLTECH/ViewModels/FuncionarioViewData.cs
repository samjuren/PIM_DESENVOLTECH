using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.ViewModels
{
    public class FuncionarioViewData
    {
        public FolhaPonto folhaPonto { get; set; }    
        public IQueryable<FolhaPonto> folhaPontoList { get; set; }    


    }
}

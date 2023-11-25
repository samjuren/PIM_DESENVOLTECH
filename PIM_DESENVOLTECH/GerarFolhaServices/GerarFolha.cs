using Microsoft.EntityFrameworkCore;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.GerarFolhaServices
{
    public class GerarFolha
    {


        private readonly Contexto _context;

        public GerarFolha(Contexto context) 
        {
        
         _context = context;
        
        }


        public void CalcularFolha() 
        {
            var funcionarios = _context.Funcionario.ToList();

            foreach (var funcionario in funcionarios)
            {
                _context.Entry(funcionario)
                    .Reference(f => f.Descontos)
                    .Load();

                funcionario.CalcularDesconto();
                funcionario.FolhaPagamentoConfirmada = true;
            }

            _context.SaveChanges();

        }

    }
}

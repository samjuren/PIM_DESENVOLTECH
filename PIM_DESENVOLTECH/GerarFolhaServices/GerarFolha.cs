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
            var funcionarios = _context.Funcionario.Include
                (f => f.Descontos).ToList();

            foreach(var funcionario in funcionarios) 
            { 
            funcionario.CalcularDesconto();
             funcionario.FolhaPagamentoConfirmada = true;
            }


            _context.SaveChanges();

        }

    }
}

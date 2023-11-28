using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM_DESENVOLTECH.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace PIM_DESENVOLTECH.Controllers
{
    public class EditarFuncionarioController : Controller
    {
        private readonly Contexto _contexto;

        public EditarFuncionarioController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var funcionarios = _contexto.Funcionario.ToList();
            return View(funcionarios);
        }

        public IActionResult EditarFunc(int id)
        {
            var funcionario = _contexto.Funcionario
                .AsNoTracking()
                .FirstOrDefault(f => f.IdFuncionario == id);

            if (funcionario == null)
            {
                return NotFound(); // 
            }

            return View("EditFunc", funcionario);
        }

        [HttpPost]
        public IActionResult SalvarEdicao(Funcionario funcionario)
        {
            try
            {
               
                var funcionarioExistente = _contexto.Funcionario
                    .AsNoTracking()
                    .FirstOrDefault(f => f.IdFuncionario == funcionario.IdFuncionario);

                if (funcionarioExistente == null)
                {
                    return NotFound(); 
                }

                
                funcionarioExistente.Salario = funcionario.Salario;
                funcionarioExistente.NomeCompleto = funcionario.NomeCompleto;
                funcionarioExistente.CPF = funcionario.CPF;
                funcionarioExistente.RG = funcionario.RG;
                funcionarioExistente.Email = funcionario.Email;
                funcionarioExistente.Departamento = funcionario.Departamento;
                funcionarioExistente.NomeCargo = funcionario.NomeCargo;

                _contexto.Funcionario.Update(funcionarioExistente);
                _contexto.SaveChanges();

                Debug.WriteLine("Alterações salvas com sucesso!");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao salvar alterações: {ex.Message}");
                throw;
            }
        }

        public IActionResult CadastrarFuncionarioLateral()
        {
            return RedirectToAction("Index", "CadastrarFuncionario");
        }
        public IActionResult FolhaPontoLateral()
        {
            return RedirectToAction("Index", "FolhaPonto");
        }

        public IActionResult FeriasLateral()
        {
            return RedirectToAction("Index", "Ferias");
        }
        public IActionResult CalculoPagamento()
        {
            return RedirectToAction("Index", "CalculoFolha");
        }

        public IActionResult SairSistema()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}

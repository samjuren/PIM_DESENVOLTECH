using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.WebEncoders.Testing;
using PIM_DESENVOLTECH.Auxiliar;
using PIM_DESENVOLTECH.Models;
using PIM_DESENVOLTECH.ViewModels;
using System.Collections.Generic;

namespace PIM_DESENVOLTECH.Controllers
{
    public class FeriasController : Controller
    {
        private readonly Contexto _context;
        private readonly Isessao _sessao;

        public FeriasController(Contexto context, Isessao sessao)
        {
            _context = context;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerFeriasGerais()
        {    
            var list = _context.RelacaoFerias.ToList().AsQueryable();
            var func = _context.Funcionario.ToList().AsQueryable();

            FeriasFuncionarioViewData ff = new FeriasFuncionarioViewData();

            ff.feriasList = list;
            ff.funcionarioList = func;

            return View(ff);
        }

        public IActionResult BuscarFeriasFuncionario(string Nome)
        {
            var list = _context.RelacaoFerias.Where(x => x.Funcionario.NomeCompleto == Nome);

            FeriasFuncionarioViewData ff = new FeriasFuncionarioViewData();

            ff.feriasList = list;

            return View(VerFeriasGerais());
        }

        public IActionResult SolicitarFerias(DateTime DataInicio, DateTime DataFim)
        {
            Login funcionario = _sessao.BuscarSessaoDoUsuario();

            if (funcionario == null)
            {
                TempData["MensagemErro"] = "Usuário não autenticado. Faça o login novamente.";
                return RedirectToAction("Index", "Login");
            }
            else
            {
                int duracaoFerias = (int)(DataFim - DataInicio).TotalDays;

                if (duracaoFerias >= 5 && duracaoFerias <= 30)
                {
                    TempData["MensagemSucesso"] = "Sua solicitação foi aprovada.";

                    return RedirectToAction("Index", "Ferias");
                }
                else
                {
                    TempData["MensagemErro"] = "A duração das férias deve ser entre 5 e 30 dias.";
                }
            }
            return RedirectToAction("Index", "Ferias");
        }

        public IActionResult CadastrarFerias(DateTime DataInicio, DateTime DataFim)
        {
            Login login = _sessao.BuscarSessaoDoUsuario();

            Funcionario funcionario = _context.Funcionario.FirstOrDefault(x => x.IdLogin == login.Id);

            _context.RelacaoFerias.Add(new RelacaoFerias 
            {
                FeriasInicio = DataInicio,
                FeriasFim = DataFim,
                IdFuncionario = login.Id,
                Funcionario = funcionario
            });

            _context.SaveChanges(); 

            return RedirectToAction("Index", "Ferias");
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
        public IActionResult EditarFuncionario()
        {
            return RedirectToAction("Index", "EditarFuncionario");
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

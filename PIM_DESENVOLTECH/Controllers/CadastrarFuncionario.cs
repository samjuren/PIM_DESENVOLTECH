using Microsoft.AspNetCore.Mvc;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Controllers
{
    public class CadastrarFuncionario : Controller
    {
        private readonly Contexto _context;

        public CadastrarFuncionario(Contexto context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarFuncionarioBanco(
                                                        string NomeCompleto, 
                                                        string CPF, 
                                                        string RG, 
                                                        string Email, 
                                                        DateTime Nascimento, 
                                                        int Idade, 
                                                        string NomeCargo, 
                                                        string Departamento, 
                                                        string Salario, 
                                                        DateTime DataAdmissao, 
                                                        string NomeRua,
                                                        int NumeroRua,
                                                        string Complemento, 
                                                        string Estado, 
                                                        string Cidade,
                                                        string CEP,
                                                        string NomeLogin,
                                                        string SenhaLogin,
                                                        bool IsADM

        )
        {

            if (ModelState.IsValid)
            {
                _context.Funcionario.Add(new Funcionario
                {
                    CEP = CEP,
                    Cidade = Cidade,
                    Complemento = Complemento,
                    CPF = CPF,
                    DataAdmissao = DataAdmissao,
                    Departamento = Departamento,
                    Email = Email,
                    Estado = Estado,
                    DataDemissao = DateTime.Now,
                    FuncionarioAtivo = true,
                    Idade = Idade,
                    NomeCargo = NomeCargo,
                    NomeCompleto = NomeCompleto,
                    Nascimento = Nascimento,
                    RG = RG,
                    Salario = Salario,
                    NumeroRua = NumeroRua,
                    NomeRua = NomeRua,
                });

                _context.Login.Add(new Login { 
                    NomeLogin = NomeLogin,
                    SenhaLogin = SenhaLogin,
                    IsAdm = IsADM
                });

                _context.SaveChanges();

                return RedirectToAction("Index", "CadastrarFuncionario");
            }
            
            return View();
        }
        public IActionResult CadastrarFuncionarioLateral()
        {
            return RedirectToAction("Index", "CadastrarFuncionario");
        }
        public IActionResult ApontamentoHoras()
        {
            return RedirectToAction("Index", "ApontamentoHoras");
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

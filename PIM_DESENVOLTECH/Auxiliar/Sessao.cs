
using Newtonsoft.Json;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Auxiliar
{
    public class Sessao : Isessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public Funcionario BuscarSessaoDoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;

            return JsonConvert.DeserializeObject<Funcionario>(sessaoUsuario);
        }
        /// estou usando 
        public void CriarSessaoDoUsuario(Funcionario funcionario)
        {
            string valor = JsonConvert.SerializeObject(funcionario);
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        // não estou usando

        public void RemoverSessaoDoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }

        public void CriarSessaoDoUsuarioNome(string nome)
        {
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioNome", nome);
        }
    }
}


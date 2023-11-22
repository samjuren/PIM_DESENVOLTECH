
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

        public Login BuscarSessaoDoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;

            return JsonConvert.DeserializeObject<Login>(sessaoUsuario);
        }
        /// estou usando 
        public void CriarSessaoDoUsuario(Login login)
        {
            string valor = JsonConvert.SerializeObject(login);
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

        public void ChecarAdm(int id)
        {
            
        }
    }
}


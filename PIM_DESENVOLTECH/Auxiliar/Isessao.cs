using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Auxiliar
{
    public interface Isessao
    {
        void CriarSessaoDoUsuario(Login login);
        void RemoverSessaoDoUsuario();
        Login BuscarSessaoDoUsuario();
        void CriarSessaoDoUsuarioNome(string nome);
        void ChecarAdm(int id);

    }
}

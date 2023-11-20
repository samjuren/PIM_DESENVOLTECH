using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Auxiliar
{
    public interface Isessao
    {
        void CriarSessaoDoUsuario(Funcionario funcionario);
        void RemoverSessaoDoUsuario();
        Funcionario BuscarSessaoDoUsuario();
        void CriarSessaoDoUsuarioNome(string nome);

    }
}

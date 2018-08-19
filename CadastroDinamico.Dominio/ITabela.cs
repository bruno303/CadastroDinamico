using System.Collections.Generic;
using System.Data;

namespace CadastroDinamico.Dominio
{
    public interface ITabela
    {
        string Carregar();
        DataTable RetornarAmostraDados(List<string> camposNaoExibir);
        string RetornarSelect(bool amostra = false);
        object[] RetornarDadosFK(string coluna);
        bool RetornarDadoChavePrimaria(string coluna);
    }
}

namespace CadastroDinamico.Dominio
{
    public interface IConfigurador
    {
        Configuracao RetornarConfiguracao();
        string AlterarConfiguracao(Configuracao configuracao);
    }
}

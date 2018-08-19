namespace CadastroDinamico.Dominio
{
    public sealed class Configuracao
    {
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool RegistrarLog { get; set; }
    }
}

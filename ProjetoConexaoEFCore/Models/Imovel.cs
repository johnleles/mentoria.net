namespace ProjetoConexaoEFCore.Models
{
    public class Imovel
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public decimal Valor { get; set; }

    }
}

/*
    Exemplos com Upcast e Downcast.

    Podemos realizar a conversão de objetos quando temos vinculos via herança

    Upcasting | Converte um objeto de um tipo
    especializado (classe filha) para um tipo mais geral (classe base).

    Downcasting | Converte um objeto de um tipo
    geral (classe base) para um tipo mais especializado (classe filha).
*/

namespace Payments
{
    //Classe base
    public class Pessoa
    {
        public string? Nome { get; set; }
    }

    //Classe filha
    public class PessoaFisica : Pessoa
    {
        public string? CPF { get; set; }
    }

    //Classe filha
    class PessoaJuridica : Pessoa
    {
        public string? CNPJ { get; set; }
    }
}

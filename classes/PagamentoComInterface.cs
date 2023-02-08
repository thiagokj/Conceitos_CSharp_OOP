/*
    Aqui vamos implementar uma interface na classe base.
    A partir da classe base, implementamos as demais classes via herança.

    Como melhores práticas, usamos o abstract na classe genérica e
    definimos uma implementação base.

    Dessa forma, limitamos que a classe não será instanciada,
    sendo necessário criar uma classe para tratar cada regra de negócio
    específica do processo.
*/

namespace Payments
{
    // A classe mais genérica Pagamento não trata uma regra específica.
    // Devemos limita-lá, usando a palavra chave abstract.
    public abstract class PagamentoComInterface : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {
            Console.WriteLine("Pagamento realizado");
        }
    }
    public class PagamentoComCartao : PagamentoComInterface
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
    public class PagamentoComBoleto : PagamentoComInterface
    {
        public override void Pagar(double valor)
        {
            base.Pagar(valor);
        }
    }
    public class PagamentoComPix : PagamentoComInterface
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento realizado com Pix: R${valor}");
        }
    }
}
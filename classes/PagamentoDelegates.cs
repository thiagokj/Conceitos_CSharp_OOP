/*
    Delegates | Também é chamado de método anonimo.

    Adicionando o delegate, o metódo aponta para uma outra função.
    Essa função pode estar em qualquer outra classe.

    Exemplo:

    var pagar = new PagamentoDelegates.Pagar(RealizaPagamento);
    pagar(25);
        
    // Função delegada que será chamada    
    public static void RealizaPagamento(double valor)
    {
        Console.WriteLine($"Valor pago: {valor}");
    }
*/

namespace Payments
{
    class PagamentoDelegates
    {
        //O metódo precisa ter a mesma assinatura do qual fará a referência
        public delegate void Pagar(double valor);
    }
}


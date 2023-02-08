namespace Payments
{
    // 3. Herança | Facilita o reaproveitamento de código,
    // extendendo as funcionalidades de uma classe para outra.
    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto = "";

        // 4. Polimorfismo | Permite alteração e sobrescrita do método por outra classe
        // que estiver implementando.
        public override void Pagar()
        {
            Console.WriteLine("Valor do boleto pago: R$ 26,11");
        }
    }
}
namespace Payments
{
    class PagamentoCartaoDeDebito : Pagamento
    {
        //Construtor herdando parametros da classe pai
        public PagamentoCartaoDeDebito(DateTime vencimento) : base(vencimento)
        {
            Console.WriteLine($"Iniciando pagamento no débito com vencimento em: {vencimento}");
        }

        public string NumeroDoCartao = "";

        public override void Pagar()
        {
            // a palavra reservada base chama o método pai.
            base.Pagar();
            Console.WriteLine("Valor cobrado no Cartão de Débito: R$ 100,23");
        }
    }

}
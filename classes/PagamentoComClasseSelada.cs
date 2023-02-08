/*
    Aqui usamos o modificador sealed,
    inibindo a criação de uma classe que faça herança.
    Assim garantimos que uma classe só tenha uma forma,
    não gerando versões.

    Um bom exeplo seria o uso do sealed em uma classe Notificacao,
    onde é forçado o uso apenas de um tipo final de notificações
    para um sistema.
*/

namespace OutroNameSpace
{

    public sealed class Pagamento
    {
        public DateTime dataVencimento { get; set; }
    }

    // a declaração public class PagamentoSelado : Pagamento
    // gera erro, não permitindo derivar de Pagamento.
    public class PagamentoSemHeranca
    {
        public int Propriedade2 { get; set; }
    }

}





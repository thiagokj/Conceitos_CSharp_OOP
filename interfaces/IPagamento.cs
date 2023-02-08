/*
    As interfaces são como contratos.
    Aqui definimos os termos que deverão ser implementados por uma classe.
    Não informamos modificadores de acesso nas interfaces.

    Por boas praticas, sempre adicionamos o "I" maiúsculo
    a frente do nome da interface.

    Ao desenvolver, pense sempre primeiro na interface:
    "O que eu devo fazer?" Essas serão as definições.
    A parte do "Como devo fazer?", deve ser especificada em uma classe específica.
*/

namespace Payments
{
    interface IPagamento
    {
        public DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }
}
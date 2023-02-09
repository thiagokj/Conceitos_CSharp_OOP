/*
    Eventos | Para disparar e gerenciar eventos,
    declaramos uma instrução com a palavra event seguido por um tipo EventHandler.

    Utilizamos o conceito do delegate para trabalhar com os eventos:

    1. Declaração do evento
    public event EventHandler EventoSalaEsgotada;

    2. Implementação base do Manipulador de evento
     protected virtual void AoFicarEsgotada(EventArgs e)
    {
        EventHandler handler = EventoSalaEsgotada;

        3. Gerenciamento de chamadas do evento
        handler?.Invoke(this, e);
    }

    4. Método com disparo de eventos
    static void AoEsgotar(object sender, EventArgs e)
    {
        Console.WriteLine("Sala lotada");
    }

*/

namespace Payments
{
    class Sala
    {
        private int assentosEmUso = 0;
        public int Assentos { get; set; }
        public Sala(int assentos)
        {
            Assentos = assentos;
        }

        public void ReservaAssento()
        {
            assentosEmUso++;
            if (assentosEmUso >= Assentos)
            {
                AoFicarEsgotada(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado");
            }
        }

        // Declaração do evento
        public event EventHandler EventoSalaEsgotada;

        // Implementação base do Manipulador de evento
        protected virtual void AoFicarEsgotada(EventArgs e)
        {
            EventHandler handler = EventoSalaEsgotada;

            // Faz a chamada do evento
            handler?.Invoke(this, e);
        }
    }
}
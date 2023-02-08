// É necessario liberar recursos como conexões com banco de dados,
// objetos pesados em memória, acesso e escrita em arquivos, etc.
// A melhor prática é utilizar a interface Dispose e a declaração using.
// Dessa forma é garantido que os recursos são liberados após o uso.

class PagamentoComDispose : IDisposable
{
    public PagamentoComDispose()
    {
        Console.WriteLine("Iniciando pagamento...");
    }
    public void Dispose()
    {
        Console.WriteLine("Pagamento finalizado.");
    }
}
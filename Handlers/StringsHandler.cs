using System.Text;

namespace Conceitos_CSharp_OOP.Handlers;

public static class StringsHandler
{
    public static void ManipulandoStrings()
    {
        Console.Clear();
        //Cria um Identificador Global único
        var id = Guid.NewGuid().ToString();
        Console.WriteLine($"Guid:{id}");
        Console.WriteLine("");
        Console.WriteLine($"Guid com caracteres em maiúsculo: {id.ToUpper()}");
        Console.WriteLine($"Guid com caracteres em minúsculo: {id.ToLower()}");
        Console.WriteLine($"Retorna os 4 primeiros caracteres: {id.Substring(0, 4)}");
        Console.WriteLine($"Retorna os 4 últimos caracteres: {id.Substring(id.Length - 4, 4)}");
        Console.WriteLine("");

        var frase = "Lugar ao Sol";
        Console.WriteLine($"Frase: {frase}");
        Console.WriteLine("");
        Console.WriteLine($"Retorna a posição da letra 'a' na frase, començando a contagem em zero: {frase.IndexOf('a')}");

        Console.WriteLine($@"Retorna a posição na ultima vez que a letra 'a' é encontrada na frase,
            començando a contagem em zero: {frase.LastIndexOf('a')}"
            .Replace(Environment.NewLine, string.Empty));

        var fraseLonga = $@"Verifica se o texto inicia com 'Lugar', 
            desconsiderando maiúsculo ou minúsculo: 
            {frase.StartsWith("lugar", StringComparison.OrdinalIgnoreCase)}"
            .Replace(Environment.NewLine, string.Empty);

        Console.WriteLine(fraseLonga);
        Console.WriteLine($"Verifica se o texto termina exatamente com 'Lugar': {frase.EndsWith("as")}");
        Console.WriteLine($"Compara a frase usando o método Equals: {frase.Equals("Lugar ao Sol")}"); //True
        Console.WriteLine($"Mesma comparação com Equals, porém com maiúsculas: {frase.Equals("lugAR AO Sol")}"); //False

        fraseLonga = $@"Mesma comparação com Equals, 
            desconsiderando maiúsculo ou minúsculo: 
            {frase.Equals("lugAR AO Sol", StringComparison.OrdinalIgnoreCase)}"
            .Replace(Environment.NewLine, string.Empty); //True

        Console.WriteLine(fraseLonga);

        Console.WriteLine($@"Altera a frase, inserindo texto a partir 
            da posição informada: {frase.Insert(6, "TEXTO INSERIDO ")}"
            .Replace(Environment.NewLine, string.Empty));

        Console.WriteLine($@"Altera a frase, removendo texto a partir 
            da posição informada: {frase.Remove(6, 0)}"
            .Replace(Environment.NewLine, string.Empty));

        Console.WriteLine("");

        frase = "Tão natural quanto a luz do dia";
        Console.WriteLine($"Frase:{frase}");

        Console.WriteLine("Quebrando texto em espaços utilizando split, gerando uma lista de string.");
        Console.WriteLine("");

        var textoComDivisao = frase.Split(" ");
        for (int i = 0; i < textoComDivisao.Length; i++)
        {
            Console.WriteLine(textoComDivisao[i]);
        }

        Console.WriteLine("");

        Console.WriteLine("Utilizando o objeto StringBuilder para textos muito grandes e dinâmicos.");
        Console.WriteLine(@"O Console.WriteLine converte o objeto para string.
            Caso necessario converter para outro tipo de uso, utilizar o método ToString().");

        var textoComStringBuilder = new StringBuilder();
        textoComStringBuilder.Append("Nossas vidas, ");
        textoComStringBuilder.Append("nossos sonhos, ");
        textoComStringBuilder.Append("tem o mesmo valor. ");
        textoComStringBuilder.Append("Eu vou com você pra onde você for.");

        Console.WriteLine("");
        Console.WriteLine($"Texto: {textoComStringBuilder}");
    }
}



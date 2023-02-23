using System.Globalization;

namespace Conceitos_CSharp_OOP.Handlers;

public static class CurrenciesHandler
{
    public static void ManipulandoMoedas()
    {
        Console.Clear();
        Console.WriteLine("----------------------------");
        Console.WriteLine("Manipulando Moedas");
        Console.WriteLine("A recomendação para se trabalhar com moeda é o decimal, por sua precisão.");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        var valor = 198451.90m;

        Console.WriteLine($"Valor em decimal: {valor}");
        Console.WriteLine($"Valor numérico no Brasil: {ExibeValorConformeCultura(valor, "G", "pt-BR")}");

        Console.WriteLine($@"Valor da moeda corrente no Brasil (Real): 
            {ExibeValorConformeCultura(valor, "C", "pt-BR")}".Replace(Environment.NewLine, ""));

        Console.WriteLine($@"Valor da moeda corrente nos Estados Unidos (Dolar): 
            {ExibeValorConformeCultura(valor, "C", "en-US")}".Replace(Environment.NewLine, ""));

        Console.WriteLine($@"Valor da moeda corrente no Reino Unido (Libra): 
            {ExibeValorConformeCultura(valor, "C", "en-GB")}".Replace(Environment.NewLine, ""));

        Console.WriteLine($@"Valor da moeda corrente na Dinamarca (Coroa Dinamarquesa): 
            {ExibeValorConformeCultura(valor, "C", "da-DK")}".Replace(Environment.NewLine, ""));
        Console.WriteLine("");

        Console.WriteLine("----------------------------");
        Console.WriteLine("Arrendondando valores");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        valor = (decimal)343.425646461;
        Console.WriteLine($"Valor em decimal: {valor}");
        Console.WriteLine($"Arredonda para o número mais próximo com Math.Round: {Math.Round(valor, 2)}");
        Console.WriteLine($"Arredonda pra cima com Math.Ceiling: {Math.Ceiling(valor)}");
        Console.WriteLine($"Arredonda pra baixo com Math.Floor: {Math.Floor(valor)}");

    }

    static string ExibeValorConformeCultura(decimal valor, string formatador, string culturaLocal)
    {
        var cultureInfo = CultureInfo.CreateSpecificCulture(culturaLocal);
        var valorFormatado = valor.ToString(formatador, cultureInfo);

        return $"{valorFormatado}";
    }

}








namespace Conceitos_CSharp_OOP.Handlers;

public static class ArraysHandler
{
    public static void ManipulandoArrays()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Manipulando Arrays");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        var arrayDeInteiros = new int[5] { 1, 2, 3, 4, 5 };
        arrayDeInteiros[0] = 100;

        Console.WriteLine($"var arrayGenerico = new int[5] | Tamanho do array: {arrayDeInteiros.Length}");
        Console.WriteLine($"Percorrendo posições do array com o for:");
        Console.WriteLine("");

        for (int indice = 0; indice < arrayDeInteiros.Length; indice++)
        {
            Console.WriteLine($"Posição do array[{indice}] | Valor: {arrayDeInteiros[indice]}");
        }

        Console.WriteLine("");
        Console.WriteLine($"Percorrendo posições do array com o forEach:");
        Console.WriteLine("");

        foreach (var item in arrayDeInteiros)
        {
            Console.WriteLine($"Valor de cada posição: {item}");
        }
        Console.WriteLine("");

        Console.WriteLine("----------------------------");
        Console.WriteLine("Criando array do tipo struct");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        var funcionarios = new Funcionario[5];
        funcionarios[0] = new Funcionario() { Id = 747, Nome = "João Ronaldo" };

        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"Id do Funcionario: {funcionario.Id} | Nome: {funcionario.Nome}");
        }

        Console.WriteLine("");

        Console.WriteLine("----------------------------");
        Console.WriteLine("Exemplo de cópia de valores no array");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        var array1 = new int[3];
        var arrayReferencia = array1;
        array1[0] = 231;

        Console.WriteLine("Passando por referência, caso seja alterado array1, é alterado o arrayReferencia.");
        Console.WriteLine($"Valor array1: {array1[0]}");
        Console.WriteLine($"Valor arrayReferencia: {arrayReferencia[0]}");
        Console.WriteLine("");

        var array2 = new int[3];
        array2[0] = array1[0];
        array1[0] = 777;

        Console.WriteLine("Criando um novo array e passando por cópia, o array2 tem seus valores independentes.");
        Console.WriteLine($"Valor array1: {array1[0]}");
        Console.WriteLine($"Valor arrayReferencia: {arrayReferencia[0]}");
        Console.WriteLine($"Valor array2: {array2[0]}");
        Console.WriteLine("");

        var array3 = (int[])array1.Clone();
        array1[0] = 891;

        Console.WriteLine("Criando array3, utilizando o método clone");
        Console.WriteLine($"Valor array1: {array1[0]}");
        Console.WriteLine($"Valor arrayReferencia: {arrayReferencia[0]}");
        Console.WriteLine($"Valor array2: {array2[0]}");
        Console.WriteLine($"Valor array3: {array3[0]}");
        Console.WriteLine("");
    }
}

public struct Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
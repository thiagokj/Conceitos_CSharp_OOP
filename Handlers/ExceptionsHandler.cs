namespace Conceitos_CSharp_OOP.Handlers;

public static class ExceptionsHandler
{
    public static void ManipulandoExcecoes()
    {
        Console.Clear();

        Console.WriteLine("---------------------------");
        Console.WriteLine("Tratamento de Exceçoes");
        Console.WriteLine("Trate os erros na ordem do mais específico para o mais genérico.");
        Console.WriteLine("---------------------------");
        Console.WriteLine();

        var arr = new int[3] { 1, 2, 3 };
        var i = 0;
        try
        {
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Posição do Array: {arr[i]}");
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine($"O Índice excedeu o limite do array. Posição do Array: {i + 1}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Ocorreu um erro.");
        }

        Console.WriteLine();
        Console.WriteLine("---------------------------");
        Console.WriteLine("Lançando erros com throw");
        Console.WriteLine("---------------------------");

        try
        {
            CadastrarTexto("");
        }
        catch (CustomException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.DataOcorrencia);
            Console.WriteLine($"Falha no momento do cadastro");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Falha ao cadastrar texto");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Ocorreu um erro.");
        }
        finally
        {
            Console.WriteLine("Fim da execução do App.");
        }
    }

    static void CadastrarTexto(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new CustomException(DateTime.Now);
            throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
            throw new Exception("Verifique os campos de texto da aplicação.");
        }
    }

    public class CustomException : Exception
    {
        public DateTime DataOcorrencia { get; set; }
        public CustomException(DateTime dataOcorrencia)
        {
            DataOcorrencia = dataOcorrencia;
        }
    }
}











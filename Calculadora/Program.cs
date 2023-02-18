using System.Data;

static void Calculadora()
{
	Console.WriteLine("");
	Console.WriteLine("");
	Console.WriteLine("=========================================================================");
	Console.WriteLine("Para Utilizar está calculadora, BÁSICA, escreva normalmente o que deseja calcular.");
	Console.WriteLine("Use as expressões na seguinte ordem de prioridade:");
	Console.WriteLine("( ) << priorização de cálculo.");
	Console.WriteLine("* Multiplicação");
	Console.WriteLine("/ Dividisão");
	Console.WriteLine("+ Soma");
	Console.WriteLine("- Subtração");
	Console.WriteLine("Vamos lá. Escreva abaixo o que deseja calcular");
	string letras = Console.ReadLine();
	DataTable dataExpression = new DataTable();
    try
    {
        var numeros = dataExpression.Compute(letras, "");
        Console.WriteLine(numeros);
    }
    catch (Exception e)
    {
		Console.WriteLine("Expressão inválida, tente novamente.");
		Console.WriteLine(e.Message);
    }
	finally
	{
		Console.WriteLine("Se deseja continuar pressione ENTER. Caso contrário pressione qualquer tecla.");
		if (Console.ReadKey().Key == ConsoleKey.Enter)
		{
            Calculadora();
        } 
		else
		{
			Console.WriteLine("==Obrigado.==");
		}
    }
}
Calculadora();
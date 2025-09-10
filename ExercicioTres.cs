namespace fundamentosCsharp;

class ExercicioTres
{
	public void Executar()
	{
		Console.Write("Digite um valor (pode ser decimal): ");
		double valor1 = double.Parse(Console.ReadLine());

		Console.Write("Digite outro valor (pode ser decimal): ");
		double valor2 = double.Parse(Console.ReadLine());

		Console.WriteLine($"\nSoma: {valor1 + valor2}");
		Console.WriteLine($"Subtração: {valor1 - valor2}");
		Console.WriteLine($"Multiplicação: {valor1 * valor2}");

		if (valor2 != 0)
		{
			double resultadoDivisao = valor1 / valor2;
			Console.WriteLine($"Divisão: {resultadoDivisao}");
		}
		else
		{
			Console.WriteLine("Divisão: Resultado indefinido");
		}

		double resultadoMedia = (valor1 + valor2) / 2;
		Console.WriteLine($"Média: {resultadoMedia}");

		Console.ReadKey();
	}
}
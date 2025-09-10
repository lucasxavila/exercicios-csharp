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
		Console.WriteLine($"Subtra��o: {valor1 - valor2}");
		Console.WriteLine($"Multiplica��o: {valor1 * valor2}");

		if (valor2 != 0)
		{
			double resultadoDivisao = valor1 / valor2;
			Console.WriteLine($"Divis�o: {resultadoDivisao}");
		}
		else
		{
			Console.WriteLine("Divis�o: Resultado indefinido");
		}

		double resultadoMedia = (valor1 + valor2) / 2;
		Console.WriteLine($"M�dia: {resultadoMedia}");

		Console.ReadKey();
	}
}
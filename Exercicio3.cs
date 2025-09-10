namespace fundamentosCsharp;

class Exercicio3
{
	public void Executar()
	{
        double valor1;
        double valor2;
		bool conversao1;
		bool conversao2;

        do
		{
            Console.Write("Digite um valor (pode ser decimal): ");
            string entrada1 = Console.ReadLine();

            Console.Write("Digite outro valor (pode ser decimal): ");
            string entrada2 = Console.ReadLine();

            conversao1 = double.TryParse(entrada1, out valor1);
            conversao2 = double.TryParse(entrada2, out valor2);

            if (!conversao1 || !conversao2)
            {
                Console.WriteLine("\nEntrada inv�lida! Digite apenas n�meros.\n");
                continue;
            }
        } while (!conversao1 || !conversao2);

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
	}
}
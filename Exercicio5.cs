namespace fundamentosCsharp;

class Exercicio5
{
    public void Executar()
    {
        string placa;
        bool placaValida;

        do
        {
            Console.Write("Digite a placa do veículo: ");
            placa = Console.ReadLine();

            string placaFormatada = placa.Replace(" ", "").Replace("-", "").ToUpper();

            if (placaFormatada.Length != 7)
            {
                Console.WriteLine("A placa deve conter 7 caracteres alfanuméricos. Tente novamente!\n");
                placaValida = false;
                continue;
            }

            bool formatoCorreto = true;

            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placaFormatada[i]))
                {
                    formatoCorreto = false;
                    break;
                }
            }

            if (formatoCorreto)
            {
                for (int i = 3; i < 7; i++)
                {
                    if (!char.IsDigit(placaFormatada[i]))
                    {
                        formatoCorreto = false;
                        break;
                    }
                }
            }

            if (formatoCorreto)
            {
                Console.WriteLine($"A placa '{placaFormatada}' é válida!");
                placaValida = true;
            }
            else
            {
                Console.WriteLine($"O formato da placa é inválido. O padrão é LLLNNNN. Tente novamente!\n");
                placaValida = false;
            }

        } while (!placaValida);
    }
}
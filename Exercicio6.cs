namespace fundamentosCsharp;

class Exercicio6
{
    public void Executar()
    {
        string escolhaFormatoData;
        string formatoSelecionado = "";
        bool escolhaValida = false;
        DateTime dataAtual = DateTime.Now;

        do
        {
            Console.WriteLine("Escolha um formato de data: \n");
            Console.WriteLine("1 - dddd, dd 'de' MMMM 'de' yyyy hh:mm:ss");
            Console.WriteLine("2 - dd/MM/yyyy");
            Console.WriteLine("3 - HH");
            Console.WriteLine("4 - dd 'de' MMMM 'de' yyyy");

            escolhaFormatoData = Console.ReadLine();

            switch (escolhaFormatoData)
            {
                case "1":
                    formatoSelecionado = "dddd, dd 'de' MMMM 'de' yyyy hh:mm:ss";
                    escolhaValida = true;
                    break;
                case "2":
                    formatoSelecionado = "dd/MM/yyyy";
                    escolhaValida = true;
                    break;
                case "3":
                    formatoSelecionado = "HH 'horas'";
                    escolhaValida = true;
                    break;
                case "4":
                    formatoSelecionado = "dd 'de' MMMM 'de' yyyy";
                    escolhaValida = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha um número de 1 a 4!");
                    break;
            }
        } while (!escolhaValida);

        Console.WriteLine($"\nData formatada: {dataAtual.ToString(formatoSelecionado)}");
    }
}
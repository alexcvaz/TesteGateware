using System;

namespace TesteGateware
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            do
            {
                Console.WriteLine("1) Maior Número Array");
                Console.WriteLine("2) Arquivos texto com telefone");
                Console.WriteLine("3) Criar Pasta");
                Console.WriteLine("0) Sair");

                Console.WriteLine("\nDigite uma das opções");
                valor = Console.ReadLine();
                Console.Clear();
                switch (valor)
                {
                    case "1":
                        var largestNumber = new LargestNumber();
                        largestNumber.Iniciar();
                        break;
                    case "2":
                        var textFiles = new TextFiles();
                        textFiles.Iniciar();

                        break;
                    case "3":
                        var copyImages = new CopyImages();
                        copyImages.Iniciar();
                        break;
                    case "0":
                        Console.WriteLine("Sair");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("\nDigite uma tecla para continuar");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (valor != "0");
        }
    }
}

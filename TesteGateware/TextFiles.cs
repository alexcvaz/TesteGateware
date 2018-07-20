using System;
using System.IO;
using System.Text.RegularExpressions;

namespace TesteGateware
{
    public class TextFiles
    {
        public void Iniciar()
        {
            Console.WriteLine("Para utilizar está função é necessário possuir a pasta Arquivos no disco local C:");
            Console.WriteLine("O formato de telefone procurado é (99)999999999\n");

            DirectoryInfo pasta = new DirectoryInfo(@"C:\Arquivos");
            FileInfo[] arquivos = pasta.GetFiles("*.txt", SearchOption.AllDirectories);
            int counter = 0;
            foreach (FileInfo arq in arquivos)
            {
                if (Regex.Match(System.IO.File.ReadAllText(arq.FullName), @"\(\d\d\)\d\d\d\d\d\d\d\d").Success)
                {
                    Console.WriteLine(arq + "\n");
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Não há arquivos com telefone no formato específico nesta pasta");
            }
            Console.WriteLine("\nDigite uma tecla para continuar");
            Console.ReadKey();
        }
    }
}

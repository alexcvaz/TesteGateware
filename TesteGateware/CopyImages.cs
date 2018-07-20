using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteGateware
{
    public class CopyImages
    {
        public void Iniciar()
        {
            try
            {
                Console.WriteLine("Para utilizar está função é necessário possuir imagens com extexsão .jpeg na pasta Arquivos no disco local C:");
                var pasta = @"C:\Imagens";
                if (!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                DirectoryInfo pastaCopiar = new DirectoryInfo(@"C:\zip");
                FileInfo[] arquivos = pastaCopiar.GetFiles("*.jpg", SearchOption.AllDirectories);
                if (arquivos.Length > 0)
                    Console.WriteLine("\n"+ arquivos.Length+ " imagens foram localizadas na pasta C:\\Arquivos e serão copiadas para C:\\Imagens");
                else
                    Console.WriteLine("\nNão foram localizadas imagens na pasta C:\\Arquivos");

                foreach (var s in arquivos)
                {
                    System.IO.File.Copy(s.FullName, pasta + "\\" + s.Name);
                }
                Console.WriteLine("\nDigite uma tecla para continuar");
                Console.ReadKey();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

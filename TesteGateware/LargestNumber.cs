using System;


namespace TesteGateware
{
    public class LargestNumber
    {
        public void Iniciar()
        {
            try
            {
                string valor;
                int maiorNumero;
                int[] array = new int[5];
                Console.WriteLine("Digite 5 números");
                int index = 1;
                while (index <= 5)
                {
                    Console.WriteLine("Valor " + index);
                    valor = Console.ReadLine();
                    if (Int32.TryParse(valor, out maiorNumero))
                    {
                        array[index - 1] = maiorNumero;
                        index++;
                    }
                    else
                        Console.WriteLine("Digite um valor inteiro");
                }
                maiorNumero = array[0];
                for (index = 0; index < 5; index++)
                {
                    if (array[index] > maiorNumero)
                    {
                        maiorNumero = array[index];
                    }
                }
                Console.WriteLine("\nO maior número é: " + maiorNumero);
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

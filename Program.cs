using System;

namespace set2Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul de elemente din secventa: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine("Secventa este bitonica."); 
                return;
            }

            Console.WriteLine("Introduceti elementele secventei: ");
            int elementAnterior = int.Parse(Console.ReadLine());
            int elementCurent;

            bool crescator = true; 
            bool esteBitonica = true;  

            for (int i = 1; i < n; i++)
            {
                elementCurent = int.Parse(Console.ReadLine());

                if (crescator)
                {
                    if (elementCurent < elementAnterior)
                    {
                       
                        crescator = false;
                    }
                }
                else
                {
                    if (elementCurent > elementAnterior)
                    {
                        
                        esteBitonica = false;
                    }
                }

                elementAnterior = elementCurent;
            }

            if (esteBitonica && !crescator)
            {
                Console.WriteLine("Secventa este bitonica.");
            }
            else
            {
                Console.WriteLine("Secventa NU este bitonica.");
            }
        }
    }
}

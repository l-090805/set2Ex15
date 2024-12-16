namespace set2Ex15
{
    internal class Program
    {
        static bool EsteBitonica(int[] secventa)
        {
            int n = secventa.Length;

            if (n < 3)
            {
                return false;
            }
            int i = 0;

            while (i < n - 1 && secventa[i] <= secventa[i + 1])
            {
                i++;
            }

            if(i == 0 || i == n - 1)
            {
                return false;
            }

            while(i < n - 1 && secventa[i] >= secventa[i + 1])
            {
                i++;
            }

            return i == n - 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introdu o secventa de numere separate prin spatiu: ");
            string input = Console.ReadLine();

            int[] secventa = Array.ConvertAll(input.Split(" "),int.Parse);

            bool rezultat = EsteBitonica(secventa);
            Console.WriteLine($"Secventa este bitonica: {rezultat}");
        }
    }
}

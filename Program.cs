namespace treningElfow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczbPrezentow = 0;
            int.TryParse(Console.ReadLine(), out int n);

            for(int i = 1; i <= n; i++){
                if (n % i == 0)
                    liczbPrezentow += i;
            }

            Console.WriteLine(liczbPrezentow);
        }
    }
}

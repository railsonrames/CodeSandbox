using System.Linq;

namespace CodeSandbox.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente contaCorrente = new ContaCorrente();
            //contaCorrente.Saldo = 1000;
            //System.Console.WriteLine(contaCorrente.CalcularTaxaAdministrativa());

            int[] A = { 1, 3, 6, 4, 1, 2 };
            //int[] A = { -1, -3 };
            //int[] A = { 1, 2, 3 };

            int[] numbers = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray();

            if (!numbers.Any()) System.Console.WriteLine(1);

            int previous = 0;

            foreach (int number in numbers)
            {
                if (number != previous + 1)
                {
                    System.Console.WriteLine(previous + 1);
                }

                previous = number;
            }

            //for (int i = 0; i < numbers.Count(); i++)
            //{
            //    if (numbers[i] != previous + 1)
            //    {
            //        System.Console.WriteLine(previous + 1);
            //    }
            //    previous = numbers[i];
            //}

            System.Console.WriteLine(numbers.Last() + 1);

            System.Console.ReadLine();
        }
    }
}

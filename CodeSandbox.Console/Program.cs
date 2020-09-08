namespace CodeSandbox.Console
{
    class Program
    {
        static int[] arrayInt = new int[5];
        private static int _proximaPosicao = arrayInt.Length;
        static void Main(string[] args)
        {
            arrayInt[0] = 15;
            arrayInt[1] = 45;
            arrayInt[2] = 20;
            arrayInt[3] = 30;
            arrayInt[4] = 10;

            System.Console.WriteLine("Antes da remoção: ");
            foreach (var item in arrayInt)
                System.Console.WriteLine($"Item do array {item}");

            int indice = IdentificarItem(20);
            System.Console.WriteLine($"Indice para remoção identificado: {indice}");

            Remover(indice);

            System.Console.WriteLine("Após a remoção: ");
            foreach (var item in arrayInt)
                System.Console.WriteLine($"Item do array {item}");

            System.Console.ReadLine();
        }

        static int IdentificarItem(int valor)
        {
            int indice = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (arrayInt[i].Equals(valor))
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        static void Remover(int indiceItemRemovido)
        {
            for (int i = indiceItemRemovido; i < _proximaPosicao - 1; i++)
            {
                arrayInt[i] = arrayInt[i + 1];
            }

            _proximaPosicao--;
            arrayInt[_proximaPosicao] = 0;
        }
    }
}

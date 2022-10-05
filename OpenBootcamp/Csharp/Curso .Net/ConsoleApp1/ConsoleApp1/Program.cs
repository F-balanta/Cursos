namespace ConsoleApp1
{
    public class Program
    {
        private static int[] myArray = { 1,3,4,2,7,0 };
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] + myArray[j] == 10)
                    {
                        n1 = myArray[i];
                        n2 = myArray[j];
                    }
                }
            }

            Console.WriteLine($"{n2} {n1}");
            Console.ReadKey();
        }
    }
}


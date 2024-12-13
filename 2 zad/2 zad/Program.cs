using System.Collections;

namespace _2_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList() { 0, 1, 2, 3, 5, 7, 12 };
            int middle = numbers.Count / 2;
            for (int i = 0; i < numbers.Count; i++)
            {
                
                if ((int)numbers[i] != ((int)numbers[i+1] - 1))
                {
                    numbers.Insert(i, numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}

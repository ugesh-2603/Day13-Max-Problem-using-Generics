namespace Day13_Max_Problem_using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to finding the maximum using Generics");
            Console.WriteLine("Maximum of 6, 3, 7:\t" + FindMax(5, 3, 7)); //7
            Console.WriteLine("Maximum of 5, 9, 4:\t" + FindMax(1, 9, 2)); //9
            Console.WriteLine("Maximum of 2, 4, 6:\t" + FindMax(6, 4, 5)); //6
            Console.WriteLine("Maximum of 99, 0, -5:\t" + FindMax(99, 0, -5)); //99
        }

        public static int FindMax(int a, int b, int c)
        {
            int max = a;

            if (b.CompareTo(max) > 0)
            {
                max = b;
            }

            if (c.CompareTo(max) > 0)
            {
                max = c;
            }

            return max;
        }

    }
}
        
    

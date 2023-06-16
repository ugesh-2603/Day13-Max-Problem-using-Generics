namespace Day13_Max_Problem_using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to finding the maximum using Generics");
            Console.WriteLine("Maximum of Apple, Peach, Blueberry:\t" + FindMax("Apple", "Peach", "Banana")); //Peach
            Console.WriteLine("Maximum of Mango, Orange, Banana:\t" + FindMax("Mango", "Orange", "Berry")); //Orange
            Console.WriteLine("Maximum of Pineapple, Guava, Cherry:\t" + FindMax("Pineapple", "Guava", "Cherry")); //Pineapple
            Console.WriteLine("Maximum of Nine, Zero, Five:\t" + FindMax("Nine", "Zero", "Five")); //
        }

        public static string FindMax(string a, string b, string c)
        {
            string max = a;

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



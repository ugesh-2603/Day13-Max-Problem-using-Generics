namespace Day13_Max_Problem_using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to finding the maximum using Generics");
            Console.WriteLine("Maximum of 5, 6, 3:\t" + FindMax(5, 6, 3)); // 6
            Console.WriteLine("Maximum of 1.5, 2.3, -0.9:\t" + FindMax(1.5f, 2.3f, -0.9f)); // 2.3
            Console.WriteLine("Maximum of Apple, Peach, Banana:\t" + FindMax("Apple", "Peach", "Banana")); // Peach
        }

        public static T FindMax<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;


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



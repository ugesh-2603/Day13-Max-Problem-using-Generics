namespace Day13_Max_Problem_using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to finding the maximum using Generics");
            var intMaxTester = new MaximumTester<int>(5, 6, 3);
            Console.WriteLine("Maximum of 5, 6, 3: " + intMaxTester.TestMaximum()); // 6

            var floatMaxTester = new MaximumTester<float>(1.5f, 2.3f, 0.9f);
            Console.WriteLine("Maximum of 1.5, 2.3, 0.9: " + floatMaxTester.TestMaximum()); // 2.3

            var stringMaxTester = new MaximumTester<string>("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum of Apple, Peach, Banana: " + stringMaxTester.TestMaximum()); // Peach
        }

    }

    public class MaximumTester<T> where T : IComparable<T>
    {
        private T a;
        private T b;
        private T c;

        public MaximumTester(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public T TestMaximum()
        {
            return FindMax(a, b, c);
        }

        public static T FindMax(T a, T b, T c)
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



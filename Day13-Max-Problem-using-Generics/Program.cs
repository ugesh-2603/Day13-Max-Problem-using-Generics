namespace Day13_Max_Problem_using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to finding the maximum using Generics");
            var intMaxTester = new MaximumTester<int>(5, 6, 3, 8, 2);
            //Console.WriteLine("Maximum of 5, 6, 3, 8, 2: " + intMaxTester.TestMaximum()); // 8
            intMaxTester.TestMaximum(); // prints "The maximum value is: 8"

            var floatMaxTester = new MaximumTester<float>(1.5f, 2.3f, 0.9f, 3.4f, 0.2f);
            //Console.WriteLine("Maximum of 1.5, 2.3, 0.9, 3.4, 0.2: " + floatMaxTester.TestMaximum()); // 3.4
            floatMaxTester.TestMaximum(); // prints "The maximum value is: 3.4"

            var stringMaxTester = new MaximumTester<string>("Apple", "Peach", "Banana", "Mango", "Orange");
            //Console.WriteLine("Maximum of Apple, Peach, Banana, Mango, Orange: " + stringMaxTester.TestMaximum()); // Peach
            stringMaxTester.TestMaximum(); // prints "The maximum value is: Peach"
        }
    }

    public class MaximumTester<T> where T : IComparable<T>
    {
        private List<T> elements;

        public MaximumTester(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public T TestMaximum()
        {
            T max = FindMax(elements.ToArray());
            PrintMax(max);
            return max;
        }

        public static T FindMax(params T[] elements)
        {
            List<T> sortedElements = elements.ToList();
            sortedElements.Sort();

            return sortedElements.Last();
        }

        private void PrintMax(T max)
        {
            Console.WriteLine("The maximum value is: " + max);
        }
    }
}



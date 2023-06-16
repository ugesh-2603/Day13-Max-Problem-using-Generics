namespace Day13_Max_Problem_using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to finding the maximum using Generics");
            Console.WriteLine("Maximum of 5.5, 3.1, 7.9:\t" + FindMax(5.7f, 3.1f, 7.9f)); //7.9
            Console.WriteLine("Maximum of 1.5, 9.5, 2.7:\t" + FindMax(1.2f, 9.5f, 2.6f)); //9.5
            Console.WriteLine("Maximum of 6.0, 4.6, 5.9:\t" + FindMax(6.0f, 4.3f, 5.8f)); //6.0
            Console.WriteLine("Maximum of 99.9, 0.0, -5.5:\t" + FindMax(99.9f, 0.0f, -5.5f)); //99
        }

        public static float FindMax(float a, float b, float c)
        {
            float max = a;

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

        
    

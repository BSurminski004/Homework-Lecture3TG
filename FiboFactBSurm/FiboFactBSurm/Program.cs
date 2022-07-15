namespace FiboFactBSurm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Range of Fibonacci Numbers: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which Nth element you want to return?");
            int nth = Convert.ToInt32(Console.ReadLine());
            Fibonacci_Iter(l, nth);
            //FiboLINQ(l);

            Console.WriteLine("\nWhat input for factorial: ");
            int f = Convert.ToInt32(Console.ReadLine());
            //Factor(f);
            FactorialLINQ(f);
        }

        public static void Fibonacci_Iter(int len, int n)
        {
            if (len <= 0) Console.WriteLine("0");
            else if (len == 1) Console.WriteLine("0, 1");
            List<uint> Fibonumbs = new List<uint>();
            uint a = 0, b = 1, c = 0;

            Fibonumbs.Add(a);
            Fibonumbs.Add(b);
            Console.Write($"{a} {b}");
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Fibonumbs.Add(c);
                Console.Write($" {c}");
                a = b;
                b = c;
            }
            Console.WriteLine($"\nChoosen element {n}: {Fibonumbs.ElementAt(n - 1)}");
            //return Fibonumbs;  List<uint>
        }

        public static void Factor(int func)
        {
            if (func <= 0) Console.WriteLine("0");
            else if (func == 1) Console.WriteLine("1");

            int[] tabf = new int[func];
            for (int i = 1; i <= func; i++)
            {
                tabf[i - 1] = i;
            }
            int sum = 1;
            for (int i = 1; i < tabf.Length; i++)
            {
                sum *= tabf[i];
            }
            Console.Write("Result:" + func + "!=" + sum);
            //return tabf;  int[]
        }

        //LINQ Attempt

        public static void FiboLINQ(int n)
        {
            IEnumerable<int> fiboTab = Enumerable.Range(0, n).ToList();

            foreach (int i in fiboTab)
            {
                Console.Write(i + " ");

            }
        }

        public static void FactorialLINQ(int f)
        {
            IEnumerable<int> count = Enumerable.Range(1, f);
            int factorial = count.Aggregate((l1, l2) => l1 * l2);
            Console.WriteLine($"Factorial from {f}! = {factorial}");

        }
    }
}

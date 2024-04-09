namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Average(new int[] { 5, 50, 25, 10, 2 }, 5);
            Console.WriteLine(sum);
        }

        public static int Average(int[] ints, int n)
        {
            return ints.Where(x => x <= n).Sum();
        }
    }
}

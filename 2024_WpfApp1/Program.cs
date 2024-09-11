namespace _2024_WpfApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個數值n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();   
        }
    }
}

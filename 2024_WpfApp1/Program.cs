namespace _2024_WpfApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字：");
            string input = Console.ReadLine();
            int n;

            // 嘗試將輸入轉換為整數
            if (int.TryParse(input, out n))
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("輸入的不是有效的數字。");
            }
        }
    }
}

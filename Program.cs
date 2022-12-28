internal class Program
{
    private static void Main(string[] args)
    {
        void Task64()
        {
            int m = 1;
            int n = 9;
            FindDiv(m,n);

        }
        void FindDiv(int m, int n)
        {
            if (m > n) return;
            if(m%3 == 0) Console.Write(m +" ");
            m++;
            FindDiv(m,n);
        }

        void Task66()
        {
            int m = 4;
            int n = 8;
            int sum = 0;
            FindSum(m,n,sum);

        }
        void FindSum(int m, int n, int sum)
        {
            if (m > n)
            {
                Console.Write(sum);
                return; 
            }
            sum += m;
            m++;
            FindSum(m,n,sum);
        }
        void Task68()
        {
            int m = 2;
            int n = 3;
            Console.Write(Ackerman(m,n));

        }
        int Ackerman(int m, int n)
        {
            if(m == 0) return n + 1;
            else if (n == 0) return Ackerman(m - 1, 1);
            else return Ackerman(m-1, Ackerman(m, n-1));
        }

        Console.WriteLine("The answer for the task 64:");
        Task64();
        Console.WriteLine();
        Console.WriteLine("The answer for the task 66:");
        Task66();
        Console.WriteLine();
        Console.WriteLine("The answer for the task 68:");
        Task68();
    }
}
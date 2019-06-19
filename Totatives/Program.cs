using System;

namespace Totatives
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int n = 1; n <= 10; n++)
            
            Console.WriteLine("phi(" + n + ") = " + Phi(n));
            Console.ReadLine();
        }

        static int GetGCD (int a, int b)
        {
            if (a == 0)
                return b;
            return GetGCD(b % a, a);   
        }

        static int Phi(int n)
        {
            int result = 1;
            for (int i = 2; i < n; i++)
                if (GetGCD(i, n) == 1)
                    result++;
            return result;
        }
        
    }
}

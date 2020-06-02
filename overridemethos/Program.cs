using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
           public int Power(int input)
        {
            int result = 0;
            result = input * input;
            return result;
        }

        public int Power(int input,int count)
        {
            int result = 1;
            for(int i = 0; i < count; i++)
            {
                result *= input;
            }
            return result;
        }

        public int SumAll(int end)
        {
            int sum = 0;
            for(int i = 0; i < end; i++)
            {
                sum += i;
            }
            return sum;
        }
        public int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Power(5));
            Console.WriteLine(p.Power(10, 3));
            Console.WriteLine(p.SumAll(5));
            Console.WriteLine(p.SumAll(1, 10));
        }
    }
}

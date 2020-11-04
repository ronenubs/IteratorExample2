using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int number in EvenSequence(5, 18))
            {
                Console.Write(number.ToString() + " ");
            }

            Console.ReadLine();
        }

        public static System.Collections.Generic.IEnumerable<int>
            EvenSequence(int firstNumber, int lastNumber)
        {
            for(int number = firstNumber; number <= lastNumber; number++)
            {
                if(number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}

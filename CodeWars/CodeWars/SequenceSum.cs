using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NUnit.Framework;

//Sum of 'n' Numbers
//sum_of_n(or SequenceSum.sumOfN in Java, SequenceSum.SumOfN in C#) takes an integer n and returns a List (an Array in Java/C#) of length abs(n) + 1. The List/Array contains the numbers in the arithmetic series produced by taking the sum of the consecutive integer numbers from 0 to n inclusive.
//n can also be 0 or a negative value.

namespace CodeWars
{
    public class SequenceSum
    {
        public static int[] SumOfN(int n)
        {
            int m = Math.Abs(n);
            int[] numbers = new int[m + 1];
            int sum = 0;
            int num = 0;

            if (n > 0)
            {
                for (int i = 0; i <= m; i++)
                {
                    sum += i;
                    numbers[i] = sum;
                }
            }
            else
            {
                for (int i = 0; i <= m; i++)
                {
                    sum += i;
                    num = sum - (2 * sum);
                    numbers[i] = num;
                }
            }
            return numbers;
            //throw new System.NotImplementedException();
        }
    }

}


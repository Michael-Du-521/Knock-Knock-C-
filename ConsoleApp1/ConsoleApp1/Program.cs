using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            //Console.WriteLine(Convert.ToString(89, 2));
            //Console.ReadKey();
            //Console.WriteLine(Convert.ToString(25,2));
            //Console.ReadKey();
            //Console.WriteLine(Convert.ToString(1101,10));// unchange
            //Console.ReadKey();
            //Console.WriteLine(Convert.ToInt32("1101",2));// convert successfully
            //Console.ReadKey();
            #endregion

            #region MyRegion
            int a = 7;
            int b = 2;
            int sum, dif, pro, quo;
            sum = a + b;
            dif = a - b;
            pro = a * b;
            quo = a / b;
            Console.WriteLine("{0}+{1}={2}", a, b, sum);
            Console.WriteLine("{0}/{1}={2}", a, b, quo);
            #endregion


            #region MyRegion
            int myAge = 24, myWeight = 65;
            #endregion

            #region MyRegion
            Console.WriteLine(Convert.ToString(25489,2));
            #endregion
        }
    }
}

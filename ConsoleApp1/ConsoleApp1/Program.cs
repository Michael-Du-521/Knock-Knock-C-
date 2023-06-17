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
            string mySentence;
            mySentence = "How do you do?";
            Console.WriteLine(mySentence);
            mySentence = "I am OK!";
            Console.WriteLine(mySentence);
            #endregion

            #region MyRegion
            Console.Write("Bob");
            Console.WriteLine("Kevin");
            Console.Write
                ("Tom");
            #endregion

            //#region MyRegion
            //Console.WriteLine("Please input your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("any key to the next ");
            //Console.ReadKey();
            //Console.WriteLine("Your name is " + name);

            //#endregion

            //#region MyRegion
            //Console.WriteLine("Please input a character");
            //int ch = Console.Read();
            //Console.WriteLine("The ASCII code is " + ch);
            //#endregion

            //#region MyRegion
            //double r , s;
            //Console.Write("r = ");
            //r = Convert.ToDouble(Console.ReadLine());
            //s = 3.14 * r * r;
            //Console.WriteLine("s = " + s);
            //#endregion

            #region
            int code = (int)'A';
            Console.WriteLine("A->{0}",code);
            #endregion

            #region MyRegion
            Console.WriteLine("\u0047\uoo6F\u0064\u0021");
            #endregion
        }
    }
}

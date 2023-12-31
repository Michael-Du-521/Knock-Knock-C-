﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    enum WeekDays:short
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }


    struct Student
    {
        public int number;
        public string name;
        public int sex;

    }

    enum sex :short { 
    Male,Female}


    internal class Program
    {

        static int Fibnacci(int n) {
            if ((n==1)||(n==2) )
            {
                return 1;
            }
            else
            {
                return (Fibnacci(n - 1) + Fibnacci(n - 2));
            }

        }
        static int Fac(int n)
        {
            if (n <= 1) {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
        }

        static double CalculateCircle(double r, out double c)
        {
            c = 2 * Math.PI * r;
            double S = Math.PI * r * r;
            return S;
        }

        static void Swap(ref int x, ref int y) {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }


        static string CalculateWeekDay(int y, int m, int d)
        {
            if (m == 1 || m == 2) {
                m += 12;
                y--;
            }
            string  weekdayString = "";
            int week= ( d +2*m+3*(m+1)/5+y+y/4-y/100+y/400+1)% 7;
            switch (week) {
                case 0:weekdayString = "星期日";break;
                case 1:weekdayString = "星期一";break;
                case 2:weekdayString = "星期二";break;
                case 3: weekdayString = "星期三"; break;
                case 4: weekdayString = "星期四"; break;
                case 5: weekdayString = "星期五"; break;
                case 6: weekdayString = "星期六"; break;
                default: break;
            }
           
            return weekdayString;
        }
        static void Main(string[] args)
        {

            Thread workThread = new Thread(entryPoint);

            #region MyRegion
            Console.WriteLine(Fibnacci(7)); 
            #endregion
            #region MyRegion
            int result = Fac(5);
            Console.WriteLine("5!={0}",result);
            #endregion

            #region MyRegion
            Console.Write("半径: ");
            double radius = 3;
            double circumference;
            double area = CalculateCircle(radius, out circumference);
            Console.WriteLine("周长:{0}",circumference);
            Console.WriteLine("面积：{0}",area);
            #endregion

            #region MyRegion
            int[][] jaggedMatrix = new int[3][];
            jaggedMatrix[0] = new int[2];
            jaggedMatrix[1] = new int[4];
            jaggedMatrix[2] = new int[5];
            foreach (int[] line in jaggedMatrix) {
                foreach (int element in line)
                {
                    Console.Write( element);
                }
                Console.WriteLine( "\n");
            }
            #endregion
            #region MyRegion
            int a = 1;
            int b = 3;
            Swap(ref a, ref b);
            Console.WriteLine( "a ={0},b={1}",a,b);

            #endregion

            #region MyRegion
            string stringWeek = CalculateWeekDay(2023, 6, 24);
            Console.WriteLine(stringWeek);
            #endregion

            #region MyRegion
            string stringWeek1 = CalculateWeekDay(2008, 5, 1);
            Console.WriteLine(stringWeek1);
            #endregion

            #region MyRegion
            int[][] jaggedMatrix1 = new int[3][];
            jaggedMatrix1[0] = new int[2];
            jaggedMatrix1[1] = new int[4];
            jaggedMatrix1[2] = new int[5];
            foreach (int[] line in jaggedMatrix) {
                foreach (int element in line)
                {
                    Console.Write( element);
                }
                Console.WriteLine( "\n");
            }
            #endregion
            #region MyRegion
            //二维数组
            int[,] matrix = { { 0,1,2},{3,4,5 } };

            for (int i = 0; i <2; i++) { 
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("The element in the martix[{0},{1}] is {2}", i + 1, j +1 , matrix[i,j]);
                }
            }


            #endregion
            #region MyRegion
            //string[] friendsName = new string[3];

            //friendsName.Append("刘备");
            //friendsName.Append("关羽");
            //friendsName.Append("张飞");
            string[] friendsName = { "刘备", "关羽", "张飞" };
            Console.WriteLine(  friendsName);
            Console.WriteLine(friendsName.Length);
            #endregion

            #region MyRegion
            foreach (string name in friendsName) {
                //name = 1;
                Console.WriteLine(name);
            }
            #endregion

            Student mrd;
            mrd.number = 100;
            mrd.name = "miguel";
            mrd.sex = (int)sex.Male;

            int number = 10000;

            int[] scores = { 100, 49, 39, 80, 65, 96 };
            string[] names = { "张三", "历史", "黄飞鸿", "李小龙", "左足", "秦始皇" };
            int sumOfScores = scores[0] + scores[1] + scores[2] + scores[3] + scores[4] + scores[5];
            int sum = 0;
            for (int i = 0; i < scores.Length; i++) {
                sum += scores[i];
            }
            Console.WriteLine( sum);
            Console.WriteLine(sumOfScores);
            Console.WriteLine("学生的学号是{0}", mrd.number );
            #region MyRegion
            WeekDays today = (WeekDays)3;
            Console.WriteLine(  "Today is " +today);
            #endregion
            //            #region 
            //            //Console.WriteLine(Convert.ToString(89, 2));
            //            //Console.ReadKey();
            //            //Console.WriteLine(Convert.ToString(25,2));
            //            //Console.ReadKey();
            //            //Console.WriteLine(Convert.ToString(1101,10));// unchange
            //            //Console.ReadKey();
            //            //Console.WriteLine(Convert.ToInt32("1101",2));// convert successfully
            //            //Console.ReadKey();
            //            #endregion

            //            #region MyRegion
            //            int a = 7;
            //            int b = 2;
            //            int sum, dif, pro, quo;
            //            sum = a + b;
            //            dif = a - b;
            //            pro = a * b;
            //            quo = a / b;
            //            Console.WriteLine("{0}+{1}={2}", a, b, sum);
            //            Console.WriteLine("{0}/{1}={2}", a, b, quo);
            //            #endregion


            //            #region MyRegion
            //            int myAge = 24, myWeight = 65;
            //            #endregion

            //            #region MyRegion
            //            string mySentence;
            //            mySentence = "How do you do?";
            //            Console.WriteLine(mySentence);
            //            mySentence = "I am OK!";
            //            Console.WriteLine(mySentence);
            //            #endregion

            //            #region MyRegion
            //            Console.Write("Bob");
            //            Console.WriteLine("Kevin");
            //            Console.Write
            //                ("Tom");
            //            #endregion

            //            //#region MyRegion
            //            //Console.WriteLine("Please input your name");
            //            //string name = Console.ReadLine();
            //            //Console.WriteLine("any key to the next ");
            //            //Console.ReadKey();
            //            //Console.WriteLine("Your name is " + name);

            //            //#endregion

            //            //#region MyRegion
            //            //Console.WriteLine("Please input a character");
            //            //int ch = Console.Read();
            //            //Console.WriteLine("The ASCII code is " + ch);
            //            //#endregion

            //            //#region MyRegion
            //            //double r , s;
            //            //Console.Write("r = ");
            //            //r = Convert.ToDouble(Console.ReadLine());
            //            //s = 3.14 * r * r;
            //            //Console.WriteLine("s = " + s);
            //            //#endregion

            //            #region
            //            int code = (int)'A';
            //            Console.WriteLine("A->{0}",code);
            //            #endregion

            //            #region MyRegion
            //            Console.WriteLine("\u0047\u006F\u006F\u0064\u0021");
            //            #endregion
            //            #region MyRegion
            //            Console.WriteLine(Convert.ToString(71,16)); // ASCII码为71的字符是G,将71转为十六进制得到0047
            //            Console.WriteLine("\u5c0f\u56ed\u9999\u5f84\u72ec\u5f98\u5f8a"); ;
            //            #endregion

            //            #region MyRegion
            //            char character = '杜';
            //            int code10 = (int)character;
            //            string code16 = Convert.ToString(code10, 16);
            //            Console.WriteLine("{0} 的Unicode编码为：{1}", character, code16);
            //            #endregion

            //            #region MyRegion
            //            Console.WriteLine("What is your name?\nMy name is Miguel");
            //            #endregion

            //            #region MyRegion
            //            Console.WriteLine("Test"+"\\");
            //            Console.WriteLine("Test" + "\0");
            //            Console.WriteLine("Test" + "\a");
            //            Console.WriteLine("Test" + "\b");
            //            Console.WriteLine("Test" + "\f");
            //            Console.WriteLine("Test" + "\n");
            //            Console.WriteLine("Test" + "\r");
            //            Console.WriteLine("Test" + "\t");
            //            Console.WriteLine("Test" + "\v");

            //            #endregion

            //            #region MyRegion
            //            Console.WriteLine( "C:\\WINDOWS\\Fonts");
            //            #endregion

            //            #region MyRegion
            //            Console.WriteLine("1.2\t1.89\t3.14\t\n2.75\t3.89\t239\t0.76\t6342\t3.92\a");
            //            #endregion
            //            #region MyRegion
            //            Console.WriteLine("\\n\\t\\a\n\\\'\\\'\\0");
            //            #endregion
            //            #region MyRegion
            //            Console.WriteLine(  @"Good \n Better \t best!
            //Another line.");
            //            #endregion

            //            #region MyRegion
            //            Console.WriteLine(@" 
            //                                 *
            //                               *   *
            //                              *     *
            //                               *   *
            //                                 *
            //");

            //            #endregion


            //            #region MyRegion
            //            string mySentence1 = "Harvard is a world-famous university";
            //            mySentence1 = mySentence1 + " where I got myDoctor's degree.";
            //            Console.WriteLine( mySentence1);
            //            #endregion

            //            float pi = 3.14f;
            //            Console.WriteLine(  "The approximation od pi is "+ pi);


            //            #region MyRegion
            //            int i = 360;
            //            int j = 60;
            //            Console.WriteLine(  "{0,6}\n +{1,3}\n--------\n{2,6}",i,j,i+j);
            //            #endregion
            //            Console.WriteLine();
            //            #region MyRegion
            //            decimal i1 = 19.23m;
            //            decimal j1 = 73.7m;
            //            Console.WriteLine(  "{0,8:C2}\n+{1,7:c2}\n-------\n{2,8:C2}",i1,j1,i1+j1);
            //            #endregion

            //            #region MyRegion
            //            Console.WriteLine(  "{0,6:N3}",10000000);
            //            #endregion

            //            #region MyRegion
            //            double pi1 = 3.1415926;
            //            Console.WriteLine( "{0:#.00}",pi1);
            //            Console.WriteLine( "{0:#.000}",pi1);
            //            Console.WriteLine("{0:#.0000}",pi1); // 请注意中文的冒号：，与英文的冒号:非常相似。在调试程序时候需要注意，
            //            #endregion

            //            #region MyRegion
            //            int @int;
            //            @int = 100;
            //            Console.WriteLine( @int);

            //            string _privateName;
            //            _privateName = "my name";


            //            ushort width =3;
            //            ushort length=4;            
            //            ushort area = (ushort)(width * length); //If width and length are both ushort variables, the result of the multiplication will be an int value. 

            //            #endregion

            //            #region MyRegion
            //            const double pi2 = 3.1415926;

            //            #endregion
            //            #region MyRegion
            //            int y2 = 2008;
            //            int m2 = 8;
            //            int d2 = 8;
            //            int week = (d2 + 2 * m2 + 3 * (m2 + 1) / 5 + y2 + y2 / 4 - y2 / 100 + y2 / 400 + 1) % 7;
            //            Console.WriteLine("2008年8月8日是星期{0}",week);
            //            #endregion

            //            #region MyRegion
            //            int x4 = 10 / 3;
            //            double y4 = 10 / 3;
            //            double z4 = 10.0 / 3;
            //            Console.WriteLine("x4={0}",x4);
            //            Console.WriteLine("y4={0}",y4);
            //            Console.WriteLine("z4={0}",z4);

            //            #endregion

            //            //#region MyRegion
            //            //double x5 = Convert.ToDouble(Console.ReadLine());
            //            //Console.WriteLine(x5);
            //            //#endregion

            //#region MyRegion
            //Console.WriteLine("Please input your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("any key to the next ");
            //Console.ReadKey();
            //Console.WriteLine("Your name is " + name);

            //            Console.WriteLine( Math.Pow(2,3));
            //            Console.WriteLine(Math.Sqrt(16));
            //            Console.WriteLine(  Math.Exp(2));
            //            Console.WriteLine(  Math.Abs(-5));
            //            Console.WriteLine(  Math.Log(8,2));
            //            Console.WriteLine(Math.Sin(Math.PI/3));
            //            Console.WriteLine("Math E: {0}",Math.E);
            //            #endregion

            //            //#region MyRegion
            //            //double husDegree = Convert.ToDouble(Console.ReadLine());
            //            //double cesDegree = (husDegree - 32) * 5 / 9;
            //            //Console.WriteLine("when husDegree is {0}, cesDegree is {1}",husDegree,cesDegree);
            //            //#endregion

            //            #region MyRegion
            //            int myAge1 = 22;
            //            Console.WriteLine( myAge1);
            //            Console.WriteLine(++myAge1);
            //            #endregion

            //            #region MyRegion
            //            int day1 = 12;
            //            int today1;
            //            today1 = day1++;
            //            Console.WriteLine(  "day1={0},today1 ={1}",day1,today1); //先赋值再自增
            //            #endregion

            //            #region MyRegion
            //            int i5 = 3;
            //            Console.WriteLine(i5--);
            //            Console.WriteLine(i5++);
            //            Console.WriteLine(i5);
            //            #endregion
            //            #region MyRegion
            //            string text1 = "Welcome to ";
            //            text1 += "Suzhou";
            //            Console.WriteLine(  text1);
            //            #endregion

            //            #region MyRegion
            //            int n1 = 8226598;
            //            short s1 = checked((short) n1);
            //            Console.WriteLine( "s1 = "+s1);
            //            Console.WriteLine(Convert.ToInt16("1000011100011101",2));
            //            #endregion

            //            #region MyRegion
            //            double pi4 = 3.14;
            //            int n4 = (int)pi4;
            //            Console.WriteLine( n4);
            //            #endregion

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

            //#region MyRegion
            //Console.WriteLine("\u0047\uoo6F\u0064\u0021");
            //#endregion
            //double x, y;
            //Console.WriteLine( "x=");
            //x = Convert.ToDouble(Console.ReadLine());
            //y = x * x * x + 3 * x * x - 24 * x + 30;
            //Console.WriteLine(  "y="+y);

            //Console.WriteLine(  "请输入一个整数：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //bool isEven = (n % 2 == 0);
            //Console.Write("{0}是偶数吗？ ",n);
            //Console.Write(isEven);

            string weekstring = "";
            int week = 1;
            switch (week)
            {
                case 0: weekstring = "星期日";
                    break;
                case 1: weekstring = "星期一";
                    break;
                default: break;
            }
            Console.WriteLine(weekstring);
        }

        
      

        
    }
}

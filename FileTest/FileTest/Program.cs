using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTest
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\test.txt";
            if (File.Exists(path)){
                string contents = File.ReadAllText(path);
                Console.WriteLine("Read File:" + contents);
            }
            else
            {
                string contents = "Hello world, hello miguel";
                File.WriteAllText(path, contents);
                Console.WriteLine("Contents were written successfully!");
            }
        }
    }
}

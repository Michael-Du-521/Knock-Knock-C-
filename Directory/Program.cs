using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				string path = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7";
				if (Directory.Exists(path) )
				{ 
					// get subdirectories
					string[] dirs = Directory.GetDirectories(path);
                    Console.WriteLine("Subdirectory:");
                    foreach (string dir in dirs)
					{
                        Console.WriteLine(dir);
                    }
					// Get files
					string[] files = Directory.GetFiles(path);
                    Console.WriteLine("File:");
					foreach (string file in files)
					{
                        Console.WriteLine(file);
                    }
				}
				else
				{
                    Console.WriteLine("Directory does't exist");
                }

			}
			catch (Exception e)
			{// handle exception

                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DirectorySeparatorChar "+Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator "+Path.PathSeparator);
            Console.WriteLine("VolumeSeparatorChar "+Path.VolumeSeparatorChar);
            string path = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\servicehub.config.json";
            Console.WriteLine("GetFileName "+Path.GetFileName(path));
            Console.WriteLine("GetExtension "+Path.GetExtension(path));
            Console.WriteLine("GetDirectoryName "+Path.GetDirectoryName(path));
        }
    }
}

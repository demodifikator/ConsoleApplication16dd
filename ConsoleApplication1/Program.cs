using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Sub directories");
                string[] dirs = Directory.GetDirectories(path);
                foreach (var item in dirs)
                    Console.WriteLine(item);
            }
        }
    }
}

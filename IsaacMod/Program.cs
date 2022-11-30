using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IsaacMod
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("stringtable.sta"))
            {
                int j = 1348;
                for (int i = 0; i < 1348; i++)
                {
                    sr.ReadLine();
                }
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                    for (int i = 0; i < 8; i++)
                    {
                        sr.ReadLine();
                    }
                    Console.WriteLine(sr.ReadLine());
                    sr.ReadLine();
                    j++;
                }

            }
            Console.ReadKey();
        }
    }
}

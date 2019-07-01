using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console_Programs
{


    class program1
    {
        //public string a { get; set; }

        public static void Main(String[] args)
        {
            string a;
            Console.WriteLine("Enter the word you want to say :");
            a = Console.ReadLine();

            for (int i = 0; i <= 33; i++)
            {
                Console.WriteLine(a);

            }
            Console.ReadLine();



        }

    }
}

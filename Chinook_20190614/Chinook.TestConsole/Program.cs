using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DB.Genre.GetCount()); 
        }
    }
}

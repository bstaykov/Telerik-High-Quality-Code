using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 20,
                index => 
                {
                    if (index % 2 == 0)
                    {
                        Console.WriteLine(index);
                    }
                });
        }
    }
}

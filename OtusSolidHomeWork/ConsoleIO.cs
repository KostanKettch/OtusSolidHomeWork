using OtusSolidHomeWork.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusSolidHomeWork
{
    public class ConsoleIO : IConsoleOutput, IConsoleInput
    {
        public void Write(string value)
        {
            Console.WriteLine(value);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}

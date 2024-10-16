using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    public class ConsoleOutput : IOutput
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

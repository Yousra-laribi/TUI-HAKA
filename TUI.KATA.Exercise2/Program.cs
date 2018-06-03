using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUI.KATA.Exercise2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MessageA messageA = new MessageA() { Element = "A" };
            messageA.MyMethod();
            MessageB messageB = new MessageB() { Element = "B" };
            messageB.MyMethod();
            messageB.MySpecificMethod();
            MessageC message = new MessageC() { Element = "C" };
            message.MyMethod();
            Console.ReadLine();
            
        }
    }
}

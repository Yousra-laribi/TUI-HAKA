using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUI.KATA.Exercise2
{
    public class IMessage
    {
        public string Element { get; set; }
        public void MyMethod()
        {
            Console.WriteLine("Custom method on " + Element);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUI.KATA.Exercise2
{
    class MessageB : IMessage
    {
        
        public void MySpecificMethod()
        {
            Console.WriteLine("Message B - Specific Method");
        }
    }
}

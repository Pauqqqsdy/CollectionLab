using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FindObjectInStackTransport
    {
        public static int FindInStack(Stack<Transport> stack, Transport item)
        {
            var list = stack.ToList();
            return list.IndexOf(item);
        }
    }
}

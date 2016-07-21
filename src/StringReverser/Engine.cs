using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringReverser
{
    public class Engine
    {
        public string Reverse(string original)
        {
            return new string(original.Reverse().ToArray());
        }
    }
}

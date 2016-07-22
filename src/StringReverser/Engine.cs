using System.Linq;

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
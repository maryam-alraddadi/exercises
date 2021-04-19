using System;
using System.Collections;

namespace CheckOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "89339998";
            string test2 = "89339989";
            Console.WriteLine(checkOrder(test2));
        }

        static bool checkOrder(string value)
        {
            Stack stack = new Stack();
            string seen = "";
            foreach (var ch in value)
            {
                if (!seen.Contains(ch))
                {
                    stack.Push(ch);
                    seen += ch;
                }
                else // closing number
                {
                    if (stack.Count == 0)
                        return false;
                    if (stack.Peek().Equals(ch))
                    {
                        stack.Pop();
                        seen.Remove(seen.IndexOf(ch));
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
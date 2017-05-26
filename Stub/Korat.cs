using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ncu.Oolab.Korat.Library
{
    public class Korat
    {
        public Korat()
        {
            
        }

        public void Assert(string target)
        {
            Console.WriteLine($@"Korat asserts: {target}.");
        }

        public void Wait(string target, int timeout, int duration = 0)
        {
            Console.WriteLine($@"Korat waits: {target}.");
        }

        public void Click(string target)
        {
            Console.WriteLine($@"Korat clicks: {target}.");
        }

        public void MoveTo(int x, int y)
        {
            Console.WriteLine($@"Korat moves mouse to: {x}, {y}.");
        }

        public void SendKey(Keys key)
        {
            Console.WriteLine($@"Korat sends key: {key}.");
        }

        public void SendCompositeKeys(HashSet<Keys> keys)
        {
            string message = @"Korat sends keys: ";

            foreach (Keys key in keys)
            {
                message += key + ", ";
            }

            message = message.Substring(0, message.Length - 2);
            Console.WriteLine(message);
        }

        public void SendString(string str)
        {
            Console.WriteLine($@"Korat sends string: ""{str}"".");
        }
    }
}

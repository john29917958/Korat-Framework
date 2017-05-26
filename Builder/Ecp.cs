using System;

namespace Builder
{
    public class Ecp : Builder<object>
    {
        public delegate void M(string a);

        public M Method;

        public Ecp(string version) : base(version)
        {
            Method = s => { Test(s, "Hi"); };
        }

        public void Test(string a, string b)
        {
            
        }
    }

    
}

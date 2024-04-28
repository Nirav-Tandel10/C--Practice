using System;

namespace WebApplication1
{
    internal class Fullstack
    {
        internal int empName;
        internal int empID;

        public static implicit operator Fullstack(Fullstack v)
        {
            throw new NotImplementedException();
        }
    }
}
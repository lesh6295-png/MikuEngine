using System;
using System.Collections.Generic;

namespace Miku.Types.Base
{
    public class Id : IComparer<Id>
    {
        static int next = 1;
        public int Value { get; private set; }
        public Id()
        {
            Value = next;
            next++;
        }
        public static Id New()
        {
            return new();
        }
        public override bool Equals(object obj)
        {
            var q = (Id)obj;
            return q.Value.Equals(Value);
        }
        public int Compare(Id x, Id y)
        {
            return x.Value - y.Value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        public override int GetHashCode()
        {
            return Value;
        }
    }
}


using System.Collections.Generic;

namespace Git_Introduction
{
    internal class TestClass : BaseClass
    {
        public void Get(int a)
        {
            throw new NotImplementedException();
        }

        public void ClassMethod()
        {
            Console.WriteLine();
            var col = new SortedList<int, string>() { };

            col.Add(5, "five");

            Console.WriteLine(col[5]);
        }
    }
}

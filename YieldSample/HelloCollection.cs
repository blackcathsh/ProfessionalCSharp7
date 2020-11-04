using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldSample
{
    public class HelloCollection : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

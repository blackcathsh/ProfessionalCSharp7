using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldSample
{
    public class MusicTitles : IEnumerable<string>
    {
        private readonly string[] _names = { "Tubular Bells", "Hergest Ridge", "Ommadawn", "Platinum" };

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < _names.Length; i++)
            {
                yield return _names[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Reverse()
        {
            for (int i = _names.Length - 1; i >= 0; i--)
            {
                yield return _names[i];
            }
        }

        public IEnumerable<string> Subset(int index, int length)
        {
            for (int i = index; i < index + length; i++)
            {
                yield return _names[i];
            }
        }
    }
}

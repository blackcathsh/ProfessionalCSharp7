using System;
using System.Collections;

namespace YieldSample
{
    public class GameMoves
    {
        private IEnumerator _cross;
        private IEnumerator _circle;
        private int _move = 0;
        private const int MaxMoves = 9;

        public GameMoves()
        {
            _cross = Cross();
            _circle = Circle();
        }

        public IEnumerator Cross()
        {
            while (true)
            {
                Console.WriteLine($"Cross, move {_move}");

                if (++_move >= MaxMoves)
                {
                    yield break;
                }

                yield return _circle;
            }
        }

        public IEnumerator Circle()
        {
            while (true)
            {
                Console.WriteLine($"Circle, move {_move}");

                if (++_move >= MaxMoves)
                {
                    yield break;
                }

                yield return _cross;
            }
        }
    }
}

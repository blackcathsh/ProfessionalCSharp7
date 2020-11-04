using System;
using System.Collections;

namespace YieldSample
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            MusicTitles();
            GameMoves();
        }

        static void HelloWorld()
        {
            Console.WriteLine(nameof(HelloWorld));

            var helloCollection = new HelloCollection();

            foreach (var s in helloCollection)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }

        static void MusicTitles()
        {
            Console.WriteLine(nameof(MusicTitles));

            var titles = new MusicTitles();

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine();

            foreach (var title in titles.Reverse())
            {
                Console.WriteLine(title);
            }

            Console.WriteLine();

            foreach (var title in titles.Subset(2, 2))
            {
                Console.WriteLine(title);
            }

            Console.WriteLine();
        }

        static void GameMoves()
        {
            Console.WriteLine(nameof(GameMoves));

            var game = new GameMoves();
            var enumerator = game.Cross();

            while (enumerator.MoveNext())
            {
                enumerator = enumerator.Current as IEnumerator;
            }

            Console.WriteLine();
        }
    }
}

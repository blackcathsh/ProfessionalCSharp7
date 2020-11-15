﻿using System;
using System.Collections.Generic;

namespace ListSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var graham = new Racer(7, "Graham", "Hill", "UK", 14);
            var emerson = new Racer(13, "Emerson", "Fittipaldi", "Brazil", 14);
            var mario = new Racer(16, "Mario", "Andretti", "USA", 12);

            var racers = new List<Racer>(20) { graham, emerson, mario };

            // Add
            racers.Add(new Racer(24, "Michael", "Schumacher", "Germany", 91));
            racers.Add(new Racer(27, "Mika", "Hakkinen", "Finland", 20));

            // AddRange
            racers.AddRange(new Racer[]
            {
                new Racer(14, "Niki", "Lauda", "Austria", 25),
                new Racer(21, "Alain", "Prost", "France", 51)
            });

            // Insert
            racers.Insert(3, new Racer(6, "Phil", "Hill", "USA", 3));

            for (int i = 0; i < racers.Count; i++)
            {
                Console.WriteLine(racers[i]);
            }

            foreach (var r in racers)
            {
                Console.WriteLine(r);
            }

            // Searching
            int index1 = racers.IndexOf(mario);
            int index2 = racers.FindIndex(new FindCountry("Finland").FindCountryPredicate);
            int index3 = racers.FindIndex(r => r.Country == "Finland");
            Racer racer = racers.Find(r => r.FirstName == "Niki");
            List<Racer> bigWinners = racers.FindAll(r => r.Wins > 20);

            foreach (var r in bigWinners)
            {
                Console.WriteLine($"{r:A}");
            }

            Console.WriteLine();

            // Remove
            if (!racers.Remove(graham))
            {
                Console.WriteLine("Object not found in collection");
            }

            // Sort
            racers.Sort();
        }
    }
}

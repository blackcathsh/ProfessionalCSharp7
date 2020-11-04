using System;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var span1 = IntroSpans();
            var span2 = CreateSlices(span1);
            ChangeValues(span1, span2);
        }

        private static void DisplaySpan(string title, ReadOnlySpan<int> span)
        {
            Console.WriteLine(title);

            for (int i = 0; i < span.Length; i++)
            {
                Console.Write($"{span[i]}.");
            }

            Console.WriteLine();
        }

        private static Span<int> IntroSpans()
        {
            int[] arr1 = { 2, 4, 6, 8, 10, 12 };
            var span1 = new Span<int>(arr1);
            span1[1] = 11;
            Console.WriteLine($"arr1[1] is changed via span1[1]: {arr1[1]}");
            return span1;
        }

        private static Span<int> CreateSlices(Span<int> span1)
        {
            Console.WriteLine(nameof(CreateSlices));

            int[] arr2 = { 3, 5, 7, 9, 11, 13, 15 };
            var span2 = new Span<int>(arr2);
            var span3 = new Span<int>(arr2, start: 3, length: 3);
            var span4 = span1.Slice(start: 2, length: 4);

            DisplaySpan("content of span3", span3);
            DisplaySpan("content of span4", span4);

            Console.WriteLine();

            return span2;
        }

        private static void ChangeValues(Span<int> span1, Span<int> span2)
        {
            Console.WriteLine(nameof(ChangeValues));

            var span4 = span1.Slice(start: 4);
            span4.Clear();
            DisplaySpan("content of span1", span1);

            var span5 = span2.Slice(start: 3, length: 3);
            span5.Fill(42);
            DisplaySpan("content of span2", span2);

            span5.CopyTo(span1);
            DisplaySpan("content of span1", span1);

            if (!span1.TryCopyTo(span4))
            {
                Console.WriteLine("Couldn't copy span1 to span4 because span4 is too small");
                Console.WriteLine($"length of span4: {span4.Length}, length of span1: {span1.Length}");
            }

            Console.WriteLine();
        }
    }
}

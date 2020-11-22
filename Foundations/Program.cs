using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Foundations
{
    class Program
    {
        static void Main(string[] args)
        {
            // CallerWithAsync();
            // CallerWithAwaiter();
            CallerWithContinuationTask();

            Console.WriteLine("Main: waiting for other tasks");
            Console.ReadLine();
        }

        public static void TraceThreadAndTask(string info)
        {
            string taskInfo = Task.CurrentId == null ? "no task" : $"task {Task.CurrentId}";

            Console.WriteLine($"{info} in thread {Thread.CurrentThread.ManagedThreadId} and {taskInfo}");
        }

        private static string Greeting(string name)
        {
            TraceThreadAndTask($"running {nameof(Greeting)}");
            Task.Delay(3000).Wait();
            return $"Hello, {name}";
        }

        private static Task<string> GreetingAsync(string name) =>
            Task.Run(() =>
            {
                TraceThreadAndTask($"running {nameof(GreetingAsync)}");
                return Greeting(name);
            });

        private async static void CallerWithAsync()
        {
            TraceThreadAndTask($"started {nameof(CallerWithAsync)}");
            string result = await GreetingAsync("Stephanie");
            Console.WriteLine(result);
            TraceThreadAndTask($"ended {nameof(CallerWithAsync)}");
        }

        private static void CallerWithAwaiter()
        {
            TraceThreadAndTask($"starting {nameof(CallerWithAwaiter)}");
            TaskAwaiter<string> awaiter = GreetingAsync("Matthias").GetAwaiter();
            awaiter.OnCompleted(OnCompleteAwaiter);

            void OnCompleteAwaiter()
            {
                Console.WriteLine(awaiter.GetResult());
                TraceThreadAndTask($"ended {nameof(CallerWithAwaiter)}");
            }
        }

        private static void CallerWithContinuationTask()
        {
            TraceThreadAndTask($"started {nameof(CallerWithContinuationTask)}");

            var t1 = GreetingAsync("Stephanie");

            t1.ContinueWith(t =>
            {
                string result = t.Result;
                Console.WriteLine(result);

                TraceThreadAndTask($"ended {nameof(CallerWithContinuationTask)}");
            });
        }
    }
}

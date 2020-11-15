using System;
using System.Threading.Tasks;

namespace QueueSample
{
    class Program
    {
        static async Task Main()
        {
            var documentManager = new DocumentManager();

            Task processDocuments = ProcessDocuments.Start(documentManager);

            for (int i = 0; i < 100; i++)
            {
                var doc = new Document($"Doc {i}", "content");
                documentManager.AddDocument(doc);
                Console.WriteLine($"Added document {doc.Title}");
                await Task.Delay(new Random().Next(20));
            }

            await processDocuments;

            Console.ReadLine();
        }
    }
}

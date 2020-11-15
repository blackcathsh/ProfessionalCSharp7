using System;
using System.Threading.Tasks;

namespace QueueSample
{
    public class ProcessDocuments
    {
        private DocumentManager _documentManager;

        protected ProcessDocuments(DocumentManager documentManager)
        {
            _documentManager = documentManager ?? throw new ArgumentNullException(nameof(documentManager));
        }

        protected async Task Run()
        {
            while (true)
            {
                if (_documentManager.IsDocumentAvailable)
                {
                    Document doc = _documentManager.GetDocument();
                    Console.WriteLine($"Processing document {doc.Title}");
                }

                await Task.Delay(new Random().Next(20));
            }
        }

        public static Task Start(DocumentManager documentManager) =>
            Task.Run(new ProcessDocuments(documentManager).Run);
    }
}

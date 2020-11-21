using System;

namespace UsingStatic
{
    public class Resource : IDisposable
    {
        public void Foo() => Console.WriteLine("Foo");

        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    Console.WriteLine("release resource");
                }

                _disposedValue = true;
            }
        }

        public void Dispose() => Dispose(true);
    }
}

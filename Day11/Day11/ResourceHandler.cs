using System;

class ResourceHandler : IDisposable
{
    public ResourceHandler()
    {
        Console.WriteLine("Resource Acquired.");
    }
    public void Dispose()
    {
        Console.WriteLine("Resource Released.");
    }
}
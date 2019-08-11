using System;

namespace HelloWorldLibrary.OutputTypes
{
    public class ConsoleHelloWorld : IHelloWorld
    {

        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}

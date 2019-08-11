using HelloWorldLibrary.OutputTypes;
using System;

namespace HelloWorldLibrary
{
    public class HelloWorldFactory
    {

        public static IHelloWorld Build(string outputType)
        {
            switch (outputType)
            {
                
                case "console":
                    return new ConsoleHelloWorld();
                case "database":
                default:
                    throw new NotImplementedException();
            }
                
        }
    }
}

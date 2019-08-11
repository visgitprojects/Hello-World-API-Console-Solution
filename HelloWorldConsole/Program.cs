using HelloWorldLibrary;
using System;
using System.Configuration;

namespace HelloWorldConsole
{

    class Program
    {
        const string HelloWorld = "Hello World!";
        static readonly string OutputType = ConfigurationManager.AppSettings["OutputType"];

        static void Main(string[] args)
        {
            var helloWorld = HelloWorldFactory.Build(OutputType);
            helloWorld.Write(HelloWorld); 

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

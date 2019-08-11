using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldLibrary;
using System;
using System.IO;
using HelloWorldLibrary.OutputTypes;

[TestClass]
public class ConsoleHelloWorldTests
{
    const string HelloWorld = "Hello World!";

    [TestInitialize]
    public void InitializeTest()
    {
        StreamWriter standardOut =
            new StreamWriter(Console.OpenStandardOutput());
        standardOut.AutoFlush = true;
        Console.SetOut(standardOut);
    }

    [TestMethod]
    public void ValidateConsoleOutput()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            var helloWorld = new ConsoleHelloWorld();
            helloWorld.Write(HelloWorld);

            string expected = HelloWorld + Environment.NewLine;
            Assert.AreEqual(expected, sw.ToString());
            
        }
    }

}
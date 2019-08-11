using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldLibrary;
using System;
using HelloWorldLibrary.OutputTypes;

[TestClass]
public class HelloWorldFactoryTests
{
    const string HelloWorld = "Hello World!";

    [DataTestMethod]
    [DataRow("console")]
    public void ValidateFactoryType(string outputCases)
    {
        var helloWorld = HelloWorldFactory.Build(outputCases);
         
        Assert.IsInstanceOfType(helloWorld, typeof(ConsoleHelloWorld));
    }

    [DataTestMethod]
    [ExpectedException(typeof(NotImplementedException))]
    [DataRow("database")]
    [DataRow("")]
    public void ValidateNotImplimented(string outputCases)
    {
        var helloWorld = HelloWorldFactory.Build(outputCases);
    }
}
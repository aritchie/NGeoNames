using System;
using System.IO;
using NUnit.Framework;


namespace NGeoNames.Tests
{
    [SetUpFixture]
    public class Startup
    {
        [OneTimeSetUp]
        public static void AssemblyInitialize()
        {
            Directory.SetCurrentDirectory("C:\\dev\\acr\\ngeonames\\ngeonames.tests\\bin\\debug");
        }
    }
}

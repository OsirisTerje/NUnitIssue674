using NUnit.Framework;
using System;

namespace AnotherTestProject.Tests
{
    public class Class1Test
    {
        [Test(), TestCaseSource(typeof(Class1TestData), nameof(Class1TestData.SomeFunctionData))]
        public string SomeFunctionTest(int i)
        {
            return new Class1().SomeFunction(i);
        }
    }

    public class WhateverTest
    {
        [Test]
        public void JustChecking()
        {
            Assert.Pass();
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AnotherTestProject.Tests
{
    public class Class1TestData
    {
        public static IEnumerable<TestCaseData> SomeFunctionData
        {
            get
            {
                yield return new TestCaseData(5).Returns("abcd5");
                yield return new TestCaseData(15).Returns("abcd15");
                yield return new TestCaseData(125).Returns("abcd125");
                yield return new TestCaseData(1235).Returns("abcd1235");
            }
        }
    }
}
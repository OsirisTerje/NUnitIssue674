using System.Collections;
using NUnit.Framework;

namespace nUnitExpressionTest.Tests
{
    public class TestCaseSourceTests
    {

        [TestCaseSource(typeof(TestDataInformation), nameof(TestDataInformation.TestCases))]
        public void TheTestItself(string someinformation)
        {

        }
    }

    public class TestDataInformation
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("whatever");
                yield return new TestCaseData("whatever!");
                yield return new TestCaseData("whatever(45)");
                yield return new TestCaseData("whatever<4>");
                yield return new TestCaseData("whatever(c=>c*2)");
              //  yield return new TestCaseData("whatever(4 5 a b c)");
              //   yield return new TestCaseData("whatever(\"abc\")");
                // yield return new TestCaseData("whatever(45,c.x=\"abc\")");
            }
        }
    }
}

using System.Collections.Generic;
using AdventOfCode.Day1;
using AdventOfCode.Helpers;
using Moq;
using NUnit.Framework;

namespace AdventOfCodeTests.Day1
{
    [TestFixture]
    public class DepthFinderTests
    {
        [Test]
        public void CountIncreasesInFile()
        {
            // ASSEMBLE
            IEnumerable<string> values = new[] { "199", "200", "208", "210", "200", "207", "240", "269", "260", "263" };
            int expectedValue = 7;

            Mock<IFileReader> fileReaderMock = new Mock<IFileReader>();
            fileReaderMock.Setup(x => x.GetLinesInFile(Resource.Day1File)).Returns(values);

            DepthFinder sut = new DepthFinder(fileReaderMock.Object);

            // ACT
            var result = sut.Solve();

            // ASSERT
            Assert.That((int)result, Is.EqualTo(expectedValue));
        }
    }
}

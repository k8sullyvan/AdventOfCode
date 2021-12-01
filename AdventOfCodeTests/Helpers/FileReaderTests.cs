using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode.Helpers;
using NUnit.Framework;

namespace AdventOfCodeTests.Helpers
{
    [TestFixture]
    public class FileReaderTests
    {
        [Test]
        public void FileReader_ReadsFiles()
        {
            IEnumerable<string> expectedValues = new[] { "199", "200", "208", "210", "200", "207", "240", "269", "260", "263" };

            var actualValues = new FileReader().GetLinesInFile(Resource.TestFile);

            Assert.That(actualValues, Is.EquivalentTo(expectedValues));
        }
    }
}

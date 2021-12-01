using System.Collections.Generic;

namespace AdventOfCode.Helpers
{
    public class FileReader : IFileReader
    {
        public IEnumerable<string> GetLinesInFile(string filePath)
        {
            return System.IO.File.ReadLines(filePath);
        }
    }
}

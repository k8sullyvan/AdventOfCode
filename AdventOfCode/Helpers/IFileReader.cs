using System.Collections.Generic;

namespace AdventOfCode.Helpers
{
    public interface IFileReader
    {
        IEnumerable<string> GetLinesInFile(string filePath);
    }
}

using System.Linq;
using AdventOfCode.Helpers;

namespace AdventOfCode.Day1
{
    public class DepthFinder : IDailySolution
    {
        private readonly IFileReader _fileReader;

        public DepthFinder(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public object Solve()
        {
            var lines = _fileReader.GetLinesInFile(Resource.Day1File);

            int count = 0;
            int previousDigit = int.Parse(lines.First());
            foreach (var line in lines)
            {
                int currentDigit = int.Parse(line);
                if (previousDigit < currentDigit)
                {
                    count++;
                }

                previousDigit = currentDigit;
            }

            return count;
        }
    }
}

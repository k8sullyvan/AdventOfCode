using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Helpers;

namespace AdventOfCode.Day1
{
    public class DepthFinderPart2 : IDailySolution
    {
        private readonly IFileReader _fileReader;

        public DepthFinderPart2(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public object Solve()
        {
            var lines = _fileReader.GetLinesInFile(Resource.Day1File);

            int count = 0;
            RollingCounter rollingCounter = new RollingCounter(3);
            foreach (var line in lines)
            {
                bool isFull = rollingCounter.IsFull();
                var previousSum = rollingCounter.Sum();
                rollingCounter.Add(int.Parse(line));
                int currentSum = rollingCounter.Sum();
                if (isFull && previousSum < currentSum)
                {
                    count++;
                }
            }

            return count;
        }
    }

    public class RollingCounter
    {
        private readonly int _capacity;
        private readonly int?[] _ring;
        private int _index = 0;

        public RollingCounter(int capacity)
        {
            _capacity = capacity;
            _ring = new int?[capacity];
        }

        public bool IsFull()
        {
            return _ring.All(x => x.HasValue);
        }

        public void Add(int value)
        {
            _ring[_index] = value;
            _index = ++_index % _capacity;
        }

        public int Sum()
        {
            return _ring.Sum(x => x.GetValueOrDefault());
        }
    }
}

namespace SortingRoutines.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using SortingRoutines.Library;

    [TestFixture]
    public class WhenSortingNumbers
    {
        private static readonly List<int> Given = new List<int> {3, 2, 4, 1};
        private static readonly List<int> Expected = new List<int> {1, 2, 3, 4};

        [TestCase]
        public void BubbleSortCorrectlySorts()
        {
            var sorter = new BubbleSort();
            Assert.That(sorter.Sort(Expected), Is.EquivalentTo(Expected));
            Assert.That(sorter.Sort(Given), Is.EquivalentTo(Expected));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static SortArray.ArraySorter;

namespace SortArray.Tests
{
    [TestFixture]
    public class ArraySorterTest
    {
        [Test]
        public void SortTests()
        {
            int[][] testArray = new int[8][] {
                null,
                new int[] {1,6,4,0},
                new int[] {9,9,100,9, -100},
                null,
                null,
                new int[] {-5,9,-20,7,0,0,0,0},
                new int[] {89,38,19,-8},
                new int[] {-91}};
            int[][] result = new int[8][] {
                new int[] {-91},
                new int[] {-5,9,-20,7,0,0,0,0},
                new int[] {1,6,4,0},
                new int[] {9,9,100,9, -100},
                new int[] {89,38,19,-8},
                null,
                null,
                null
                };
            SortArray.ArraySorter.Sort(testArray, 1);
            Assert.AreEqual(result, testArray);
        }

        [Test]
        public void SortByAbsTests()
        {
            int[][] testArray = new int[8][] {
                null,
                new int[] {1,6,4,0},
                new int[] {9,9,100,9, -100},
                null,
                null,
                new int[] {-5,9,-20,7,0,0,0,0},
                new int[] {89,38,19,-8},
                new int[] {-91}};
            int[][] result = new int[8][] {
                new int[] {1,6,4,0},
                new int[] {-5,9,-20,7,0,0,0,0},
                new int[] {89,38,19,-8},
                new int[] {-91},
                new int[] {9,9,100,9, -100},
                null,
                null,
                null
                };
            SortArray.ArraySorter.Sort(testArray, 2);
            Assert.AreEqual(result, testArray);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortNullTests()
        {
            int[][] testArray = null;
            int[][] result = null;
            SortArray.ArraySorter.Sort(testArray, 2);
            Assert.AreEqual(result, testArray);
        }
    }
}

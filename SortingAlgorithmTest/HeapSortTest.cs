using SortingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingAlgorithmTest
{
    [TestClass]
    public class HeapSortTest
    {
        [TestMethod]
        public void WhenHeapArrayHaventElements()
        {
            try
            {
                decimal[] heapSortArray = new decimal[0];
                HeapSort heapSort = new HeapSort(heapSortArray);
            }
            catch (ArgumentOutOfRangeException err)
            {
                Assert.IsTrue(err.Message.Contains("The heap array must have at least one element."));
            }
        }

        [TestMethod]
        public void WhenHeapArrayDontHaveNodes()
        {
            decimal[] heapSortArray = new decimal[2];
            HeapSort heapSort = new HeapSort(heapSortArray);
            Assert.AreEqual(heapSortArray[0], 0);
            Assert.AreEqual(heapSortArray[1], 0);
        }

        [TestMethod]
        public void WhenHeapArrayLengthIsLessThanIndex()
        {
            try
            {
                decimal[] heapSortArray = new decimal[1];
                HeapSort heapSort = new HeapSort(heapSortArray);
                heapSort.MAX_HEAPIFY(2);
            }
            catch (ArgumentOutOfRangeException err)
            {
                Assert.IsTrue(err.Message.Contains("The index value is less than heap array length."));
            }
        }

        [TestMethod]
        public void WhenHeapArrayHaveTenUnsortedElementsAsMaxHeap()
        {
            // C# array is Zero-based because this its index initializes with number 0 and the arrange heapsort
            // algorithm initializes with 1. One adaptation is necessary to match structure array with algorithm
            // is initializes the heapSortArray in  the position 1 and ignore the 0 position. Incresing heap array
            // one position, so the zero position is ignored (-1).

            decimal[] inHeapSortArray = new decimal[11] { -1, 16, 4, 10, 14, 7, 9, 3, 2, 8, 1 };
            HeapSort heapSort = new HeapSort(inHeapSortArray);

            heapSort.MAX_HEAPIFY(2);

            // int[] outHeapSortArray = new int[11] { -1, 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 };
            Assert.AreEqual(heapSort.HeapSortArray[1], 16);
            Assert.AreEqual(heapSort.HeapSortArray[2], 14);
            Assert.AreEqual(heapSort.HeapSortArray[3], 10);
            Assert.AreEqual(heapSort.HeapSortArray[4], 8);
            Assert.AreEqual(heapSort.HeapSortArray[5], 7);
            Assert.AreEqual(heapSort.HeapSortArray[6], 9);
            Assert.AreEqual(heapSort.HeapSortArray[7], 3);
            Assert.AreEqual(heapSort.HeapSortArray[8], 2);
            Assert.AreEqual(heapSort.HeapSortArray[9], 4);
            Assert.AreEqual(heapSort.HeapSortArray[10], 1);
        }

        [TestMethod]
        public void BuildMaxHeapWithTenElementsAsMaxHeap()
        {
            // C# array is Zero-based because this its index initializes with number 0 and the arrange heapsort
            // algorithm initializes with 1. One adaptation is necessary to match structure array with algorithm
            // is initializes the heapSortArray in  the position 1 and ignore the 0 position. Incresing heap array
            // one position, so the zero position is ignored (-1).

            decimal[] inHeapSortArray = new decimal[11] { -1, 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            HeapSort heapSort = new HeapSort(inHeapSortArray);

            heapSort.BUILD_MAX_HEAP();

            // int[] outHeapSortArray = new int[11] { -1, 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 };
            Assert.AreEqual(heapSort.HeapSortArray[1], 16);
            Assert.AreEqual(heapSort.HeapSortArray[2], 14);
            Assert.AreEqual(heapSort.HeapSortArray[3], 10);
            Assert.AreEqual(heapSort.HeapSortArray[4], 8);
            Assert.AreEqual(heapSort.HeapSortArray[5], 7);
            Assert.AreEqual(heapSort.HeapSortArray[6], 9);
            Assert.AreEqual(heapSort.HeapSortArray[7], 3);
            Assert.AreEqual(heapSort.HeapSortArray[8], 2);
            Assert.AreEqual(heapSort.HeapSortArray[9], 4);
            Assert.AreEqual(heapSort.HeapSortArray[10], 1);
        }

        [TestMethod]
        public void HeapSortWithTenElements()
        {
            // C# array is Zero-based because this its index initializes with number 0 and the arrange heapsort
            // algorithm initializes with 1. One adaptation is necessary to match structure array with algorithm
            // is initializes the heapSortArray in  the position 1 and ignore the 0 position. Incresing heap array
            // one position, so the zero position is ignored (-1).

            decimal[] inHeapSortArray = new decimal[11] { -1, 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            HeapSort heapSort = new HeapSort(inHeapSortArray);

            heapSort.HEAPSORT();

            // int[] outHeapSortArray = new int[11] { -1, 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 };
            Assert.AreEqual(heapSort.HeapSortArray[1], 1);
            Assert.AreEqual(heapSort.HeapSortArray[2], 2);
            Assert.AreEqual(heapSort.HeapSortArray[3], 3);
            Assert.AreEqual(heapSort.HeapSortArray[4], 4);
            Assert.AreEqual(heapSort.HeapSortArray[5], 7);
            Assert.AreEqual(heapSort.HeapSortArray[6], 8);
            Assert.AreEqual(heapSort.HeapSortArray[7], 9);
            Assert.AreEqual(heapSort.HeapSortArray[8], 10);
            Assert.AreEqual(heapSort.HeapSortArray[9], 14);
            Assert.AreEqual(heapSort.HeapSortArray[10], 16);
        }

        [TestMethod]
        public void HeapSortWithFifteenElements()
        {
            // C# array is Zero-based because this its index initializes with number 0 and the arrange heapsort
            // algorithm initializes with 1. One adaptation is necessary to match structure array with algorithm
            // is initializes the heapSortArray in  the position 1 and ignore the 0 position. Incresing heap array
            // one position, so the zero position is ignored (-1).

            decimal[] inHeapSortArray = new decimal[16] { -1, 4, 1, 3, 2, 16, 9, 10, 14, 8, 7, 11, 12, 6, 5, 13 };
            HeapSort heapSort = new HeapSort(inHeapSortArray);

            heapSort.HEAPSORT();

            Assert.AreEqual(heapSort.HeapSortArray[1], 1);
            Assert.AreEqual(heapSort.HeapSortArray[2], 2);
            Assert.AreEqual(heapSort.HeapSortArray[3], 3);
            Assert.AreEqual(heapSort.HeapSortArray[4], 4);
            Assert.AreEqual(heapSort.HeapSortArray[5], 5);
            Assert.AreEqual(heapSort.HeapSortArray[6], 6);
            Assert.AreEqual(heapSort.HeapSortArray[7], 7);
            Assert.AreEqual(heapSort.HeapSortArray[8], 8);
            Assert.AreEqual(heapSort.HeapSortArray[9], 9);
            Assert.AreEqual(heapSort.HeapSortArray[10], 10);
            Assert.AreEqual(heapSort.HeapSortArray[11], 11);
            Assert.AreEqual(heapSort.HeapSortArray[12], 12);
            Assert.AreEqual(heapSort.HeapSortArray[13], 13);
            Assert.AreEqual(heapSort.HeapSortArray[14], 14);
            Assert.AreEqual(heapSort.HeapSortArray[15], 16);
        }


        [TestMethod]
        public void HeapSortWithFifteenRepeatedElements()
        {
            // C# array is Zero-based because this its index initializes with number 0 and the arrange heapsort
            // algorithm initializes with 1. One adaptation is necessary to match structure array with algorithm
            // is initializes the heapSortArray in  the position 1 and ignore the 0 position. Incresing heap array
            // one position, so the zero position is ignored (-1).

            decimal[] inHeapSortArray = new decimal[16] { -1, 4, 1, 3, 2, 16, 9, 10, 14, 3, 7, 11, 12, 6, 5, 1 };
            HeapSort heapSort = new HeapSort(inHeapSortArray);

            heapSort.HEAPSORT();

            Assert.AreEqual(heapSort.HeapSortArray[1], 1);
            Assert.AreEqual(heapSort.HeapSortArray[2], 1);
            Assert.AreEqual(heapSort.HeapSortArray[3], 2);
            Assert.AreEqual(heapSort.HeapSortArray[4], 3);
            Assert.AreEqual(heapSort.HeapSortArray[5], 3);
            Assert.AreEqual(heapSort.HeapSortArray[6], 4);
            Assert.AreEqual(heapSort.HeapSortArray[7], 5);
            Assert.AreEqual(heapSort.HeapSortArray[8], 6);
            Assert.AreEqual(heapSort.HeapSortArray[9], 7);
            Assert.AreEqual(heapSort.HeapSortArray[10], 9);
            Assert.AreEqual(heapSort.HeapSortArray[11], 10);
            Assert.AreEqual(heapSort.HeapSortArray[12], 11);
            Assert.AreEqual(heapSort.HeapSortArray[13], 12);
            Assert.AreEqual(heapSort.HeapSortArray[14], 14);
            Assert.AreEqual(heapSort.HeapSortArray[15], 16);
        }
    }
}

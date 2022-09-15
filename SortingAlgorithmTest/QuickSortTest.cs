using SortingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTest
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void WhenPARTITIONReceivesArrangeNull()
        {
            try
            {
                QuickSort quickSort = new QuickSort();
                quickSort.PARTITION(null, 0, 0);
            }
            catch (ArgumentNullException err)
            {
                Assert.IsTrue(err.Message.Contains("The arrange must have at least one element."));
            }
        }


        [TestMethod]
        public void WhenPARTITIONReceivesAnArrangeWithLengthEqualsToZero()
        {
            try
            {
                decimal[] arrange = new decimal[0];
                QuickSort quickSort = new QuickSort();
                quickSort.PARTITION(arrange, 0, 0);
            }
            catch (IndexOutOfRangeException err)
            {
                Assert.IsTrue(err.Message.Contains("The length arrange must be greater than zero."));
            }
        }


        [TestMethod]
        public void WhenPARTITIONReceivesArrangeWithOneItemAndInitialIndexIsEqualsToZero()
        {
            decimal[] arrange = new decimal[1] { 0 };
            QuickSort quickSort = new QuickSort();
            int variable = quickSort.PARTITION(arrange, 0, 0);
            Assert.AreEqual(0, variable);
        }


        [TestMethod]
        public void WhenPARTITIONReceivesInitialIndexGreaterThanFinalIndex()
        {
            try
            {
                decimal[] arrange = new decimal[1] { 0 };
                QuickSort quickSort = new QuickSort();
                int variable = quickSort.PARTITION(arrange, 1, 0);
                Assert.AreEqual(0, variable);
            }
            catch (IndexOutOfRangeException err)
            {
                Assert.IsTrue(err.Message.Contains("The final index must be greater than initial index."));
            }
        }


        [TestMethod]
        public void WhenPARTITIONReceivesAInitialIndexGreaterThanLenghtArrange()
        {
            try
            {
                decimal[] arrange = new decimal[1] { 0 };
                QuickSort quickSort = new QuickSort();
                int variable = quickSort.PARTITION(arrange, 2, 2);
                Assert.AreEqual(0, variable);
            }
            catch (IndexOutOfRangeException err)
            {
                Assert.IsTrue(err.Message.Contains("The initial index must be less than length arrange."));
            }
        }


        [TestMethod]
        public void WhenPARTITIONReceivesAFinalIndexGreaterThanLenghtArrange()
        {
            try
            {
                decimal[] arrange = new decimal[1] { 0 };
                QuickSort quickSort = new QuickSort();
                int variable = quickSort.PARTITION(arrange, 1, 2);
                Assert.AreEqual(0, variable);
            }
            catch (IndexOutOfRangeException err)
            {
                Assert.IsTrue(err.Message.Contains("The initial index must be less than length arrange."));
            }
        }       


        [TestMethod]
        public void WhenPARTITIONReceivesArrangeWithEightDistinctItems()
        {
            decimal[] arrange = new decimal[8] { 2, 8, 7, 1, 3, 5, 6, 4 };
            QuickSort quickSort = new QuickSort();
            int numberOfItemsLessOrEqualThanTheLastItem = quickSort.PARTITION(arrange, 0, 7);
            Assert.AreEqual(3, numberOfItemsLessOrEqualThanTheLastItem);
        }


        [TestMethod]
        public void WhenPARTITIONReceivesArrangeWithEightRepeatedItems()
        {
            decimal[] arrange = new decimal[8] { 2, 8, 3, 1, 3, 4, 6, 4 };
            QuickSort quickSort = new QuickSort();
            int numberOfItemsLessOrEqualThanTheLastItem = quickSort.PARTITION(arrange, 0, 7);
            Assert.AreEqual(5, numberOfItemsLessOrEqualThanTheLastItem);
        }


        [TestMethod]
        public void WhenPARTITIONReceivesArrangeWithEightItemsWithSameValue()
        {
            decimal[] arrange = new decimal[8] { 2, 2, 2, 2, 2, 2, 2, 2 };
            QuickSort quickSort = new QuickSort();
            int numberOfItemsLessOrEqualThanTheLastItem = quickSort.PARTITION(arrange, 0, 7);
            Assert.AreEqual(7, numberOfItemsLessOrEqualThanTheLastItem);
        }


        [TestMethod]
        public void WhenHOARE_PARTITIONReceivesArrangeWithEightItemsWithSameValue()
        {
            decimal[] arrange = new decimal[12] { 13, 19, 9, 5, 12, 8, 7, 4, 11, 2, 6, 21 };
            QuickSort quickSort = new QuickSort();
            int numberOfItemsLessOrEqualThanTheLastItem = quickSort.HOARE_PARTITION(arrange, 0, 11);
            Assert.AreEqual(2, numberOfItemsLessOrEqualThanTheLastItem);
        }


        [TestMethod]
        public void QUICKSORTUsingPARTITIONWithTwelveDifferentItems()
        {
            decimal[] arrange = new decimal[12] { 13, 19, 9, 5, 12, 8, 7, 4, 11, 2, 6, 21 };
            QuickSort quickSort = new QuickSort();
            var rearrange = quickSort.QUICKSORT(arrange, 0, 11);
            var expectedArrange = new decimal[12] { 2, 4, 5, 6, 7, 8, 9, 11, 12, 13, 19, 21 };

            for (int i = 0; i < rearrange.Length; i++)
            {
                if (rearrange[i] != expectedArrange[i]){
                    Assert.Fail();
                }
            }
        }
    }
}

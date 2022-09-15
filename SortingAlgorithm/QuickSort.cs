using System;
using System.Collections.Generic;
using System.Linq;


namespace SortingAlgorithm
{
    public class QuickSort
    {
        public decimal[] QUICKSORT(decimal[] arrange, int initialIndex, int finalIndex) 
        { 
            if (initialIndex < finalIndex)
            {
                int partitionIndex = PARTITION(arrange, initialIndex, finalIndex);
                //int partitionIndex = HOARE_PARTITION(arrange, initialIndex, finalIndex);
                QUICKSORT(arrange, initialIndex, partitionIndex - 1);
                QUICKSORT(arrange, partitionIndex + 1, finalIndex);
            }

            return arrange;
        }


        private void ValidateParameters(decimal[] arrange, int initialIndex, int finalIndex)
        {
            if (arrange == null){
                throw new ArgumentNullException("The arrange must have at least one element.");
            }

            if (arrange.Length == 0){
                throw new IndexOutOfRangeException("The length arrange must be greater than zero.");
            }

            if (initialIndex > finalIndex){
                throw new IndexOutOfRangeException("The final index must be greater than initial index.");
            }

            if (initialIndex >= arrange.Length){
                throw new IndexOutOfRangeException("The initial index must be less than length arrange.");
            }

            if (finalIndex >= arrange.Length){
                throw new IndexOutOfRangeException("The final index must be less or equal than length arrange.");
            }
        }


        public int PARTITION(decimal[] arrange, int initialIndex, int finalIndex)
        {
            ValidateParameters(arrange, initialIndex, finalIndex);

            decimal auxValue;
            decimal finalValue = arrange[finalIndex];
            int i = initialIndex - 1;

            for (int j = initialIndex; j <= finalIndex - 1; j++)
            {
                if (arrange[j] <= finalValue)
                {
                    i += 1;
                    auxValue = arrange[j];
                    arrange[j] = arrange[i];
                    arrange[i] = auxValue;
                }
            }
            auxValue = arrange[i + 1];
            arrange[i + 1] = arrange[finalIndex];
            arrange[finalIndex] = auxValue;

            return i + 1;
        }


        public int HOARE_PARTITION(decimal[] arrange, int initialIndex, int finalIndex)
        {
            ValidateParameters(arrange, initialIndex, finalIndex);

            decimal auxValue;
            decimal initialValue = arrange[initialIndex];
            int i = initialIndex - 1;
            int j = finalIndex + 1;

            while (true)
            {
                do 
                {
                    j -= 1;
                } while (arrange[j] <= initialValue);

                do
                {
                    i += 1;
                } while (arrange[i] >= initialValue);

                if (i < j)
                {
                    auxValue = arrange[j];
                    arrange[j] = arrange[i];
                    arrange[i] = auxValue;
                }
                else {
                    return j;
                }
            }
        }
    }
}

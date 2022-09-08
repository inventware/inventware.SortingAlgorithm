
namespace SortingAlgorithm
{
    public class HeapSort
    {
        decimal[] _heapSortArray;
        int _heapSize;


        public HeapSort(decimal[] heapSortArray)
        {
            if (heapSortArray.Length < 1) {
                throw new ArgumentOutOfRangeException("The heap array must have at least one element.");
            }

            _heapSortArray = heapSortArray;
            _heapSize = heapSortArray.Length;
        }

        public decimal[] HeapSortArray { get => _heapSortArray; }

        private int PARENT(int index) => Math.Abs(index / 2);

        private int LEFT(int index) => index * 2;

        private int RIGHT(int index) => (index * 2) + 1;


        public void MAX_HEAPIFY(int index)
        {
            if (_heapSize < index) {
                throw new ArgumentOutOfRangeException("The index value is less than heap array length.");
            }

            int left = LEFT(index);

            int right = RIGHT(index);

            int larger;

            if (left < _heapSize && GetNodeValue(left) > GetNodeValue(index)){
                larger = left;
            }
            else {
                larger = index;
            }

            if (right < _heapSize && GetNodeValue(right) > GetNodeValue(larger)){
                larger = right;
            }

            if (larger != index)
            {
                decimal auxLarger = _heapSortArray[larger];
                _heapSortArray[larger] = _heapSortArray[index];
                _heapSortArray[index] = auxLarger;

                MAX_HEAPIFY(larger);
            }
        }

        private decimal GetNodeValue(int index)
        {
            try
            {
                return _heapSortArray[index];
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public void BUILD_MAX_HEAP()
        {
            for (int i = Math.Abs(_heapSize / 2); i > 0 ; i--)
            {
                MAX_HEAPIFY(i);
            }
        }

        public void HEAPSORT() 
        {
            BUILD_MAX_HEAP();
            int initialIndex = 1;

            for (int i = _heapSortArray.Length - 1; i > 0; i--)
            {
                decimal auxValue = _heapSortArray[1];
                _heapSortArray[1] = _heapSortArray[i];
                _heapSortArray[i] = auxValue;
                initialIndex++;

                _heapSize -= 1;

                MAX_HEAPIFY(1);
            }
        }
    }
}

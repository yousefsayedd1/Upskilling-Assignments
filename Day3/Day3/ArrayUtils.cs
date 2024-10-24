namespace Day3
{
    public static class ArrayUtils
    {
        public static T[] ReverseArray<T>(T[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("Array is empty");
            int leftPointer = 0, rightPointer = array.Length - 1;
            while (leftPointer < rightPointer)
            {
                T temp = array[leftPointer];
                array[leftPointer] = array[rightPointer];
                array[rightPointer] = temp;
                leftPointer++;
                rightPointer--;
            }
            return array;
        }
        public static T FindMax<T>(T[] array) where T : IComparable
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("Array is empty");
            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0) max = array[i];
            }
            return max;
        }
    }
}

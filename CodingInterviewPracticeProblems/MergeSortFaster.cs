namespace CodingInterviewPracticeProblems
{
    public class MergeSortFaster
    {
        public int[] FasterMergeSort(int[] itemsArr)
        {
            if (CheckIfSorted(itemsArr) == itemsArr.Length)
            {
                return itemsArr;
            }
            return MergeSort(itemsArr);
        }

        public int[] FasterMergeSort2(int[] arr)
        {
            int middle = CheckIfSorted(arr);
            if (middle == arr.Length)
            {
                return arr;
            }
            int[] arrLeft = arr[0..middle];
            int[] arrRight = MergeSort(arr[middle..]);
            return MergeArr(arrLeft, arrRight);
        }

        private int CheckIfSorted(int[] itemsArr)
        {
            for (int i = 0; i < itemsArr.Length - 1; i++)
            {
                if (itemsArr[i] > itemsArr[i + 1])
                {
                    return i;
                }
            }
            return itemsArr.Length;
        }

        private int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }
            int middle = arr.Length / 2;
            int[] arrLeft = MergeSort(arr[0..middle]);
            int[] arrRight = MergeSort(arr[middle..]);
            return MergeArr(arrLeft, arrRight);
        }

        private int[] MergeArr(int[] arr1, int[] arr2)
        {
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int[] newArr = new int[len1 + len2];
            int index1 = 0;
            int index2 = 0;
            int indexNew = 0;

            while (index1 < len1 || index2 < len2)
            {
                if (index2 == len2)
                {
                    newArr[indexNew++] = arr1[index1++];
                }
                else if (index1 == len1)
                {
                    newArr[indexNew++] = arr2[index2++];
                }
                else if (arr1[index1] < arr2[index2])
                {
                    newArr[indexNew++] = arr1[index1++];
                }
                else
                {
                    newArr[indexNew++] = arr2[index2++];
                }
            }
            return newArr;
        }
    }
}

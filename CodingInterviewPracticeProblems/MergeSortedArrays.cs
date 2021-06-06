namespace CodingInterviewPracticeProblems
{
    public class MergeSortedArrays
    {
        public int[] MergeSortedArray(int[] arr1, int[] arr2)
        {
            int arr1Len = arr1.Length;
            int arr2Len = arr2.Length;

            int[] newArr = new int[arr1Len + arr2Len];

            int arr1Pointer = 0;
            int arr2Pointer = 0;

            for (int i = 0; i < (arr1Len + arr2Len); i++)
            {
                if (arr1Pointer < arr1Len && arr2Pointer < arr2Len)
                {
                    if (arr1[arr1Pointer] < arr2[arr2Pointer])
                    {
                        newArr[i] = arr1[arr1Pointer];
                        arr1Pointer++;
                    }
                    else
                    {
                        newArr[i] = arr2[arr2Pointer];
                        arr2Pointer++;
                    }
                }
                else if (arr1Pointer < arr1Len)
                {
                    newArr[i] = arr1[arr1Pointer];
                    arr1Pointer++;
                }
                else
                {
                    newArr[i] = arr2[arr2Pointer];
                    arr2Pointer++;
                }
            }

            return newArr;
        }
    }
}

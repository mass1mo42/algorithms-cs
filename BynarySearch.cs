class Bynary
{


    public static int BinarySearch(int[] array, int target)
    {
        int Length = array.Length;
        int high = Length - 1;
        int low = 0;

        while (low <=high)
        {
            int mid = (high + low) / 2;
            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] > target) high = mid - 1;
            else low = mid +1;
        }
        return -1;

    }
}

class Check()
{

    static void Main()
    {
        int[] arr = new int[100];
        int target = 11808;
        for (int i = 0; i < 100; i++)
        {
            arr[i] = i * 123;

        }
        int a = Bynary.BinarySearch(arr, target);
        Console.WriteLine(a);
    }
}
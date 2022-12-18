using System.Globalization;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        #region question1
        /*
        Console.WriteLine("Enter Number : ");
        int num = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter String: ");
        string str = Console.ReadLine();
        question1(str, num);
        */
        #endregion



        #region question2
        /*
        string str1 = Console.ReadLine();
        Console.WriteLine(question2(str1));
        */
        #endregion



        #region quesiton3
        /*
        int[] numbers = { 2, 3, 1 };
        question3(numbers);
        */
        #endregion
    }

    #region Question1
    private static void question1(string str, int num)
    {
        while (str.Length < num)
        {
            str += str;
        }

        Console.WriteLine(str.Substring(0, num).Where(x => x == 'a').Count());
    }
    #endregion


    #region Question2
    private static int question2(string str)
    {
        int counter = 0;

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i - 1] == str[i])
            {
                counter++;
            }
        }

        return counter;
    }
    #endregion


    #region Question3 

    private static void question3(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine("\n");
        quickSort(numbers, 0, numbers.Length - 1);
    }

    static public int Partition(int[] arr, int left, int right)
    {
        int pivot;
        pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
            {
                left++;
            }
            while (arr[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("Swap({0},{1})", left, right);
            }
            else
            {
                return right;
            }
        }
    }
    static public void quickSort(int[] arr, int left, int right)
    {
        int pivot;
        if (left < right)
        {
            pivot = Partition(arr, left, right);
            if (pivot > 1)
            {
                quickSort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                quickSort(arr, pivot + 1, right);
            }
        }
    }
    #endregion

}
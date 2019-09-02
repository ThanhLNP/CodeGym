using System;

namespace DataStructures
{
    class Sort
    {
        public static void Main()
        {
            int[] array = { 5, 7, 9, 8, 4, 8, 6, 5, 9, 2, 1, 3, 6 };
            int[] a;

            #region Selection Sort
            a = (int[])array.Clone();
            Console.WriteLine(string.Join(", ", a));
            Console.WriteLine("----------");

            SelectionSort(a);
            Console.WriteLine(string.Join(", ", a));
            #endregion

            #region Insertion Sort
            a = (int[])array.Clone();
            Console.WriteLine("----------");

            InsertionSort(a);
            Console.WriteLine(string.Join(", ", a));
            #endregion

            #region Bubble Sort
            a = (int[])array.Clone();
            Console.WriteLine("----------");

            BubbleSort(a);
            Console.WriteLine(string.Join(", ", a));
            #endregion

            #region Quick Sort
            a = (int[])array.Clone();
            Console.WriteLine("----------");

            QuickSort(a, 0, a.Length - 1);
            Console.WriteLine(string.Join(", ", a));
            #endregion

            #region Binary Search
            a = (int[])array.Clone();
            SelectionSort(a);
            Console.WriteLine("----------");

            Console.Write("Nhap gia tri can tim kiem: ");
            int value = int.Parse(Console.ReadLine());
            int index = BinarySearch(a, value);
            if (index != -1)
            {
                Console.WriteLine("{0} duoc tim thay tai chi so: {1}", value, index);
            }
            else
            {
                Console.WriteLine("{0} khong co trong mang!", value);
            }
            #endregion
        }

        public static void SelectionSort(int[] array) //qua moi luot phan tu nho nhat chuyen ve dau
        {
            int index;
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                index = i;
                for (int j = i + 1; j < array.Length; j++) //tim vi tri cua gia tri nho nhat
                {
                    if (array[index] > array[j])
                    {
                        index = j;
                    }
                }
                if (index != i) //hoan doi phan tu nho nhat va phan tu dau tien
                {
                    temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            int min;
            int index;
            for (int i = 1; i < array.Length; i++)
            {
                min = array[i];
                index = i;
                while (index > 0 && array[index - 1] > min)
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = min;
            }
        }

        public static void BubbleSort(int[] array) //qua moi luot phan tu lon nhat chuyen ve cuoi
        {
            int temp;
            bool isSorted;
            for (int i = 0; i < array.Length - 1; i++)
            {
                isSorted = true;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isSorted = false;
                    }
                }
                if (isSorted) break;
            }
        }

        #region Quick Sort
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                QuickSort(arr, left, pivot - 1);

                QuickSort(arr, pivot + 1, right);
            }
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = right;

            right--;

            while (true)
            {
                while (left <= right && arr[left] < arr[pivot]) //tranh truong hop IndexOutOfRangeException
                {
                    left++;
                }

                while (left <= right && arr[right] > arr[pivot]) //nhu tren, ghi giong nhau cho dong bo
                {
                    right--;
                }

                if (left >= right) break;

                Swap(arr, left, right);

                left++;

                right--;
            }
            //left = right khi co gia tri bang voi gia tri pivot, ko can swap cung dc
            //left > right nghia la left dang dung o gia tri > gia tri pivot, right dung o gia tri < gia tri pivot
            Swap(arr, left, pivot);

            return left;
        }

        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        #endregion

        public static int BinarySearch(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (array[mid] == value)
                {
                    return mid;
                }
                else if (array[mid] > value)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
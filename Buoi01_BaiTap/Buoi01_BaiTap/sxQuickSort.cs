using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_BaiTap
{
    class sxQuickSort
    {
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                // Đệ quy sắp xếp nửa bên trái và nửa bên phải
                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right]; // Chọn phần tử cuối cùng làm pivot
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                // Nếu phần tử hiện tại nhỏ hơn hoặc bằng pivot
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void Main(String[] args)
        {
            // Sử dụng QuickSort
            int[] numbers = { 5, 8, 4, 6, 1, 3, 2, 7 };
            Console.WriteLine("Mang truoc khi sx:");
            foreach (int num in numbers)
                Console.Write(num + " ");

            QuickSort(numbers, 0, numbers.Length - 1);

            //In ra mảng đã được sắp xếp
            Console.WriteLine("\nMang sau khi sx:");
            foreach (int num in numbers)
                Console.Write(num + " ");

            Console.ReadLine();
        }
    }
}

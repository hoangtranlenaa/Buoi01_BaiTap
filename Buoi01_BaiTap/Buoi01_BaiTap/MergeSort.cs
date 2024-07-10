//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Buoi01_BaiTap
//{
//    class MergeSort
//    {
//        public static void mergeSort(int[] arr)
//        {
//            if (arr.Length > 1)
//            {
//                int mid = arr.Length / 2;
//                int[] left = new int[mid];
//                int[] right = new int[arr.Length - mid];

//                // Chia mảng thành hai nửa
//                for (int i = 0; i < mid; ++i)
//                    left[i] = arr[i];
//                for (int i = mid; i < arr.Length; ++i)
//                    right[i - mid] = arr[i];

//                // Đệ quy sắp xếp nửa bên trái và nửa bên phải
//                mergeSort(left);
//                mergeSort(right);

//                // Hợp nhất hai nửa đã được sắp xếp
//                Merge(arr, left, right);
//            }
//        }

//        private static void Merge(int[] arr, int[] left, int[] right)
//        {
//            int i = 0, j = 0, k = 0;

//            // Sắp xếp các phần tử từ mảng left và right vào mảng arr
//            while (i < left.Length && j < right.Length)
//            {
//                if (left[i] <= right[j])
//                    arr[k++] = left[i++];
//                else
//                    arr[k++] = right[j++];
//            }

//            // Thêm các phần tử còn lại (nếu có) từ mảng left
//            while (i < left.Length)
//                arr[k++] = left[i++];

//            // Thêm các phần tử còn lại (nếu có) từ mảng right
//            while (j < right.Length)
//                arr[k++] = right[j++];
//        }

//        static void Main(String[] args)
//        {
//            // Sử dụng MergeSort
//            int[] numbers = { 5, 2, 4, 6, 1, 3, 2, 6 };
//            Console.WriteLine("Mang truoc khi sx:");
//            foreach (int num in numbers)
//                Console.Write(num + " ");

//            mergeSort(numbers);

//            // In ra mảng đã được sắp xếp
//            Console.WriteLine("\nMang sau khi sx:");
//            foreach (int num in numbers)
//                Console.Write(num + " ");
//            Console.ReadLine();
//        }
//    }
//}

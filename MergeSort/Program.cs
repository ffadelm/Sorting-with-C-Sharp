using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        int[] arr = new int[20];
        int max;
        void input()
        {
            while (true)
            {
                
                Console.Write("Masukkan jumlah Elemen : ");
                string y = Console.ReadLine();
                max = Int32.Parse(y);
                if (max <= 20)
                    break;
                else
                    Console.WriteLine("\nbatas array hanya 20\n");
            }

            Console.WriteLine("==============================================");

            for (int i = 0; i < max; i++)
            {
                Console.Write(" Masukkan Elemen [" + (i + 1).ToString() + "] : ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        static void MergeMethod(int [] arr, int left, int mid, int right)
        {
            // set j(left_end)  = i(mid)-1
            int[] temp = new int[20];
            int i, left_end, num_elemen, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elemen = (right - left + 1);

            while((left <= left_end) && (mid <= right))
            {
                if (arr[left] <= arr[mid])
                    temp[tmp_pos++] = arr[left++];
                else
                    temp[tmp_pos++] = arr[mid++];
            }
            while(left <= left_end)
                temp[tmp_pos++] = arr[left++];
            while (mid <= right)
                temp[tmp_pos++] = arr[mid++];
            for (i = 0; i < num_elemen; i++)
            {
                arr[right] = temp[right];
                right--;
            }

        }

        //right(low)
        //left(high)
        static void Sorting(int[] arr, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right+ left)/ 2;
                Sorting(arr, left, mid);
                Sorting(arr, (mid + 1), right);
                MergeMethod(arr, left, (mid + 1), right);
            }
        }

        void display()
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine(">>>>>>>>> Diurutkan dengan MergeSort <<<<<<<<<");
            Console.WriteLine("==============================================");
            Sorting(arr, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(" "+arr[i]);

            Console.Read();
        }
        
        int getSize()
        {
            return (max);
        }

        static void Main(string[] args)
        {
            Program ini = new Program();

            ini.input();
            ini.display();

        }
    }
}

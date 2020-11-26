class SortingNama
    {
        //membuat batas arr 26   
        string[] fay = new string[26];
        //deklarasi int max sebagai jumlah elemen dlam array
        int max;
                   
        void InputOutput()
        {
            //deklarasi pilih, ulang untuk mengulang menu pilihan
            int pilih;
            string ulang;
            ulang = "Y";

            while(ulang == "Y")
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Selamat Datang di Program Sorting Nama");
                Console.WriteLine("========================================\n");

                
                while (true)
                {
                    Console.Write(" Masukkan Jumlah Siswa : ");
                    string y = Console.ReadLine();
                    max = Int32.Parse(y);
                    if (max <= 26) //max tidak boleh lebih dari 26                 
                        break;
                    else
                        Console.WriteLine("\nbatas Maksimal Jumlah Siswa hanya 26\n");
                        Console.WriteLine("***************************************");
                }

                // buat arr dengan batas nilai max
                string[] fay = new string[max];
                Console.WriteLine("========================================");
                Console.WriteLine("Masukkan Nama Siswa : ");
                for (int i = 0; i < max; i++)
                {
                    // looping nama siswa
                    Console.Write((i + 1) + ". ");
                    //menyimpan elemen arr
                    fay[i] = Console.ReadLine();
                }

                //program switch case atau menu pilihan
                a://isi a 
                Console.WriteLine("\n >>>>> Pilihan Metode Sorting <<<<< ");
                Console.WriteLine("\n 1. Insertion Sort");
                Console.WriteLine(" 2. Merge Sort");
                Console.WriteLine(" 3. Exit");
                Console.Write(" Pilihan (1/2/3) : ");
                pilih = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (pilih)
                {
                    //case 1 berisi sorting insertion
                    case 1:
                        //proses insertion sorting 
                        InsertSort(fay, max);
                        //menampilkan elemen yang telah diurutkan
                        Tampil(fay, pilih);
                        break;

                    //case2 berisi sorting merge
                    case 2:
                        //proses Merge sorting 
                        //sekaligus menampilkan elemen yang telah diurutkan
                        Tampil(SortMerge(fay), pilih);
                        break;
                    // Exit
                    case 3:
                        return;
                    //Wrong input
                    default:
                        Console.WriteLine("Pilihan Salah !!!!");
                        Console.WriteLine("Masukkan pilihan 1-3");
                        Console.WriteLine("***************************************");
                        goto a;//untuk kembali ke a  
                }
                //pilihan untuk keluar konsol atau kembali kemenu
                Console.Write("\nKembali Kemenu ? (Y/T) : ");
                ulang = Console.ReadLine();
                //untuk menghapus 
                Console.Clear();
                

            }        
        }

        static string[] InsertSort(string[] fay, int max)
        {
            //deklarasi int i dan j
            int i, j;
            // 1. Repeat steps 2, 3, 4, and 5 varying i from 1 to n – 1 
            for (i = 1; i < max; i++)
            {
                // set temp
                string temp = fay[i];
                // Set j = i – 1
                j = i - 1;
                // Repeat until j becomes less than 0 or arr[j] becomes less than or equal to temp:
                while ((j >= 0) && (fay[j].CompareTo(temp) > 0))
                {
                    // Shift the value at index j to index j + 1
                    fay[j + 1] = fay[j];
                    // Decrement j by 1
                    j--;
                }
                // Store temp at index j + 1
                fay[j + 1] = temp;
            }
            return fay;
        }

        static string[] SortMerge(string[] fay)
        {
            // hitung nilai a
            int a = fay.Length;

            // Batasan rekursi / jika n <= 1, keluarkan array
            if (a <= 1) 
                return fay;

            // Menentukan nilai mid
            int mid = a / 2;

            // deklarasi arr A
            string[] fayA = new string[mid];

            // deklarasi arr B
            string[] fayB;

            if (a % 2 == 0)
            {
                fayB = new string[mid];
            }
            else
            {
                fayB = new string[mid + 1];
            }

            // Divide the list into two sublists of nearly equal lengths, and sort each sublist by using merge sort. The steps to do this are as follows:

            // Algorithm(low, mid) 
            for (int i = 0; i < mid; i++)
                fayA[i] = fay[i];

            fayA = SortMerge(fayA);

            // Algorithm(mid + 1, high) 
            for (int i = mid, x = 0; i < a; i++, x++)
            {
                fayB[x] = fay[i];
            }

            fayB = SortMerge(fayB);


            // Merge the two sorted sublists:
            return MainMerge(fayA, fayB);

        }

        static string[] MainMerge(string[] fayA, string[] fayB)
        {
            //set I,J,K
            int i = 0, FM = 0, k = 0;
            
            int n = fayB.Length + fayA.Length;

            string[] result = new string[n];

            //Repeat until i > len(arrA) or j > len(arrB): 
            while (i < fayA.Length || FM < fayB.Length)
            {
                if (i < fayA.Length && FM < fayB.Length)
                {
                    if (fayA[i][0] <= fayB[FM][0]) //If(arr[i] <= arr[j])
                    {
                        result[k] = fayA[i]; // Store arr[i] at index k in array B
                        i++; // Increment i by 1 
                    }
                    else
                    {
                        result[k] = fayB[FM]; // Store arr[j] at index k in array B
                        FM++; // Increment j by 1
                    }
                    k++; // Increment k by 1
                }
                else if (i < fayA.Length)
                {
                    result[k] = fayA[i]; //Store arr[j] at index k in array B
                    i++; //Increment j by 1
                    k++; //Increment k by 1
                }
                else if (FM < fayB.Length)
                {
                    result[k] = fayB[FM]; //Store arr[i] at index k in array B
                    FM++; //Increment I by 1
                    k++; //Increment k by 1
                }
            }
            return result;
        }

        void Tampil(String[] fay, int pilih)
        {
            if (pilih == 1)
            {
                // Output Insertion Sorting
                Console.WriteLine("\n==============================================");
                Console.WriteLine(">>>>>>>> Diurutkan dengan InsertSort <<<<<<<<");
                Console.WriteLine("=============================================");

                for (int i = 0; i < max; i++)
                {
                    Console.WriteLine((i + 1) + ". " + fay[i]);
                }
            }
            else if (pilih == 2)
            {
                // Output Merge Sorting
                Console.WriteLine("\n==============================================");
                Console.WriteLine(">>>>>>>>> Diurutkan dengan MergeSort <<<<<<<<<");
                Console.WriteLine("==============================================");
                
                for (int i = 0; i < max; i++)
                {
                    Console.WriteLine((i + 1) + ". " + fay[i]);
                }
            }
            
        }

        static void Main(string[] args)
        {
            SortingNama ini = new SortingNama();
            ini.InputOutput();

        }
    }

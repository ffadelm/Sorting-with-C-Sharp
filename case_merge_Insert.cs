class SortingNama
    {
        //deklarasi array dengan batas 26
        string[] fay = new string[26];
        //deklarasi int max sebagai jumlah elemen dlam array
        int max;
        void InputNama()
        {
            while (true)
            {
                Console.Write("Masukkan jumlah Elemen : ");
                string y = Console.ReadLine();
                max = Int32.Parse(y);
                if (max <= 26)
                    break;
                else
                    Console.WriteLine("\nMohon Maaf Batas Element Array Hanya 26\n");
            }

            Console.WriteLine("========================================");

            //menyimpan element array
            for (int i = 0; i < max; i++)
            {
                Console.Write(" Masukkan Nama ke [" + (i + 1) + "] : ");
                fay[i] = Console.ReadLine();
            }
                        
        }

        static string[] InsertSort(string[] fay,int max)
        {
            //deklarasi int i dan j
            int i, j;
            // 1. Repeat steps 2, 3, 4, and 5 varying i from 1 to n – 1 
            for (i = 1; i < max; i++)
            {
                // Menginisialisasi temp
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

        static public void MainMerge<T>(T[] values, int left, int mid, int right) where T : IComparable<T>
        {
            T[] temp = new T[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (values[left].CompareTo(values[mid])<1)
                    temp[pos++] = values[left++];
                else
                    temp[pos++] = values[mid++];
            }

            while (left <= eol)
                temp[pos++] = values[left++];

            while (mid <= right)
                temp[pos++] = values[mid++];

            for (i = 0; i < num; i++)
            {
                values[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge<T>(T[] values, int left, int right) where T : IComparable<T>
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(values, left, mid);
                SortMerge(values, (mid + 1), right);

                MainMerge(values, left, (mid + 1), right);
            }
        }

        void mergedisplay()
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine(">>>>>>>>> Diurutkan dengan MergeSort <<<<<<<<<");
            Console.WriteLine("==============================================");
            SortMerge(fay,0,max-1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(" " + fay[i]);

        }

        void insertdisplay()
        {
            Console.WriteLine("\n===================================================");
            Console.WriteLine(">>>>>>>>> Diurutkan dengan Insertion Sort <<<<<<<<<");
            Console.WriteLine("===================================================");
            
            //add elemen yang tersimpan dalam array agar di proses untuk sorting 
            //memanggil fungsi insertion sort
            InsertSort(fay,max);
            for (int i = 0; i < max; i++)
            Console.WriteLine(" " + fay[i]);
        }

        static void Main(string[] args)
        {
            //deklarasi objek kelas
            SortingNama ini = new SortingNama();

            int pilih;
            string ulang;
            ulang = "Y";
            
            //program case atau menu pilihan 
            while (ulang == "Y")
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Selamat Datang di Program Sorting Nama");
                Console.WriteLine("========================================");
                a://isi a 
                Console.WriteLine("\n Pilihan Metode Sorting : ");
                Console.WriteLine("\n 1. Insertion Sort");
                Console.WriteLine(" 2. Merge Sort");
                Console.WriteLine(" 3. Exit");
                Console.Write(" pilihan (1/2/3) : ");
                pilih = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (pilih)
                {
                    //case 1 berisi sorting insertion
                    case 1:
                        //menerima elemen array
                        ini.InputNama();
                        //menampilkan array yang di urutkan
                        ini.insertdisplay();
                        break;

                    //case2 berisi sorting merge
                    case 2:
                        //menerima elemen array
                        ini.InputNama();
                        ini.mergedisplay();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Pilihan Salah !!!!");
                        Console.WriteLine("Masukkan pilihan 1-3");
                        goto a;//untuk kembali ke a                                              
                }

                //pilihan untuk keluar konsol atau kembali kemenu
                Console.Write("\nKembali Kemenu ? (Y/T) : ");
                ulang = Console.ReadLine();
                Console.Clear(); //untuk menghapus ketika variable ulang di isi
            }
        }
    }

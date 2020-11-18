class Program
    {
        // array untuk menyimpan nilai
        private int[] arr = new int[20];

        //jumlah element dalam array
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Masukkan jumlah elemen dalam Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray hanya memiliki maximum 20 elemen\n");
            }

            Console.WriteLine("\n==========================");
            Console.WriteLine("Masukkan Elemen Array");
            Console.WriteLine("==========================");

            // menyimpan elemen array
            for(int i= 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        //menukar elemen pada indeks x dengan elemen pada indeks y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public void q_sort(int low, int high)
        {
            int pivot, i, j;

            if (low > high)
                return;
            

            // membagi 2 partisi yang terdaftar
            // 1 elemen <= pivot
            // elemen lain > pivot

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                // mencari elemen > pivot
                while((arr[i]<= pivot) && (i <= high))
                {
                    i++;
                }

                while((arr[j]>pivot)&&(j>= low))
                {
                    j--;
                }

                // jika elemen yang lebih besar, ada di sebelah kiri elemen yang lebih kecil
                if (i < j)
                {
                    // tukar elemen index i dengan elemen index j
                    swap(i, j);
                }
            }

            // j sekarang berisi indeks dari elemen terakhir dalam daftar yang diurutkan
            if (low < j)
            {
                // pindahkan pivot ke posisi yang benar dalam daftar
                swap(low, j);
            }

            // urutkan daftar di sebelah kiri pivot menggunakan pengurutan cepat
            q_sort(low, j - 1);

            // urutkan daftar di sebelah kanan pivot menggunakan pengurutan cepat
            q_sort(j + 1, high);
        }

        void display()
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("Mengurutkan Element Array");
            Console.WriteLine("==============================");

            for (int j= 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }

        int getSize()
        {
            return (n);
        }


        static void Main(string[] args)
        {
            // mendeklarasikan objek kelas
            Program MyList = new Program();

            // menerima elemen array
            MyList.read();
            //memanggil fungsi penyortiran
            //panggilan pertama ke algoritma pengurutan cepat
            MyList.q_sort(0, MyList.getSize() - 1);
            // menampilkan array yang diurutkan
            MyList.display();
            // untuk keluar dari konsol
            Console.WriteLine("\n \nTekan Enter untuk Keluar.");
            Console.Read();
        }
    }

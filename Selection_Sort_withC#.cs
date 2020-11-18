class Program
    {
        private int[] fay = new int[21];

        private int n;

        public void Input()
        {
            while (true)
            {
                string input;
                Console.Write("Masukkan Banyak Elemen Pada Array = ");
                input = Console.ReadLine();
                n = Convert.ToInt32(input);

                if (n <= 21)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nMaximum Array hanya 21 Elemen!!!!!\n");
                }
            }

            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine(" Input/Masukkan Elemen Array");
            Console.WriteLine("==============================");
            string inpArr;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemen Ke- " + (i + 1) + " = ");
                inpArr = Console.ReadLine();
                fay[i] = Convert.ToInt32(inpArr);
            }
        }


        public void Syarat()
        {
            int temp, min_index;
            for (int i = 0; i < n-1; i++)
            {
                min_index = i;
                for (int FM = i+1; FM < n; FM++)
                {
                    if (fay[FM] < fay[min_index])
                    {
                        min_index = FM;
                        
                    }
                }

                temp = fay[min_index];
                fay[min_index] = fay[i];
                fay[i] = temp;
            }
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("Elemen Array yang telah tersusun");
            Console.WriteLine("================================");

            for (int FM = 0; FM < n; FM++)
            {
                Console.WriteLine(fay[FM]);
            }
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            Program sort = new Program();
            sort.Input();
            sort.Syarat();
            sort.Output();

            Console.WriteLine("Tekan tombol apapun untuk keluar");
            Console.ReadKey();
        }
    }

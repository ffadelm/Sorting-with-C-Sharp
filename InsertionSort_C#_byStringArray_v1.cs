class SortingNama
    { 
        string[] fay = new string [5];
        private int max;        
        void InputNama()
        {
            
            while (true)
            {
                
                Console.Write("Masukkan jumlah Elemen : ");
                string y= Console.ReadLine();
                max = Int32.Parse(y);
                if (max <= 5) // batas 
                    break;
                else
                    Console.WriteLine("\nbatas array hanya 5\n");
            }                               
            
            Console.WriteLine("==============================================");

            for (int i = 0; i < max; i++)
            {
                Console.Write(" Masukkan Nama ke [" + (i + 1) + "] : ");
                fay[i] = Console.ReadLine();
            }

        }

        static string[] InsertSort(string[] fay)
        {
            int i, j;

            for (i = 1; i < fay.Length; i++)
            {
                string value = fay[i];
                j = i - 1;
                while ((j >= 0) && (fay[j].CompareTo(value) > 0))
                {
                    fay[j + 1] = fay[j];
                    j--;
                }
                fay[j + 1] = value;
            }
            return fay;

        }

        void display()
        {
            //insert sort
            Console.WriteLine("\n===================================================");
            Console.WriteLine(">>>>>>>>> Diurutkan dengan Insertion Sort <<<<<<<<<");
            Console.WriteLine("===================================================");
            InsertSort(fay);

            for (int i = 0; i < max; i++)
                Console.WriteLine(" " + fay[i]);
        }


        static void Main(string[] args)
        {
            SortingNama ini = new SortingNama();

            ini.InputNama();
           
            ini.display();

            Console.WriteLine("\n\nTekan enter untuk keluar........");
            Console.Read();
        }
    }

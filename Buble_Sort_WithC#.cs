class Program
{
    private int[] a = new int[20];

    private int n;

    public void read()
    {
        while (true)
        {
            Console.Write("Masukkan banyak elemen array = ");
            string s = Console.ReadLine();
            n = Convert.ToInt32(s);
            if (n <= 20)
                break;
            else
                Console.WriteLine("\nArray Hanya dapat menampung maximum 20 elemen.\n");
        }

        Console.WriteLine();
        Console.WriteLine("=============================");
        Console.WriteLine("    Masukkan Elemen Array");
        Console.WriteLine("=============================");

        for (int i = 0; i < n; i++)
        {
            Console.Write("<" + (i + 1) + "> ");
            string s1 = Console.ReadLine();
            a[i] = Convert.ToInt32(s1);
        }
    }

    public void display()
    {
        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("Element Array yang Telah Tersusun");
        Console.WriteLine("=================================");

        for(int j=0; j < n; j++)
        {
            Console.WriteLine(a[j]);
        }
        Console.WriteLine();
    }

    public void BubbleSortArray()
    {
        for (int i =1; i<n; i++)
        {
            for(int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp;
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Program list = new Program();

        list.read();
        list.BubbleSortArray();
        list.display();

        Console.WriteLine("\n\nTekan Tombol Apapun Untuk keluar Program");
        Console.Read();

    }


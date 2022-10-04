using System;

namespace BubbleShort
{
    class Program
    {
        //deklarassi array int dengan ukuran 20
        private int[] a = new int[20];

        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menetukan banyaknya data yang disimpan pada array
            while(true)
            {
                Console.Write("Masukkan banyaknya element Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 32)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("---------------------");

            //pengguna memasukkan element pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Element array yang telah tersusun ");
            Console.WriteLine("----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubblesortArray()
        {
            for (int i = 1; i < n; i ++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j] > a [j + 1])
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
            Program myList = new Program();

            myList.read();
            myList.BubblesortArray();
            myList.display();
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}

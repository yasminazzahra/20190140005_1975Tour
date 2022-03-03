using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1975_Tour
{
    /// <summary>
    /// Aplikasi perhitungan budget liburan
    /// </summary>
    class ProgramLiburan
    {
        /// <summary>
        /// Menu awal untuk memilih kota mana yang akan dikunjungi
        /// <remarks>Menggunakan Looping untuk menentukan kondisi yang akan dipilih </remarks>
        /// <value>
        /// <item>
        /// <description>Item 1 Kota Bali</description>
        /// </item>
        /// <item>
        /// <description>Item 2 Kota NTB</description>
        /// </item>
        /// <item>
        /// <description>Item 3 Kota NTT</description>
        /// </item>
        /// <item>
        /// <description>Item 4 Kota Kaltim</description>
        /// </item>
        /// </value>
        /// </summary>
        /// <param>kota yang dapat dipilih</param>
        /// <returns>Menampilkan destinasi wisata yang terdapat pada kota yang dipilih</returns>
        static void Main(string[] args)
        {
            //penamaan variabel untuk memanggil class
            Bali bb = new Bali();
            NusaTenggaraBarat nn = new NusaTenggaraBarat();
            NusaTenggaraTimur ll = new NusaTenggaraTimur();
            KalimantanTimur kk = new KalimantanTimur();

            //pendeklariasin variabel pilih dengan tipe data integer
            int pilih;

            //looping  untuk memilih kota yang diinginkan 
            while (true)
            {
                //untuk memilih statements apa yang akan dipilih
                try
                {
                    Console.WriteLine("Destinasi Wisata");
                    Console.WriteLine("---------");
                    Console.WriteLine("1.Bali");
                    Console.WriteLine("2.Nusa Tenggara Barat");
                    Console.WriteLine("3.Nusa Tenggara Timur");
                    Console.WriteLine("4.Kalimantan Timur");
                    Console.WriteLine("5.Keluar");
                    Console.Write("Pilih Lokasi Wisata Impianmu= ");
                    pilih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    //digunakan untuk memilih bagian mana yang akan dieksekusi
                    switch (pilih)
                    {
                        //pilihan pertama
                        case 1:
                            //memanggil method dari class
                            bb.TampilBali();
                            bb.PBali();
                            bb.TampilBudgetBali();
                            //untuk menghentikan operasi
                            break;
                        //pilihan kedua
                        case 2:
                            //memanggil method dari class
                            nn.TampilNTB();
                            nn.LNTB();
                            nn.TampilBudgetNTB();
                            //untuk menghentikan operasi
                            break;
                        //pilihan ketiga
                        case 3:
                            //memanggil method dari class
                            ll.TampilNTT();
                            ll.NNTT();
                            ll.TampilBudgetNTT();
                            //untuk menghentikan operasi
                            break;
                        //pilihan keempat
                        case 4:
                            //memanggil method dari class
                            kk.TampilKT();
                            kk.KKT();
                            kk.TampilBudgetKT();
                            //untuk menghentikan operasi
                            break;
                        //pilihan kelima
                        case 5:
                            //untuk keluar dari program
                            return;
                        default:
                            Console.WriteLine("Maaf Input Salah!");
                            break;
                    }
                }
                //Untuk memberi tahu bagian error
                catch (FormatException e)
                {
                    Console.WriteLine(" ", e.Message.ToString());
                }
            }
        }
    }
    /// <summary>
    /// Class yang akan tampil apabila sudah memilih item
    /// </summary>
    /// <param name="hari">Jumlah hari yang akan digunakan dalam operasi perkalian</param>
    /// <param name="malam">Jumlah malam yang akan digunakan dalam operasi perkalian</param>
    /// <returns>Hasil dari perkalian hari dan malam</returns>
    public class Bali
    {
        //pendeklarasian varibael
        public double hari, malam;
        //method untuk menampilkan tampilan wisata
        public void TampilBali()
        {
            Console.WriteLine("Berikut list tempat wisata di Bali yang kami rekomendasikan:");
            Console.WriteLine("a.Pura Luhur Uluwatu");
            Console.WriteLine("b.Seminyak");
            Console.WriteLine("c.Pantai Sanur");
            Console.WriteLine("d.Gunung Batur");
            Console.WriteLine("e.Mandala Wisata Wenara Wana");
            Console.WriteLine("f.Pura Ulun Danu Beratan Bedugul");
            Console.WriteLine("g.Pantai Kuta, Pantai Pandawa");
            Console.WriteLine("--Cek Budget Anda--");
        }
        //method untuk menginput jumlah hari dan malam
        public void PBali()
        {
            Console.Write("Masukkan Jumlah Hari= ");
            hari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Jumlah Malam= ");
            malam = Convert.ToDouble(Console.ReadLine());
        }
        //method untuk operasi aritmatika
        public double BudgetBali(double h, double m)
        {
            return h * 250000 + m * 50000;
        }
        //method untuk menampilkan hasil operasi aritmatika
        public void TampilBudgetBali()
        {
            Console.WriteLine("Total Budget yang Dibutuhkan= " + this.BudgetBali(hari, malam));
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Class yang akan tampil apabila sudah memilih item
    /// </summary>
    /// <param name="hari">Jumlah hari yang akan digunakan dalam operasi perkalian</param>
    /// <param name="malam">Jumlah malam yang akan digunakan dalam operasi perkalian</param>
    /// <returns>Hasil dari perkalian hari dan malam</returns>
    public class NusaTenggaraBarat
    {
        //pendeklarasian variabel
        public double hari, malam;
        //method untuk menampilkan tampilan wisata
        public void TampilNTB()
        {
            Console.WriteLine("Berikut list tempat wisata di Nusa Tenggara Barat yang kami rekomendasikan:");
            Console.WriteLine("a.Kepulauan Gili");
            Console.WriteLine("b.Gunung Rinjani");
            Console.WriteLine("c.Danau Segara Anak");
            Console.WriteLine("d.Pink Beach");
            Console.WriteLine("e.Tanjung Aan");
            Console.WriteLine("f.Pantai Mawun, Pantai Selong Belanak");
            Console.WriteLine("--Cek Berapa Budget yang Anda Butuhkan--");
        }
        //method untuk menginput jumlah hari dan malam
        public void LNTB()
        {
            Console.Write("Masukkan Jumlah Hari= ");
            hari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Jumlah Malam= ");
            malam = Convert.ToDouble(Console.ReadLine());
        }
        //method untuk operasi aritmatika
        public double BudgetNTB(double h, double m)
        {
            return h * 150000 + m * 25000;
        }
        //method untuk menampilkan hasil operasi aritmatika
        public void TampilBudgetNTB()
        {
            Console.WriteLine("Total Budget yang Dibutuhkan= " + this.BudgetNTB(hari, malam));
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Class yang akan tampil apabila sudah memilih item
    /// </summary>
    /// <param name="hari">Jumlah hari yang akan digunakan dalam operasi perkalian</param>
    /// <param name="malam">Jumlah malam yang akan digunakan dalam operasi perkalian</param>
    /// <returns>Hasil dari perkalian hari dan malam</returns>
    public class NusaTenggaraTimur
    {
        //pendeklarasian variabel
        public double hari, malam;
        //method untuk menampilkan tempat wisata
        public void TampilNTT()
        {
            Console.WriteLine("Berikut list tempat wisata di Nusa Tenggara Timur yang kami rekomendasikan:");
            Console.WriteLine("a.Taman Nasional Komodo");
            Console.WriteLine("b.Gunung Kelimutu");
            Console.WriteLine("c.Pantai Merah");
            Console.WriteLine("d.Gua Rangko");
            Console.WriteLine("e.Danau Kelimutu");
            Console.WriteLine("--Cek Budget Anda--");
        }
        //method untuk menginput jumlah hari dan malam
        public void NNTT()
        {
            Console.Write("Masukkan Jumlah Hari= ");
            hari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Jumlah Malam= ");
            malam = Convert.ToDouble(Console.ReadLine());
        }
        //method untuk operasi aritmatika
        public double BudgetNTT(double h, double m)
        {
            return h * 200000 + m * 75000;
        }
        //method untuk menampilkan hasil operasi aritmatika
        public void TampilBudgetNTT()
        {
            Console.WriteLine("Total Budget yang Dibutuhkan= " + this.BudgetNTT(hari, malam));
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Class yang akan tampil apabila sudah memilih item
    /// </summary>
    /// <param name="hari">Jumlah hari yang akan digunakan dalam operasi perkalian</param>
    /// <param name="malam">Jumlah malam yang akan digunakan dalam operasi perkalian</param>
    /// <returns>Hasil dari perkalian hari dan malam</returns>
    public class KalimantanTimur
    {
        //pendeklarasian variabel
        public double hari, malam;
        //method untuk menampilkan tempat wisata
        public void TampilKT()
        {
            Console.WriteLine("Berikut list tempat wisata di Kalimantan Timur yang kami rekomendasikan:");
            Console.WriteLine("a.Museum Mulawarman");
            Console.WriteLine("b.Pulau Kumala");
            Console.WriteLine("c.Jembatan Kukar");
            Console.WriteLine("d.Labuan Cermin");
            Console.WriteLine("e.Derawan");
            Console.WriteLine("f.Islamic Center Samarinda");
            Console.WriteLine("g.Pantai Beras Basah");
            Console.WriteLine("--Cek Budget Anda--");
        }
        //method untuk menginput jumlah hari dan malam
        public void KKT()
        {
            Console.Write("Masukkan Jumlah Hari= ");
            hari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Jumlah Malam= ");
            malam = Convert.ToDouble(Console.ReadLine());
        }
        //method untuk operasi aritmatika
        public double BudgetKT(double h, double m)
        {
            return h * 300000 + m * 100000;
        }
        //method untuk menampilkan hasil operasi aritmatika
        public void TampilBudgetKT()
        {
            Console.WriteLine("Total Budget yang Dibutuhkan= " + this.BudgetKT(hari, malam));
            Console.ReadKey();
        }
    }
}

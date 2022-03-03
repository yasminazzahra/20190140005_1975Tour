using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1975_Tour
{
    class ProgramLiburan
    {
        static void Main(string[] args)
        {
            Bali bb = new Bali();
            NusaTenggaraBarat nn = new NusaTenggaraBarat();
            NusaTenggaraTimur ll = new NusaTenggaraTimur();
            KalimantanTimur kk = new KalimantanTimur();

            int pilih;

            while (true)
            {
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
                    switch (pilih)
                    {
                        case 1:
                            bb.TampilBali();
                            bb.PBali();
                            bb.TampilBudgetBali();
                            break;
                        case 2:
                            nn.TampilNTB();
                            nn.LNTB();
                            nn.TampilBudgetNTB();
                            break;
                        case 3:
                            ll.TampilNTT();
                            ll.NNTT();
                            ll.TampilBudgetNTT();
                            break;
                        case 4:
                            kk.TampilKT();
                            kk.KKT();
                            kk.TampilBudgetKT();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Maaf Input Salah!");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(" ", e.Message.ToString());
                }
            }
        }
    }

    public class Bali
    {
        public double hari, malam;
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
        public void PBali()
        {
            Console.Write("Masukkan Jumlah Hari= ");
            hari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Jumlah Malam= ");
            malam = Convert.ToDouble(Console.ReadLine());
        }
        public double BudgetBali(double h, double m)
        {
            return h * 250000 + m * 50000;
        }
        public void TampilBudgetBali()
        {
            Console.WriteLine("Total Budget yang Dibutuhkan= " + this.BudgetBali(hari, malam));
            Console.ReadKey();
        }
    }
    public class NusaTenggaraBarat
    {
        public double hari, malam;
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
        public void LNTB()
        {
            Console.Write("Masukkan Jumlah Hari= ");
            hari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Jumlah Malam= ");
            malam = Convert.ToDouble(Console.ReadLine());
        }
        public double BudgetNTB(double h, double m)
        {
            return h * 150000 + m * 25000;
        }
        public void TampilBudgetNTB()
        {
            Console.WriteLine("Total Budget yang Dibutuhkan= " + this.BudgetNTB(hari, malam));
            Console.ReadKey();
        }
    }
    public class NusaTenggaraTimur
    {
        public double hari, malam;
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
        public void NNTT()
        {
            Console.Write("Masukkan Jumlah Hari= ");
            hari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Jumlah Malam= ");
            malam = Convert.ToDouble(Console.ReadLine());
        }
        public double BudgetNTT(double h, double m)
        {
            return h * 200000 + m * 75000;
        }
        public void TampilBudgetNTT()
        {
            Console.WriteLine("Total Budget yang Dibutuhkan= " + this.BudgetNTT(hari, malam));
            Console.ReadKey();
        }
    }
    public class KalimantanTimur
    {
        public double hari, malam;
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
        public void KKT()
        {
            Console.Write("Masukkan Jumlah Hari= ");
            hari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Jumlah Malam= ");
            malam = Convert.ToDouble(Console.ReadLine());
        }
        public double BudgetKT(double h, double m)
        {
            return h * 300000 + m * 100000;
        }
        public void TampilBudgetKT()
        {
            Console.WriteLine("Total Budget yang Dibutuhkan= " + this.BudgetKT(hari, malam));
            Console.ReadKey();
        }
    }
}

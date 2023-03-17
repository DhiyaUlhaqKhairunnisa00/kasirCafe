using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplikasi_Kasir
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class kasir cafe dapat melihat nama makan minum, hitung pembayaran kasir</remarks>

    public class kasir
    {
        /// <summary>
        /// deklarasi setiap variabel baik int dan string
        /// </summary>
        /// <param name="ns">untuk nasi goreng seafood</param>
        /// <param name="mg">untuk spagheti</param>
        /// <param name="mr">untuk steak beef</param>
        /// <param name="na">untuk french fries</param>
        /// <param name="ap">untuk air mineral</param>
        /// <param name="tp">untuk ice cappucino</param>
        /// <param name="et">untuk es teler</param>
        /// <param name="ch">untuk ice brown sugar</param>
        /// <param name="cc">untuk ice hazelnut</param>
        /// <returns>hasil dari nama nama makanan dan minuman</returns>

        int ns = 35000, mg = 25000, mr = 55000, na = 18000;
        int ap = 7000, tp = 18000, et = 30000, ch = 20000, cc = 18000;
        int s, g, r, a, Ngrn, Mgrn, MR, NA;
        /// <summary>
        /// 
        /// </summary>
        ///  <returns>untuk proses pembayaran makanan </returns>
        
        int p, t, e, h, c, Nap, Ntp, Net, Nch, Ncc;
        /// <summary>
        /// 
        /// </summary>
        ///  <returns>untuk proses pembayaran minhuman </returns>
        string name, pilih, jml, costumer;
        /// <summary>
        /// 
        /// </summary>
        /// <returns>untuk ketika melakukan transaksi nama kasir, pilih makanan jumlah dan costumer</returns>
        int pass, code, total, bayar, tunai;
        /// <summary>
        /// <param name="pass">untuk password</param>
        /// <param name="code">untuk kode makanan dan minuman yang dipilih</param>
        /// <param name="total">untuk total yang dibeli</param> 
        /// <param name="bayar">untuk untuk masukkan jumlah bayar</param>
        /// <param name="tunai">untuk ketika menghitung kembalian</param>
        /// </summary>
        /// <returns>hasil untuk proses pembayaran kasir</returns>
        public void login()
        {//perlulangan di while
            do
            {
                //menampilkan halaman login
                Console.WriteLine("LOGIN KASIR");
                Console.WriteLine("=================");
                //input nama kasir
                Console.Write("Masukan Nama Anda : ");
                name = Console.ReadLine();
                //input password
                Console.Write("PASSWORD : ");
                pass = Convert.ToInt32(Console.ReadLine());
                //statemend passowrd benar atau salah
                if (pass == 041102)
                {
                    //jika benar maka akan langsung ke menu kasir
                    Console.WriteLine("=================================");
                    Console.WriteLine("Anda Berhasil untuk Login");
                    Console.WriteLine("Tekan Keyboard Mana Saja Untuk Meneruskan");
                    Console.ReadKey();
                }
                else
                {
                    //jika salah maka akan keluar atau mengulang
                    Console.WriteLine("=================================");
                    Console.WriteLine("Passowrd Yang Anda Masukkan Salah !!!! ");
                    //input pilihan
                    Console.Write("ketik 'Y' untuk mengulang ketik 'X' untuk exit : ");
                    pilih = Console.ReadLine();
                    if (pilih == "X")
                    {
                        Environment.Exit(0);
                    }
                }
                Console.Clear();

            } while (pilih == "Y");
        }
        public void menu()
        {
            //menampilkan pilihan menu
            Console.WriteLine("IN THE DOOR CAFE");
            Console.WriteLine("===================================");
            Console.WriteLine("===================================");
            Console.WriteLine("Menu dan Kode Makanan/Minuman");
            Console.WriteLine("===================================");
            Console.WriteLine("A. Makanan");
            Console.WriteLine("801 Nasi goreng Seafood\t\tRp 35.000");
            Console.WriteLine("802 Spagheti\t\tRp 25.000");
            Console.WriteLine("803 Steak Beef\t\tRp 55.000");
            Console.WriteLine("804 French Fries\t\tRp 18.000");
            Console.WriteLine("===================================");
            Console.WriteLine("B. Minuman");
            Console.WriteLine("405 Air Mineral\t\tRp 7.000");
            Console.WriteLine("406 Ice Cappuchino\t\tRp 18.000");
            Console.WriteLine("407 Es Teler\t\tRp 30.000");
            Console.WriteLine("408 Ice Brown Sugar Boba\t\tRp 20.000");
            Console.WriteLine("409 Ice Hazelnut Milk\tRp 18.000");
            Console.WriteLine("===================================");
            Console.WriteLine("2211 = Untuk menghitung belanja ");
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();
            //input nama pembeli
            Console.Write("Masukan nama costumer : ");
            costumer = Console.ReadLine();

        }
        //method kode dan perhitungan
        public void kode()
        {

            //perulangan do while
            do
            {
                //memasukan kode makanan atau minuman yg di pesan
                Console.Write("Masukan Kode Makanan/Minuman/Hitung : ");
                code = Convert.ToInt32(Console.ReadLine());
                if (code == 801)
                {
                    //memasukan jumlah makanan yang di beli dan perhitungan
                    Console.Write("Masukan Jumlah Makanan yang di Beli : ");
                    s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Ngrn = s * ns;


                }
                if (code == 802)
                {
                    //memasukan jumlah makanan yang di beli dan perhitungan
                    Console.Write("Masukan Jumlah Makanan yang di Beli : ");
                    g = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Mgrn = g * mg;


                }
                if (code == 803)
                {
                    //memasukan jumlah makanan yang di beli dan perhitungan
                    Console.Write("Masukan Jumlah Makanan yang di Beli : ");
                    r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    MR = r * mr;


                }
                if (code == 804)
                {
                    //memasukan jumlah makanan yang di beli dan perhitungan
                    Console.Write("Masukan Jumlah Makanan yang di Beli : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    NA = a * na;


                }
                if (code == 405)
                {
                    //memasukan jumlah makanan yang di beli dan perhitungan
                    Console.Write("Masukan Jumlah Minuman yang di Beli : ");
                    p = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Nap = p * ap;
                }
                if (code == 406)
                {

                    Console.Write("Masukan Jumlah Minuman yang di Beli : ");
                    t = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Ntp = t * tp;
                }
                if (code == 407)
                {
                    //memasukan jumlah makanan yang di beli dan perhitungan
                    Console.Write("Masukan Jumlah Minuman yang di Beli : ");
                    e = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Net = e * et;
                }
                if (code == 408)
                {

                    Console.Write("Masukan Jumlah Minuman yang di Beli : ");
                    h = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Nch = h * ch;
                }
                if (code == 409)
                {
                    //memasukan jumlah makanan yang di beli dan perhitungan
                    Console.Write("Masukan Jumlah Minuman yang di Beli : ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Ncc = c * cc;
                }
                else if (code == 2211)
                {
                    //jika kode di pilih 2211 maka akan menampilkan makanan dan minuman yang di pilih serta pembayaran
                    Console.Clear();
                    Console.WriteLine("pembelian");
                    Console.WriteLine("Makanan");
                    Console.WriteLine($"{s} Nasi Goreng Seafood \t\t = Rp." + string.Format("{0:n}", Ngrn));
                    Console.WriteLine($"{g} Spagheti  \t\t = Rp." + string.Format("{0:n}", Mgrn));
                    Console.WriteLine($"{r} Steak Beef  \t\t = Rp." + string.Format("{0:n}", MR));
                    Console.WriteLine($"{a} French Fries \t\t = Rp." + string.Format("{0:n}", NA));
                    Console.WriteLine("Minuman");
                    Console.WriteLine($"{p} Air Mineral \t\t = Rp." + string.Format("{0:n}", Nap));
                    Console.WriteLine($"{t} Ice Cappuchino\t\t = Rp." + string.Format("{0:n}", Ntp));
                    Console.WriteLine($"{e} Es Teler \t\t = Rp." + string.Format("{0:n}", Net));
                    Console.WriteLine($"{h} Ice Brown Sugar Boba \t\t = Rp." + string.Format("{0:n}", Nch));
                    Console.WriteLine($"{c} Ice Hazelnut Milk\t = Rp." + string.Format("{0:n}", Ncc));
                    total = Ngrn + Mgrn + MR + NA + Nap + Ntp + Net + Nch + Ncc;
                    Console.WriteLine("Total  = " + string.Format("{0:n}", total));
                    Console.Write("Masukan Jumlah Bayar : ");
                    bayar = Convert.ToInt32(Console.ReadLine());
                    tunai = bayar - total;
                    Console.WriteLine($"Kembalian \t= " + string.Format("{0:n}", tunai));
                    Console.WriteLine("Tekan Enter untuk Melihat dan Mencetak Struk");
                }

            } while (code != 2211);
            Console.ReadKey();
            //untuk close program
            Console.Clear();
        }
        public void tampil()
        {
            //menampilkan struk hasil belannja
            Console.WriteLine("\t\tIN THE DOOR CAFE");
            Console.WriteLine("==================================================");
            Console.WriteLine("==================================================");
            //menampilkan tanggal belanja
            string tgl = DateTime.Now.ToString("dd//MM//yyyy");
            //menampilkan waktu belanja
            Console.WriteLine("Tanggal : " + tgl);
            string waktu = DateTime.Now.ToString("hh:mm:ss");
            //menampilkan kesuluruhan makanan atau minuman yang di pesan
            Console.WriteLine("Waktu   : " + waktu);
            Console.WriteLine("Pembeli : " + costumer);
            Console.WriteLine("Kasir   : " + name);
            Console.WriteLine("===================================================");
            Console.WriteLine("Makanan/Minuman\tQTY\tHarga satuan\tHarga total");
            Console.WriteLine($"Nasi Goreng Seafood\t{s}\tRp. 35.000 \t Rp." + string.Format("{0:n}", Ngrn));
            Console.WriteLine($"Spagheti\t{g}\tRp. 25.000 \t Rp." + string.Format("{0:n}", Mgrn));
            Console.WriteLine($"Steak Beef\t{r}\tRp. 55.000 \t Rp." + string.Format("{0:n}", MR));
            Console.WriteLine($"French Fries\t{a}\tRp. 18.000 \t Rp." + string.Format("{0:n}", NA));
            Console.WriteLine($"Air Mineral\t{p}\tRp. 7.000 \t Rp." + string.Format("{0:n}", Nap));
            Console.WriteLine($"Ice Cappuchino\t{t}\tRp. 18.000 \t Rp." + string.Format("{0:n}", Ntp));
            Console.WriteLine($"Es Teler\t\t{e}\tRp. 30.000 \t Rp." + string.Format("{0:n}", Net));
            Console.WriteLine($"Ice Brown Sugar Boba\t{h}\tRp. 20.000 \t Rp." + string.Format("{0:n}", Nch));
            Console.WriteLine($"Ice Hazelnut Milk\t{c}\tRp  18.000 \t Rp." + string.Format("{0:n}", Ncc));
            Console.WriteLine("\t\t\t-----------------------------");
            Console.WriteLine("\t\t\tHARGA JUAL  :\tRp." + string.Format("{0:n}", total));
            Console.WriteLine("\t\t\t-----------------------------");
            Console.WriteLine("\t\t\tTOTAL       :\tRp." + string.Format("{0:n}", total));
            Console.WriteLine("\t\t\tTUNAI       :\tRp." + string.Format("{0:n}", bayar));
            Console.WriteLine("\t\t\tKEMBALI     :\tRp." + string.Format("{0:n}", tunai));
            Console.WriteLine("\t\tTerima kasih atas pesanan Anda di toko kami. Ditunggu orderan berikutnya. Please enjoy it more ya~");
            Console.WriteLine("");
            //program penyimpanan serta print
            try
            {
                Console.WriteLine("Simpan Nota dan Print nota di NotePad ");
                //membuat nama file yang di inginkan
                Console.Write("Masukan Nama file : ");
                string namaFile = Console.ReadLine();
                //membuat stream writer untuk menyimpan program serta peletakan progam
                StreamWriter SW = new StreamWriter("D:\\" + namaFile + ".txt");
                //bagian ini kebawah untuk menampilkan apa yang akan di simpan nantinya
                SW.WriteLine("\t\tIN THE DOOR CAFE");
                SW.WriteLine("==================================================");
                SW.WriteLine("==================================================");
                SW.WriteLine("Tanggal : " + tgl);
                SW.WriteLine("Waktu   : " + waktu);
                SW.WriteLine("Kasir   : " + name);
                SW.WriteLine("Pembeli : " + costumer);
                SW.WriteLine("===================================================");
                SW.WriteLine("Makanan/Minuman\tQTY\tHarga satuan\tHarga total");
                SW.WriteLine($"Nasi Goreng Seafood\t{s}\tRp. 35.000 \t Rp." + string.Format("{0:n}", Ngrn));
                SW.WriteLine($"Spagheti\t{g}\tRp. 25.000 \t Rp." + string.Format("{0:n}", Mgrn));
                SW.WriteLine($"Steak Beef \t{r}\tRp. 55.000 \t Rp." + string.Format("{0:n}", MR));
                SW.WriteLine($"French Fries\t{a}\tRp. 18.000 \t Rp." + string.Format("{0:n}", NA));
                SW.WriteLine($"Air Mineral \t\t{p}\tRp. 7.000 \t Rp." + string.Format("{0:n}", Nap));
                SW.WriteLine($"Ice Cappuchino\t{t}\tRp. 18.000 \t Rp." + string.Format("{0:n}", Ntp));
                SW.WriteLine($"Es Teler\t\t{e}\tRp. 30.000 \t Rp." + string.Format("{0:n}", Net));
                SW.WriteLine($"Ice Brown Sugar Boba\t{h}\tRp. 20.000 \t Rp." + string.Format("{0:n}", Nch));
                SW.WriteLine($"Ice Hazelnut Milk\t{c}\tRp  18.000 \t Rp." + string.Format("{0:n}", Ncc));
                SW.WriteLine("\t\t\t-----------------------------");
                SW.WriteLine("\t\t\tHARGA JUAL  :\tRp." + string.Format("{0:n}", total));
                SW.WriteLine("\t\t\t-----------------------------");
                SW.WriteLine("\t\t\tTOTAL       :\tRp." + string.Format("{0:n}", total));
                SW.WriteLine("\t\t\tTUNAI       :\tRp." + string.Format("{0:n}", bayar));
                SW.WriteLine("\t\t\tKEMBALI     :\tRp." + string.Format("{0:n}", tunai));
                SW.WriteLine("\tTerima kasih atas pesanan Anda di toko kami. Ditunggu orderan berikutnya. Please enjoy it more ya~");
                //untuk close
                SW.Close();

            }
            //program apabila salah dalam melakukan penyimpanan
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            //digunakan untuk menampilkan pesan jika data kita sudah tersimpan
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Anda bisa print data tersebut memalui Notepad");
                Console.WriteLine("Lokasi penyimpanan ada di folder D:");
                Console.WriteLine("penyimpanan Sukses !!!!");
                Console.WriteLine("==============================================");
            }
            Console.ReadKey();
        }
        //class untuk menjalankan progra
        class Program
        {
            static void Main(string[] args)
            {
                //membuat objek baru untuk kelas
                kasir ks = new kasir();
                //objek untuk setiap mentod
                ks.login();
                //deklarasi
                string pilih;
                //perulangan do while
                do
                {
                    //akan melakukan perulangan pada program apa bila kita ingin menghitung belanja lagi
                    ks.menu();
                    ks.kode();
                    ks.tampil();
                    Console.Write("ketik 'Y' untuk mengulang dan klik enter untuk exit : ");
                    pilih = Console.ReadLine();
                    Console.Clear();
                } while (pilih == "Y");

            }
        }
    }
}
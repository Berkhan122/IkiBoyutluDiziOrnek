using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkiBoyutluDiziOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Öğrenci sayısı giriniz:");
            byte satir = byte.Parse(Console.ReadLine());
            String[,] ogrenciler = new string[satir + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize Notu";
            ogrenciler[0, 3] = "Final Notu";
            ogrenciler[0, 4] = "Ortalaması";
            ogrenciler[0, 5] = "Harf Notu";

            byte vize = 0, final = 0;
            int ogrort = 0;
            string ogrhrf;
            ogrhrf = HarfNotu(ogrort);
            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write("Öğrenci Adı giriniz:");
                            break;
                        case 1:
                            Console.Write("Öğrenci Soyadı giriniz:");
                            break;
                        case 2:
                            Console.Write("Öğrenci Vize Notu giriniz:");
                            vize = byte.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("Öğrenci Final Notu giriniz:");
                            final = byte.Parse(Console.ReadLine());
                            break;
                        case 4:
                            ogrort = OgrOrt(vize, final);
                            Console.Write("Öğrenci Ortalaması:" + ogrort);
                            break;
                        case 5:
                            ogrhrf = HarfNotu(ogrort);
                            Console.Write("Öğrenci Harf Notu:" + ogrhrf);
                            break;
                        default:
                            break;

                    }
                    ogrenciler[i, j] = Console.ReadLine();
                }

            }

            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
        /// <summary>
        /// /Öğrenci Ortalamasını Vize notunun %40'ını, Final notunun %60'ını hesaplayarak döndüren metod.
        /// </summary>
        /// <param name="vize40"></param>
        /// <param name="final60"></param>
        /// <returns></returns>
        static int OgrOrt(byte vize40, byte final60)
        {
            int ortalama = vize40 * 40 / 100 + final60 * 60 / 100;
            return ortalama;
        }

        /// <summary>
        /// Hesaplanan öğrenci ortalaması ile Harf Notu ve 4.00'lük sistemde karşılıklarını döndüren metod.
        /// </summary>
        /// <param name="ort"></param>
        /// <returns></returns>
        static string HarfNotu(int ort)
        {
            if (ort == 100 || ort >= 90)
            {
                return "AA \t 4.00";
            }
            else if (ort == 89 || ort >= 85)
            {
                return "BA \t 3.50";
            }
            else if (ort == 84 || ort >= 80)
            {
                return "BB \t 3.25";
            }
            else if (ort == 79 || ort >= 75)
            {
                return "CB \t 3.00";
            }
            else if (ort == 74 || ort >= 70)
            {
                return "CC \t 2.75";
            }
            else if (ort == 69 || ort >= 65)
            {
                return "DC \t 2.50";
            }
            else if (ort == 64 || ort >= 60)
            {
                return "DD \t 2.00";
            }
            else if (ort == 59 || ort >= 50)
            {
                return "FD \t 1.50";
            }
            else if (ort == 49 || ort <= 40)
            {
                return "FF \t 0.00";
            }
            return "1";
        }
    }

}


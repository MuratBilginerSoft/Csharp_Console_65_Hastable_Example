using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            string EN;
            string TR;
            int Process;
            int KB;
            int KA;
            int KC;
            int I1;
            int I2;
            int I3;
            string Word1, Word2;
            int a = 0;

            bool Status = false;

        AnaMenu:

            Console.Clear();

            Console.WriteLine("Ne Yapmak İstiyorsunuz? 1 Kelime Gir 2 Kelime Bak");
            Process = int.Parse(Console.ReadLine());

            #region Kelime Gir

            if (Process == 1)
            {
            KelimeGir:

                Console.Clear();

                Console.Write("İngilizce Değeri Giriniz: ");
                EN = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Türkçe Anlamını Giriniz: ");
                TR = Console.ReadLine();

                Status = H1.ContainsKey(EN);

                if (Status == true)
                {
                    Console.WriteLine("Bu değer girilmiştir.");
                }

                else
                {
                    H1.Add(EN, TR);

                    Console.WriteLine();
                    Console.Write("Kelime Eklenmiştir");
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Ne Yapmak İstiyorsunuz: 1 Ana Menü 2 Yeni Kelime Ekle");
                KC = int.Parse(Console.ReadLine());

                if (KC==1)
                {
                    goto AnaMenu;
                }

                else if (KC == 2)
                {
                    goto KelimeGir;
                }
            }

            #endregion

            #region Kelime Bak

            else if (Process == 2)
            {

                Console.WriteLine("1 Tek Tek Kelime Bak 2 Tüm Kelimelere Bak");
                KB = int.Parse(Console.ReadLine());

                if (KB == 1)
                {

                KelimeBak:

                    Console.Clear();

                    Console.WriteLine("1 Index Numarası İle Ara 2 Kelime Ara");
                    KA = int.Parse(Console.ReadLine());

                    if (KA == 1)
                    {
                    IndexleBak:

                        Console.Clear();

                        ArrayList EL = new ArrayList(H1.Keys);
                        ArrayList TL = new ArrayList(H1.Values);

                        Console.Write("Index Numarası Giriniz: ");
                        I1 = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (I1<= TL.Count)
                        {
                            Console.WriteLine(I1 + ". Kelime : " + EL[I1] + " : " + TL[I1]);

                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("Belirttiğiniz Index'te Bir Kelime Yoktur.");
                        }

                        Console.WriteLine();

                        Console.Write("1 Ana Menü 2 Kelime Bak 3 Devam: ");

                        I2 = int.Parse(Console.ReadLine());

                        if (I2 == 1)
                        {
                            goto AnaMenu;
                        }

                        else if (I2 == 2)
                        {
                            goto KelimeBak;
                        }

                        else if (I2 == 3)
                        {
                            goto IndexleBak;
                        }
                    }

                    else if (KA==2)
                    {
                    KelimeAra:

                        Console.Clear();

                        Console.WriteLine("1 TR Kelime Bak 2 EN Kelime Bak");
                        I3 = int.Parse(Console.ReadLine());

                        if (I3 == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Kelimeyi Giriniz : ");
                            Word1 = Console.ReadLine();

                            Console.WriteLine();

                            ArrayList AL2 = new ArrayList(H1.Values);
                            ArrayList AL3 = new ArrayList(H1.Keys);
                            

                            if (H1.ContainsValue(Word1))
                            {
                                a = 0;

                                foreach (object item in AL2)
                                {
                                    if (item.ToString() == Word1)
                                    {
                                        break;
                                    }

                                    a++;
                                }

                                Console.Write(Word1 + " : " + AL3[a]);
                            }

                            else
                            {
                                Console.WriteLine();

                                Console.WriteLine("Aradığınız Kelime Sözlükte Mevcut Değildir.");
                            }

                           
                        }

                        else if (I3 == 2)
                        {
                            Console.WriteLine();
                            Console.Write("Kelimeyi Giriniz : ");
                            Word2 = Console.ReadLine();

                            Console.WriteLine();

                            if (H1.ContainsKey(Word2))
                            {
                                Console.Write(Word2 + " : " + H1[Word2]);
                            }

                            else
                            {
                                Console.WriteLine();

                                Console.WriteLine("Aradığınız Kelime Sözlükte Mevcut Değildir.");
                            }

                        }

                        Console.WriteLine();

                        Console.Write("1 Ana Menü 2 Kelime Bak 3 Devam: ");

                        I2 = int.Parse(Console.ReadLine());

                        if (I2 == 1)
                        {
                            goto AnaMenu;
                        }

                        else if (I2 == 2)
                        {
                            goto KelimeBak;
                        }

                        else if (I2 == 3)
                        {
                            goto KelimeAra;
                        }

                    }

                }

            }

            #endregion




        }
    }
}

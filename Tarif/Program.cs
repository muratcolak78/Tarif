using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Tarif
{
    internal class Program
    {
        static Mobil[] mobilList = makeMobilList();
        static Festnetz[] festnetzList=makeFestList ();

        
        static void Main(string[] args)
        {
            main();
        }

            static void PrintList(Object[] liste)
            {
                Console.WriteLine("================================Tarif List ========================================");
                Console.WriteLine($"Bezeichnung\tBasispreis\tFreiminuten\tMinutenpreis\tDigital möglich");
                if (liste is Mobil[])
                {
                    Mobil[] list = (Mobil[])liste;
                    for (int i = 0; i < list.Length; i++)
                    {
                        Console.WriteLine($"M{i + 1}: {list[i].Bezeichnug}\t{list[i].BasisPreis}\t\t{list[i].FreiMinuten}\t\t{list[i].MinutenPreis}\t\t{list[i].DijitalMöglich} GB");
                    }
                    Console.WriteLine();
                }
                else if (liste is Festnetz[]) {
                    Festnetz[] list = (Festnetz[])liste;
                    for (int i = 0; i < list.Length; i++)
                    {
                        String digitalM = "";
                        if (list[i].DijitalMöglich) digitalM = "ja"; else digitalM = "nein";
                        Console.WriteLine($"F{i + 1}: {list[i].Bezeichnug}\t{list[i].BasisPreis}\t\t{list[i].FreiMinuten}\t\t{list[i].MinutenPreis}\t\t{digitalM}");
                    }
                    Console.WriteLine();
                }
            }
            static Mobil[] makeMobilList()
            {
                mobilList = new Mobil[3];
                mobilList[0] = new Mobil("Basis", 29.95, 0, 0.25, 1);
                mobilList[1] = new Mobil("Advanced", 35.95, 180, 0.25, 2);
                mobilList[2] = new Mobil("Elite", 59.95, 1440, 0.15, 4);
                return mobilList;
            }
            static Festnetz[] makeFestList()
            {
                festnetzList = new Festnetz[3];
                festnetzList[0] = new Festnetz("Basis", 19.95, 0, 0.10, false);
                festnetzList[1] = new Festnetz("Advanced", 24.95, 180, 0.10, true);
                festnetzList[2] = new Festnetz("Elite", 49.95, 1440, 0.05, true);
                return festnetzList;
            }
            static void main()
            {
                while (true)
                {


                    Console.WriteLine("Mobil hatlarla ilgili bilgi edinmek için (M)");
                    Console.WriteLine("Sabit hatlarl ilgili bilgi edinmek için (F)");
                    Console.WriteLine("Sizin için en uygun tarifi hesaplamak için (R)");
                    Console.WriteLine("Çıkmak için (X)");
                    string wahl = Console.ReadLine().ToLower();
                    if (wahl != "x")
                    {
                        if (wahl == "m")
                        {
                            PrintList(mobilList);
                        }
                        else if (wahl == "f")
                        {
                            PrintList(festnetzList);
                        }else if (wahl == "r")
                        {
                            Berechnung();
                        }else Console.WriteLine("lütfen M, F veya R tuşalayınız");
                    }
                    else break;
                }
            }
            static void Berechnung()
            {
                                 
                    PrintList(mobilList);
                    PrintList(festnetzList);
                    Mobil tarif; Festnetz tarif2;
                    bool exit = false;
                    double preis = 0;
                    while (!exit)
                    {
                        Console.WriteLine("Wieviele Minuten telefonieren Sie im Monat");
                        string einGegeben = Console.ReadLine();
                        int minute = 0;
                        if (int.TryParse(einGegeben, out minute))
                        {
                                bool exit2 = false;
                                while (!exit2)
                            {
                                Console.WriteLine("Bitte geben Sie den Tarifcode ein, den Sie kaufen möchten");

                                string tarifCode = Console.ReadLine().ToLower();

                                if (tarifCode == "m1") { 
                            tarif = mobilList[0];
                            preis = tarif.berechnung(minute);
                            exit = true;
                            exit2 =true;
                        
                        }
                                else if (tarifCode == "m2") {
                            tarif = mobilList[1];
                            preis = tarif.berechnung(minute);
                            exit = true;
                            exit2 = true;
                        }

                                else if (tarifCode == "m3") {
                            tarif = mobilList[2];
                            preis = tarif.berechnung(minute);
                            exit = true;
                            exit2 = true;
                        }

                                else if (tarifCode == "f1") { 
                            tarif2 = festnetzList[0]; 
                            preis = tarif2.berechnung(minute);
                            exit = true;
                            exit2 = true;}

                                else if (tarifCode == "f2") {
                            tarif2 = festnetzList[1];
                            preis = tarif2.berechnung(minute);
                            exit = true;
                            exit2 = true;
                        }

                                else if (tarifCode == "f3") {
                            tarif2 = festnetzList[2];
                            preis = tarif2.berechnung(minute);
                            exit = true;
                            exit2 = true;
                        }

                                else Console.WriteLine("yanlış kodlama yapınız.");
                            }
                        }
                        else Console.WriteLine("lütfen sayı griniz");
                    }
            Console.WriteLine( preis);


        }
        }
    }


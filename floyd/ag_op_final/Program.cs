using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ag_op_final
{
    class Program
    {
        static void Main(string[] args)
        {

            int nokta_sayisi = 25;
            int inf = 1111;
            int sutun = 0;

            int[,] matris = new int[25, 25] {   {0 ,inf,  12,  9,   inf,  inf,  7,   inf,  17,  inf,  inf,  inf,  inf, inf,  inf,  inf,  inf, 65,  inf,  inf, inf,  inf, inf,  inf,  inf},    //çankaya 1
                                                {inf, 0,   8,   inf,  23,  inf,  6,   12,  inf,  inf,  inf,  55,  inf, inf,  inf,  inf,  inf, inf,  inf,  inf, inf,  inf, inf,  inf,  inf },   //Keçiören 2
                                                {12 ,8,0,inf,  19,24, inf ,inf , 21, 81, inf, inf, inf, 76, inf, inf, inf, inf,  inf,  inf, inf,  inf,  inf,  inf,  inf },           //Yenimahalle 3
                                                {9,inf, inf,0,inf,  inf,  6,inf,  inf, inf, inf, inf, inf, inf, 34, inf, inf, 78,  inf,  inf, inf,  inf, inf,  inf,  inf },          //Mamak 4
                                                {inf ,23 ,19 ,inf,0,8 ,inf, inf ,inf,inf, inf ,inf ,inf , inf, inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf, inf },          //Etimesgut 5
                                                {inf,inf, 24, inf, 8,0, inf, inf,  inf,  72,  inf,  37,  inf,  inf,  inf,  inf,  inf, inf , inf,  inf, 36,  inf,  inf,  inf,  inf },   //Sincan 6
                                                {7 , 6 ,inf ,6  ,inf ,inf,0,14 ,inf ,inf ,inf ,inf ,inf ,inf ,42 ,34 ,inf ,inf ,inf ,inf ,inf, inf ,inf ,inf , inf },                         //Altındağ 7                                            
                                                {inf, 12, inf, inf, inf, inf, 14,0, inf, inf,29, 53, inf, inf , inf,  23, inf, inf,  inf,  inf, inf,  inf,  inf,  inf, inf },          //Pursaklar 8
                                                {17,inf , 21  ,inf  ,inf  ,inf  ,inf  ,inf,0, 85 , inf , inf  ,inf ,56 , inf  ,inf  ,inf ,48 , inf,inf ,inf  ,inf, inf, inf, inf},          //Gölbaşı 9
                                                {inf ,inf,81,  inf,  inf,  72, inf, inf, 85,0, inf, inf, 103, 42,  inf, inf, inf, inf, inf, inf, 74,  inf, inf, inf , inf },          //Polatlı 10
                                                {inf ,inf  ,inf  ,inf  ,inf , inf , inf , 29 , inf ,inf,0,38  ,inf ,inf ,inf  ,16  ,inf ,inf ,68 ,inf ,inf , inf, 49,inf, inf },          //Çubuk 11
                                                {inf, 55 , inf,  inf,  inf,  37,  inf,  53,  inf,  inf, 38,0, inf,  inf, inf,  inf,  inf, inf, 33,  inf, 46,  inf,  inf,  inf,  inf },    //Kahramankazan 12
                                                {inf, inf, inf , inf, inf , inf , inf, inf, inf ,103 ,inf ,inf,0,inf ,inf ,inf ,inf ,inf ,inf  ,60  ,43  ,93  ,inf, 33,inf },        //Beypazarı 13
                                                {inf, inf,  76,  inf,  inf,  inf,  inf,  inf,  56,  42,  inf, inf, inf, 0,inf, inf, inf, 107, inf, inf, inf, inf, inf, inf, inf },     //Haymana 14
                                                {inf ,inf  ,inf  ,34  ,inf  ,inf  ,42  ,inf  ,inf  ,inf ,inf  ,inf  ,inf ,inf ,0,66  ,inf ,54  ,inf ,inf ,inf , inf ,46  ,inf ,inf},      //Elmadağ 15
                                                {inf ,inf,inf , inf,inf ,inf ,34 ,23 ,inf ,inf ,16 , inf ,inf ,inf ,66,0,inf, inf, inf,  inf, inf,  inf, 134, inf, inf},                  //Akyurt 16
                                                {inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf,0,107 ,inf ,inf ,inf ,inf ,inf ,inf ,29},       //Şereflikoçhisar 17
                                                {65 ,inf,inf , 78,inf,inf ,inf ,inf,48,inf ,inf ,inf ,inf ,107 ,54  ,inf ,107 ,0,inf ,inf ,inf ,inf ,inf,inf ,inf},                    //Bala 18
                                                {inf ,inf,inf,inf ,inf ,inf,inf,inf,inf ,inf ,68 ,33 ,inf ,inf ,inf ,inf,inf ,inf ,0,inf ,79,26 ,inf ,57,inf},                 //Kızılcahamam 19
                                                {inf,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,60  ,inf ,inf ,inf ,inf ,inf ,inf ,0,inf ,inf ,inf,inf,inf},         //Nallıhan 20
                                                {inf,inf ,inf,inf,inf ,36,inf ,inf ,inf ,74,inf ,46 ,43 ,inf ,inf ,inf ,inf ,inf ,79,inf ,0,inf ,inf ,34,inf},                              //Ayaş 21
                                                {inf ,inf,inf ,inf ,inf,inf ,inf ,inf,inf,inf,inf ,inf,93  ,inf ,inf ,inf ,inf ,inf ,26  ,inf ,inf ,0,inf ,60  ,inf},                 //Çamlıdere 22
                                                {inf ,inf ,inf ,inf ,inf  ,inf , inf,  inf  ,inf ,inf, 49  ,inf , inf ,inf ,46  ,134 ,inf ,inf  ,inf ,inf ,inf ,inf ,0   ,inf ,inf},          //Kalecik 23
                                                {inf ,inf  ,inf  ,inf  ,inf  ,inf  ,inf  ,inf ,inf ,inf  ,inf ,inf  ,33  ,inf ,inf ,inf ,inf ,inf ,57 ,inf ,34  ,60  ,inf ,0 ,inf},       //Güdül 24
                                                {inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,29  ,inf ,inf ,inf ,inf ,inf ,inf ,inf ,0 } };      //Evren 25


            int[,] Dmatris = matris;  // İki boyutlu 'D' matrisini tutan dizi.
            int[,] Smatris = new int[nokta_sayisi, nokta_sayisi];  // İki boyutlu 'S' matrisini tutan dizi. 


            Console.WriteLine("\n ************* Matrisin orijinal hali ******************* \n");
            for (int i = 0; i < nokta_sayisi; i++)
            {
                for (int j = 0; j < nokta_sayisi; j++)
                {
                    Console.Write("[" + (i + 1) + "," + (j + 1) + "]:" + Dmatris[i, j].ToString() + " ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n NOT:  köşegen değeri: 0 ve nokta sayısı: 25 alındı");

            for (int i = 0; i < nokta_sayisi; i++) // Smatrisin hesaplama kısmı
            {
                for (int j = 0; j < nokta_sayisi; j++)
                {
                    if (i == j)
                    {
                        Smatris[i, j] = 0;
                    }
                    else
                    {
                        Smatris[i, j] = j + 1;
                    }
                }
            }

            while (sutun <= (nokta_sayisi - 1))         //Dmatrisi hesaplama kısmı
            {
                for (int i = 0; i < nokta_sayisi; i++)
                {

                    for (int j = 0; j < nokta_sayisi; j++)
                    {

                        int deger = Dmatris[i, j];
                        int yeni_deger = Dmatris[i, sutun] + Dmatris[sutun, j];  // D[1,3] + D[3,5] gibi düşün

                        if (yeni_deger < deger)
                        {
                            Dmatris[i, j] = yeni_deger;
                            Smatris[i, j] = sutun + 1;
                        }
                    }
                }
                sutun++;
            }

            Console.WriteLine("\n *********** Floyd Algoritması Uygulandıktan Sonra D Matrisi **************\n");

            for (int i = 0; i < nokta_sayisi; i++)
            {
                for (int j = 0; j < nokta_sayisi; j++)
                {
                    Console.Write("[" + (i + 1) + "," + (j + 1) + "]: " + Dmatris[i, j] + " ");
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine("\n *********** Floyd Algoritması Uygulandıktan Sonra S Matrisi **************\n");

            for (int i = 0; i < nokta_sayisi; i++)
            {
                for (int j = 0; j < nokta_sayisi; j++)
                {
                    Console.Write(Smatris[i, j].ToString().PadLeft(5));

                }

                Console.WriteLine();

            }

            string devam = "e";
            do
            {

                int baslangic_noktasi;
                int bitis_noktasi;
                bool yol = true;
                List<int> yol_listesi = new List<int>(); //başlangıçdan bitişe kadar olanlar yazılacak
                Console.WriteLine("\n\nNumaraların temsil ettiği nokta isimleri şu şekildedir : \n \n  1->Çankaya" + "11->Çubuk".ToString().PadLeft(20) + "21->Ayaş".ToString().PadLeft(25) +
                    "\n \n  2->Keçiören" + "12->Kahramankazan".ToString().PadLeft(27) + "22->Çamlıdere".ToString().PadLeft(22) + "\n \n  3->Yenimahalle" + "13->Beypazarı".ToString().PadLeft(20) +
                    "23->Kalecik".ToString().PadLeft(24) + "\n \n  4->Mamak" + "14->Haymana".ToString().PadLeft(24) + "24->Güdül".ToString().PadLeft(24) + "\n \n  5->Etimesgut" + "15->Elmadağ".ToString().PadLeft(20) + "25->Evren".ToString().PadLeft(24) + "\n \n  " +
                    "6->Sincan" + "16->Akyurt".ToString().PadLeft(22) + "\n \n  7->Altındağ" + "17->Şereflikoçhisar".ToString().PadLeft(29) + "\n \n  8->Pursaklar" + "18->Bala".ToString().PadLeft(17) +
                    "\n \n  9->Gölbaşı" + "19->Kızılcahamam".ToString().PadLeft(27) + "\n \n  10->Polatlı" + "20->Nallıhan".ToString().PadLeft(22));
                //Console.WriteLine("\n");
                Console.Write("\n\n" +
                    "Başlangıç adresi : ");
                baslangic_noktasi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitiş adresi : ");
                bitis_noktasi = Convert.ToInt32(Console.ReadLine());
                yol_listesi.Add(baslangic_noktasi); //listeme başlangıç ve bitişi ekledim
                yol_listesi.Add(bitis_noktasi);

                while (yol)
                {
                    int yol_listesi_lenght = yol_listesi.Count(); //içindekilerin sayısı 

                    for (int i = 0; i < yol_listesi_lenght - 1; i++)
                    {
                        int bas = (yol_listesi[i] - 1); //baslangic=1 1-1=0 x=0
                        int bit = (yol_listesi[i + 1] - 1); //bitis=9 9-1=8 y=8  S[0,8] e bakacak gibi
                        int sonuc = Smatris[bas, bit];

                        if (sonuc != yol_listesi[i + 1])
                        {
                            yol_listesi.Insert(i + 1, sonuc);
                            break;
                        }
                        else if (i == (yol_listesi_lenght - 2) && sonuc == yol_listesi[i + 1])
                        {
                            yol = false;
                            break;
                        }
                    }

                }

                if (baslangic_noktasi == 1 && bitis_noktasi == 2)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Keçiören");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Keçiören noktasına olan en kısa yolun uzunluğu: "+ Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + "   Çankaya->Altındağ->Keçiören"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 3)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Yenimahalle");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Yenimahalle noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Yenimahalle"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 4)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Mamak");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Mamak noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Mamak"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 5)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta:Etimesgut");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Etimesgut noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Yenimahalle->Etimesgut"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 6)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta:Sincan");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Sincan noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Yenimahalle->Sincan"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 7)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta:Altındağ");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Altındağ noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Altındağ"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 8)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Pursaklar");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Pursaklar noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Altındağ->Pursaklar"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 9)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Gölbaşı");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Gölbaşı noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Gölbaşı"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 10)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Polatlı");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Polatlı noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Yenimahalle->Polatlı"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 11)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Çubuk");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Çubuk noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Altındağ->Pursaklar->Çubuk"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 12)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Kahramankazan");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Kahramankazan noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Altındağ->Keçiören->Kahramankazan"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 13)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Beypazarı");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Beypazarı noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Yenimahalle->Sincan->Ayaş->Beypazarı"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 14)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Haymana");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Haymana noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Gölbaşı->Haymana"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 15)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Elmadağ");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Elmadağ noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Mamak->Elmadağ"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 16)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Akyurt");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Akyurt noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Altındağ->Akyurt"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 17)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Şereflikoçhisar");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Şereflikoçhisar noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Bala->Şereflikoçhisar"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 18)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Bala");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Bala noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Bala"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 19)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Kızılcahamam");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Kızılcahamam noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Altındağ->Keçiören->Kahramankazan->Kızılcahamam"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 20)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Nallıhan");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Nallıhan noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Yenimahalle->Sincan->Ayaş->Beypazarı->Nallıhan"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 21)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Ayaş");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Ayaş noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Yenimahalle->Sincan->Ayaş"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 22)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Çamlıdere");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Çamlıdere noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Altındağ->Keçiören->Kahramankazan->Kızılcahamam->Çamlıdere"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 23)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Kalecik");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Kalecik noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Mamak->Elmadağ->Kalecik"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 24)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Güdül");


                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Güdül noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Yenimahalle->Sincan->Ayaş->Güdül"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else if (baslangic_noktasi == 1 && bitis_noktasi == 25)
                {
                    Console.WriteLine(baslangic_noktasi + ". nokta: Çankaya");
                    Console.WriteLine(bitis_noktasi + ". nokta: Evren");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Çankaya noktasından, Evren noktasına olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray()) + " = Çankaya->Bala->Şereflikoçhisar->Ayaş->Evren"); // ilk noktayı direkt kendisi koyacak zaten
                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }

                else
                {

                    Console.WriteLine("---------------------");
                    Console.WriteLine(baslangic_noktasi + ". noktadan " + bitis_noktasi + ". noktaya olan en kısa yolun uzunluğu: " + Dmatris[baslangic_noktasi - 1, bitis_noktasi - 1] + " km");
                    Console.WriteLine("Takip edilen noktalar " + string.Join("->", yol_listesi.ToArray())); // ilk noktayı direkt kendisi koyacak zaten

                    Console.WriteLine("\nİşleminiz tamamlandı. Yeni bir işlem yapmak ister misiniz? (e) : ");
                    devam = Convert.ToString(Console.ReadLine());
                }
            }

            while (devam == "e");


            Console.ReadKey();


        }
    }
}

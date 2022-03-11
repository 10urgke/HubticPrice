namespace HubticProject;

public class HubticPrice
{ 
    public void  FiyatlandırmaFTL(string OriginCountry="", string DestinationCountry="", int? Id=null)
    { 
        Console.WriteLine("Çıkış ülkesini seçiniz(Türkiye[TR],Almanya[DE],İtalya[IT])");
        OriginCountry = Console.ReadLine();
        Console.Clear();
        if (OriginCountry.ToLower() == "TR".ToLower())
        {
            Console.WriteLine("Varış ülkesini seçiniz(Almanya[DE],İtalya[IT])");
            DestinationCountry = Console.ReadLine();
            Console.Clear();
            if (DestinationCountry.ToLower() == "DE".ToLower())
            {
                Console.WriteLine(@"Lütfen araç tipini seçiniz
1 - 3.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 1 Ton
2 - 7.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 2 Ton
3 - 12 Ton araç - Maksimum Taşıyacağı Ağırlık: 5 Ton
4 - 40 Ton araç - Maksimum Taşıyacağı Ağırlık: 24 Ton");

                Id = Convert.ToInt32(Console.ReadLine());
                if (Id== 1)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);

                    if (Toplamagırlık>=500 && Toplamagırlık<=1000)
                    {
                        double ToplamFiyat1 = 0.20 * 2490; 
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }
                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 1000 kg olacak şekilde bir değer giriniz.");
                    }
                
                
                    
                    
                }
                else if (Id == 2)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);

                    if (Toplamagırlık >= 500 && Toplamagırlık <= 2000)
                    {
                        double ToplamFiyat1 = 0.19 * 2490;
                        Console.WriteLine(
                            $"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 2000 kg olacak şekilde bir değer giriniz.");
                    }
                }



                else if (Id==3)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 5000)
                    {
                        double ToplamFiyat1 = 0.15 * 2490;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 5000 kg olacak şekilde bir değer giriniz.");
                    }
                    
                }
                else if (Id==4)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 24000)
                    {
                        double ToplamFiyat1 = 0.12 * 2490;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 24000 kg olacak şekilde bir değer giriniz.");
                    }
                
                
                    
                }
                else
                {
                    Console.WriteLine("Araç tipi bulunamadı");
                }
            
            }
            
            
            else if (DestinationCountry.ToLower()== "IT".ToLower())
            {
                Console.WriteLine(@"Lütfen araç tipini seçiniz
1 - 3.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 1 Ton
2 - 7.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 2 Ton
3 - 12 Ton araç - Maksimum Taşıyacağı Ağırlık: 5 Ton
4 - 40 Ton araç - Maksimum Taşıyacağı Ağırlık: 24 Ton");

                Id = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Id== 1)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                  
                    if (Toplamagırlık>=500 && Toplamagırlık<=1000)
                    {
                        double ToplamFiyat1 = 0.15 * 1940;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }
                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 1000 kg olacak şekilde bir değer giriniz.");
                    }
                
                
                    
                }
                else if (Id == 2)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 2000)
                    {
                        double ToplamFiyat1 = 0.14 * 1940;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 2000 kg olacak şekilde bir değer giriniz.");
                    }
                
                
                
                    
                }
                else if (Id==3)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 5000)
                    {
                        double ToplamFiyat1 = 0.12 * 1940;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 5000 kg olacak şekilde bir değer giriniz.");
                    }
                
                
                    
                }
                else if (Id==4)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 24000)
                    {
                        double ToplamFiyat1 = 0.10 * 1940;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kgnFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 24000 kg olacak şekilde bir değer giriniz.");
                    }
                
                
                    
                }
                else
                {
                    Console.WriteLine("Araç tipi bulunamadı");
                }
            
            }
            
        }
        else if (OriginCountry.ToLower() == "IT".ToLower())
        {
            Console.WriteLine("Varış ülkesini seçiniz(Almanya[DE],Türkiye[TR])");
            DestinationCountry = Console.ReadLine();
            if (DestinationCountry.ToLower() == "DE".ToLower())
            {
                Console.WriteLine(@"Lütfen araç tipini seçiniz
1 - 3.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 1 Ton
2 - 7.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 2 Ton
3 - 12 Ton araç - Maksimum Taşıyacağı Ağırlık: 5 Ton
4 - 40 Ton araç - Maksimum Taşıyacağı Ağırlık: 24 Ton");

                Id = Convert.ToInt32(Console.ReadLine());
                if (Id== 1)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                    if (Toplamagırlık>=500 && Toplamagırlık<=1000)
                    {
                      
                        double ToplamFiyat1 = 0.12 * 1027;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }
                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 1000 kg olacak şekilde bir değer giriniz.");
                    }
                
                    
                }
                else if (Id == 2)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 2000)
                    {
                        double ToplamFiyat1 = 0.11 * 1027;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 2000 kg olacak şekilde bir değer giriniz.");
                    }
                
                
                    
                }
                else if (Id==3)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 5000)
                    {
                        double ToplamFiyat1 = 0.10 * 1027;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 5000 kg olacak şekilde bir değer giriniz.");
                    }
                
                
                    
                }
                else if (Id==4)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 24000)
                    {
                        double ToplamFiyat1 = 0.08 * 1027;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 24000 kg olacak şekilde bir değer giriniz.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Araç tipi bulunamadı");
                }
            
            }



            else if (DestinationCountry.ToLower()== "TR".ToLower())
            {
                Console.WriteLine(@"Lütfen araç tipini seçiniz
1 - 3.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 1 Ton
2 - 7.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 2 Ton
3 - 12 Ton araç - Maksimum Taşıyacağı Ağırlık: 5 Ton
4 - 40 Ton araç - Maksimum Taşıyacağı Ağırlık: 24 Ton");

                Id = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Id== 1)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                    if (Toplamagırlık>=500 && Toplamagırlık<=1000)
                    {
                        double ToplamFiyat1 = 0.15 * 1940;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }
                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 1000 kg olacak şekilde bir değer giriniz.");
                    }
                    
                }
                else if (Id == 2)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 2000)
                    {
                        double ToplamFiyat1 = 0.14 * 1940;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 2000 kg olacak şekilde bir değer giriniz.");
                    }
                    
                }
                else if (Id==3)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 5000)
                    {
                        double ToplamFiyat1 = 0.12 * 1940;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 5000 kg olacak şekilde bir değer giriniz.");
                    }
                    
                }
                else if (Id==4)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 24000)
                    {
                        double ToplamFiyat1 = 0.10 * 1940;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kgnFiyat:{ToplamFiyat1}$");
                    }
                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 24000 kg olacak şekilde bir değer giriniz.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Araç tipi bulunamadı");
                }
            
            }
            else
            {
                Console.WriteLine("Ülke bulunamadı!!1");
            }
            
        } 
        else if (OriginCountry.ToLower() == "DE".ToLower())
        {
            Console.WriteLine("Varış ülkesini seçiniz(Türkiye[TR],İtalya[IT])");
            DestinationCountry = Console.ReadLine();
            if (DestinationCountry.ToLower() == "IT".ToLower())
            {
                Console.WriteLine(@"Lütfen araç tipini seçiniz
1 - 3.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 1 Ton
2 - 7.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 2 Ton
3 - 12 Ton araç - Maksimum Taşıyacağı Ağırlık: 5 Ton
4 - 40 Ton araç - Maksimum Taşıyacağı Ağırlık: 24 Ton");

                Id = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Id== 1)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                    if (Toplamagırlık>=500 && Toplamagırlık<=1000)
                    {
                      
                        double ToplamFiyat1 = 0.12 * 1027;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }
                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 1000 kg olacak şekilde bir değer giriniz.");
                    }
                }
                else if (Id == 2)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 2000)
                    {
                        double ToplamFiyat1 = 0.11 * 1027;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 2000 kg olacak şekilde bir değer giriniz.");
                    }
                }
                else if (Id==3)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 5000)
                    {
                        double ToplamFiyat1 = 0.10 * 1027;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 5000 kg olacak şekilde bir değer giriniz.");
                    }
                }
                else if (Id==4)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 24000)
                    {
                        double ToplamFiyat1 = 0.08 * 1027;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 24000 kg olacak şekilde bir değer giriniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Araç tipi bulunamadı");
                }
            
            }
            else if (DestinationCountry.ToLower()== "TR".ToLower())
            {
                Console.WriteLine(@"Lütfen araç tipini seçiniz
1 - 3.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 1 Ton
2 - 7.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 2 Ton
3 - 12 Ton araç - Maksimum Taşıyacağı Ağırlık: 5 Ton
4 - 40 Ton araç - Maksimum Taşıyacağı Ağırlık: 24 Ton");

                Id = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Id== 1)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık>=500 && Toplamagırlık<=1000)
                    {
                        double ToplamFiyat1 = 0.20 * 2490; 
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }
                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 1000 kg olacak şekilde bir değer giriniz.");
                    }
                }
                else if (Id == 2)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 2000)
                    {
                        double ToplamFiyat1 = 0.19 * 2490;
                        Console.WriteLine(
                            $"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 2000 kg olacak şekilde bir değer giriniz.");
                    }
                }
                else if (Id==3)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 5000)
                    {
                        double ToplamFiyat1 = 0.15 * 2490;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 5000 kg olacak şekilde bir değer giriniz.");
                    }
                }
                else if (Id==4)
                {
                    Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
                    string ToplamAgırlık1 = Console.ReadLine();
                    int Toplamagırlık = Convert.ToInt32(ToplamAgırlık1);
                
                    if (Toplamagırlık >= 500 && Toplamagırlık <= 24000)
                    {
                        double ToplamFiyat1 = 0.12 * 2490;
                        Console.WriteLine($"Yükünüz {OriginCountry}'den/dan çıkıp {DestinationCountry}'ye/ya varacaktır.\nAğırlığınız:{Toplamagırlık}kg\nFiyat:{ToplamFiyat1}$");
                    }

                    else
                    {
                        Console.WriteLine("Minimum 500 kg Maksimum 24000 kg olacak şekilde bir değer giriniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Araç tipi bulunamadı");
                }
            
            }
            else
            {
                Console.WriteLine("ülke bulunamadı!!!!");
            }

            
        }
        else
        {
           Console.WriteLine("Lütfen çıkış ülkesini doğru seçiniz.");
        }
    }

    public void FiyatlandırmaLTL(double? En = null, double? Boy =null, double? Yukseklık = null, double? Ağırlık =null, string ÇıkışÜlkesi ="",string VarışÜlkesi="")
    {
        Console.WriteLine("Lütfen yükün çıkış ülkesini seçiniz (Türkiye[TR],Almanya[DE],İtalya[IT])");
        ÇıkışÜlkesi = Console.ReadLine();
        if (ÇıkışÜlkesi.ToLower() == "TR".ToLower())
        {
            Console.WriteLine("Varış ülkesini seçiniz(Almanya[DE],İtalya[IT])");
            VarışÜlkesi = Console.ReadLine();
            Console.WriteLine("Lütfen yükseklik bilgilerini giriniz(metre cinsinden):");
            Yukseklık = Convert.ToDouble(Console.ReadLine());
            if (Yukseklık<2.4)
            {
            }
            else
            {
                Console.WriteLine("Yükseklik 2.4 metreden fazla olamaz.");
                return;
            }

            if (Yukseklık>0)
            {
                
            }
            else
            {
                Console.WriteLine("Yükseklik 0'dan az olamaz.");
                return;
            }
            
            Console.WriteLine("Lütfen en bilgilerini giriniz(metre cinsinden):");
            En = Convert.ToDouble(Console.ReadLine());
            if (En>0)
            {
            }
            else
            {
                Console.WriteLine("En değeri 0'dan küçük olamaz.");
                return;
            }
            Console.WriteLine("Lütfen boy bilgilerini giriniz(metre cinsinden):");
            Boy = Convert.ToDouble(Console.ReadLine());
            if (Boy>0)
            {
            }
            else
            {
                Console.WriteLine("Boy değeri 0'dan küçük olamaz.");
                return;
            }
            Console.WriteLine("Lütfen ağırlık bilgilerini giriniz:");
            Ağırlık = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (Ağırlık>500)
            {
            }
            else
            {
                Console.WriteLine("minimum 500 kg ");
                return;
            }
            if (VarışÜlkesi.ToLower() == "DE".ToLower())
            {
                double? Fiyat = En * Boy * Yukseklık * 333;
                double? Fiyat2 = Ağırlık * 0.24;
                if (Fiyat>Fiyat2 && Ağırlık<4000) 
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat2>Fiyat && Ağırlık<=4000) 
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat2}$");
                }
                double? Fiyat4 = Ağırlık * 0.18;
                if (Fiyat<Fiyat4 && Ağırlık<=12000 && Ağırlık>4000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat4}$");
                }
                else if (Fiyat4<Fiyat && Ağırlık<=12000 && Ağırlık>4000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                double? Fiyat5 = Ağırlık * 0.12;
                if (Fiyat5<Fiyat && Ağırlık<=24000 && Ağırlık>12000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat<Fiyat5 && Ağırlık<=24000 && Ağırlık>12000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat5}$");
                }
            }
            else if (VarışÜlkesi.ToLower() == "IT".ToLower())
            {
                double? Fiyat = En * Boy * Yukseklık * 333;
                double? Fiyat2 = Ağırlık * 0.20;
                if (Fiyat>Fiyat2 && Ağırlık<4000) 
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat2>Fiyat && Ağırlık<=4000) 
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat2}$");
                }
                double? Fiyat4 = Ağırlık * 0.16;
                if (Fiyat<=Fiyat4 && Ağırlık<=12000 && Ağırlık>4000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat4}$");
                }
                else if (Fiyat4<=Fiyat && Ağırlık<=12000 && Ağırlık>4000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                double? Fiyat5 = Ağırlık * 0.14;
                if (Fiyat5<Fiyat && Ağırlık<=24000 && Ağırlık>12000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat<Fiyat5 && Ağırlık<=24000 && Ağırlık>12000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat5}$");
                }
            }
            else
            {
                Console.WriteLine("Varış ülkesini doğru seçiniz.");
            }
            
        }
        else if (ÇıkışÜlkesi.ToLower() == "IT".ToLower())
        {
            Console.WriteLine("Varış ülkesini seçiniz(Almanya[DE],Türkiye[TR])");
            VarışÜlkesi = Console.ReadLine();
            Console.WriteLine("Lütfen yükseklik bilgilerini giriniz(metre cinsinden):");
            Yukseklık = Convert.ToDouble(Console.ReadLine());
            if (Yukseklık<2.4)
            {
            }
            else
            {
                Console.WriteLine("Yükseklik 2.4 metreden fazla olamaz.");
                return;
            }

            if (Yukseklık>0)
            {
                
            }
            else
            {
                Console.WriteLine("Yükseklik 0'dan az olamaz.");
                return;
            }
            
            Console.WriteLine("Lütfen en bilgilerini giriniz(metre cinsinden):");
            En = Convert.ToDouble(Console.ReadLine());
            if (En>0)
            {
            }
            else
            {
                Console.WriteLine("En değeri 0'dan küçük olamaz.");
                return;
            }
            Console.WriteLine("Lütfen boy bilgilerini giriniz(metre cinsinden):");
            Boy = Convert.ToDouble(Console.ReadLine());
            if (Boy>0)
            {
            }
            else
            {
                Console.WriteLine("Boy değeri 0'dan küçük olamaz.");
                return;
            }
            Console.WriteLine("Lütfen ağırlık bilgilerini giriniz:");
            Ağırlık = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (Ağırlık>500)
            {
            }
            else
            {
                Console.WriteLine("minimum 500 kg ");
                return;
            }
            if (VarışÜlkesi.ToLower() == "DE".ToLower())
            {
                double? Fiyat = En * Boy * Yukseklık * 333;
                double? Fiyat2 = Ağırlık * 0.16;
                if (Fiyat>Fiyat2 && Ağırlık<4000) 
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat2>Fiyat && Ağırlık<=4000) 
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat2}$");
                }
                double? Fiyat4 = Ağırlık * 0.14;
                if (Fiyat<Fiyat4 && Ağırlık<=12000 && Ağırlık>4000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat4}$");
                }
                else if (Fiyat4<Fiyat && Ağırlık<=12000 && Ağırlık>4000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                double? Fiyat5 = Ağırlık * 0.10;
                if (Fiyat5<Fiyat && Ağırlık<=24000 && Ağırlık>12000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat<Fiyat5 && Ağırlık<=24000 && Ağırlık>12000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat5}$");
                }
            }
            else if (VarışÜlkesi.ToLower() == "TR".ToLower())
            {
                double? Fiyat = En * Boy * Yukseklık * 333;
                double? Fiyat2 = Ağırlık * 0.20;
                if (Fiyat>Fiyat2 && Ağırlık<4000) 
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat2>Fiyat && Ağırlık<=4000) 
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat2}$");
                }
                double? Fiyat4 = Ağırlık * 0.16;
                if (Fiyat<=Fiyat4 && Ağırlık<=12000 && Ağırlık>4000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat4}$");
                }
                else if (Fiyat4<=Fiyat && Ağırlık<=12000 && Ağırlık>4000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                double? Fiyat5 = Ağırlık * 0.14;
                if (Fiyat5<Fiyat && Ağırlık<=24000 && Ağırlık>12000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat<Fiyat5 && Ağırlık<=24000 && Ağırlık>12000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat5}$");
                }
            }
            else
            {
                Console.WriteLine("Lütfen varış ülkesini doğru seçiniz.");
            }
            
            
        }
        else if (ÇıkışÜlkesi.ToLower() == "DE".ToLower())
        {
            Console.WriteLine("Varış ülkesini seçiniz(Türkiye[TR],İtalya[IT])");
            VarışÜlkesi = Console.ReadLine();
            Console.WriteLine("Lütfen yükseklik bilgilerini giriniz(metre cinsinden):");
            Yukseklık = Convert.ToDouble(Console.ReadLine());
            if (Yukseklık<2.4)
            {
            }
            else
            {
                Console.WriteLine("Yükseklik 2.4 metreden fazla olamaz.");
                return;
            }

            if (Yukseklık>0)
            {
                
            }
            else
            {
                Console.WriteLine("Yükseklik 0'dan az olamaz.");
                return;
            }
            
            Console.WriteLine("Lütfen en bilgilerini giriniz(metre cinsinden):");
            En = Convert.ToDouble(Console.ReadLine());
            if (En>0)
            {
            }
            else
            {
                Console.WriteLine("En değeri 0'dan küçük olamaz.");
                return;
            }
            Console.WriteLine("Lütfen boy bilgilerini giriniz(metre cinsinden):");
            Boy = Convert.ToDouble(Console.ReadLine());
            if (Boy>0)
            {
            }
            else
            {
                Console.WriteLine("Boy değeri 0'dan küçük olamaz.");
                return;
            }
            Console.WriteLine("Lütfen ağırlık bilgilerini giriniz:");
            Ağırlık = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (Ağırlık>500)
            {
            }
            else
            {
                Console.WriteLine("minimum 500 kg ");
                return;
            }
            if (VarışÜlkesi.ToLower() == "TR".ToLower())
            {
                double? Fiyat = En * Boy * Yukseklık * 333;
                double? Fiyat2 = Ağırlık * 0.24;
                if (Fiyat>Fiyat2 && Ağırlık<4000) 
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat2>Fiyat && Ağırlık<=4000) 
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat2}$");
                }
                double? Fiyat4 = Ağırlık * 0.18;
                if (Fiyat<Fiyat4 && Ağırlık<=12000 && Ağırlık>4000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat4}$");
                }
                else if (Fiyat4<Fiyat && Ağırlık<=12000 && Ağırlık>4000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                double? Fiyat5 = Ağırlık * 0.12;
                if (Fiyat5<Fiyat && Ağırlık<=24000 && Ağırlık>12000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat<Fiyat5 && Ağırlık<=24000 && Ağırlık>12000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat5}$");
                }
            }
            else if (VarışÜlkesi.ToLower() == "IT".ToLower())
            {
                double? Fiyat = En * Boy * Yukseklık * 333;
                double? Fiyat2 = Ağırlık * 0.16;
                if (Fiyat>Fiyat2 && Ağırlık<4000) 
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat2>Fiyat && Ağırlık<=4000) 
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak.\nEni:{En}m,\nBoyu:{Boy}m,\nYüksekliği:{Yukseklık}m,\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat2}$");
                }
                double? Fiyat4 = Ağırlık * 0.14;
                if (Fiyat<=Fiyat4 && Ağırlık<=12000 && Ağırlık>4000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat4}$");
                }
                else if (Fiyat4<=Fiyat && Ağırlık<=12000 && Ağırlık>4000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                double? Fiyat5 = Ağırlık * 0.10;
                if (Fiyat5<Fiyat && Ağırlık<=24000 && Ağırlık>12000)
                { 
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat}$");
                }
                else if (Fiyat<Fiyat5 && Ağırlık<=24000 && Ağırlık>12000)
                {
                    Console.WriteLine($"Taşınacak yük {ÇıkışÜlkesi}'den/dan {VarışÜlkesi}'ye/ya taşınacak. \nEni:{En},\nBoyu:{Boy},\nYüksekliği:{Yukseklık},\nAğırlığı:{Ağırlık}kg\nFiyat:{Fiyat5}$");
                }
            }
            else
            {
                Console.WriteLine("Lütfen varış ülkesini doğru seçiniz");
            }
        }
        else
        {
            Console.WriteLine("Lütfen çıkış ülkesini doğru seçiniz.");
        }
    }
}
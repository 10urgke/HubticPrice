// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hoşgeldiniz!");
System.Threading.Thread.Sleep(2000);
string Türkiye = "TR";
string Almanya = "DE";
string İtalya =  "IT";
Console.WriteLine(@"Taşıma tipinizi seçiniz:
1-FTL
2-LTL");
string TasımaTipi = Console.ReadLine();
int Tasımatipi = Convert.ToInt32(TasımaTipi);
Console.Clear();
if (Tasımatipi == 1)
{
 Console.WriteLine(@"Lütfen araç tipini seçiniz:
1 - 3.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 1 Ton
2 - 7.5 Ton araç - Maksimum Taşıyacağı Ağırlık: 2 Ton
3 - 12 Ton araç - Maksimum Taşıyacağı Ağırlık: 5 Ton
4 - 40 Ton araç - Maksimum Taşıyacağı Ağırlık: 24 Ton");
 System.Threading.Thread.Sleep(2000);
 string AracTipi = Console.ReadLine();
 int Aractipi = Convert.ToInt32(AracTipi);
 Console.Clear();
 if ( Aractipi == 1)
 {
     Console.WriteLine("Taşıma başlangıç noktasını seçiniz (1-TR,2-DE,3-IT) ");
     string OriginUlke = Console.ReadLine();
     int Originulke = Convert.ToInt32(OriginUlke);
     if (Originulke==1)
     {
         Console.WriteLine("Taşıma bitiş noktasını seçiniz.(2-DE,3-IT)");
         string DestinationUlke = Console.ReadLine();
         int Destinationulke = Convert.ToInt32(DestinationUlke);
         if (Destinationulke==2)
         {
             Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
             string ToplamAgırlık = Console.ReadLine();
             int Toplamagırlık = Convert.ToInt32(ToplamAgırlık);
             if (500<=Toplamagırlık && Toplamagırlık<=1000)
             {
                 double TaşımaFiyatı = 2490 * 0.20;
                 Console.WriteLine($"Taşımanız Türkiye ile Almanya arasında olacaktır.\n Ağırlığınız : {Toplamagırlık}\n Fiyat ise {TaşımaFiyatı}");
             }
             
             
         }
         
     }
     
     
 }
 else if ( Aractipi == 2)
 {
     Console.WriteLine("Taşıma başlangıç noktasını seçiniz (1-TR,2-DE,3-IT) ");
     string OriginUlke = Console.ReadLine();
     int Originulke = Convert.ToInt32(OriginUlke);
     if (Originulke==1)
     {
         Console.WriteLine("Taşıma bitiş noktasını seçiniz.(2-DE,3-IT)");
         string DestinationUlke = Console.ReadLine();
         int Destinationulke = Convert.ToInt32(DestinationUlke);
         if (Destinationulke==2)
         {
             Console.WriteLine("Lütfen taşıncak yükün ağırlığını giriniz:");
             string ToplamAgırlık = Console.ReadLine();
             int Toplamagırlık = Convert.ToInt32(ToplamAgırlık);
             if (500<=Toplamagırlık && Toplamagırlık<=1000)
             {
                 double TaşımaFiyatı = 2490 * 0.20;
                 Console.WriteLine($"Taşımanız Türkiye ile Almanya arasında olacaktır.\n Ağırlığınız : {Toplamagırlık}\n Fiyat ise {TaşımaFiyatı}");
             }
             
             
         }
     }
 }
 else if ( Aractipi == 3)
 {
     Console.WriteLine("3");
 }
 else if ( Aractipi == 4)
 {
     Console.WriteLine("4");
 }

 else
 {
     Console.WriteLine("Araç tippini düzgün seçiniz.");
 }
}
else if (Tasımatipi==2)
{
    
}
else
{
    Console.WriteLine("Lütfen FTL yada LTL taşıma tipinden birini seçiniz.");
  
}
*/

using HubticProject;
public class Program
{

    static void Main()
    {
        Console.WriteLine("Hoşgeldiniz!");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine(@"Taşıma tipinizi seçiniz:
1-FTL
2-LTL");
        string TasımaTipi = Console.ReadLine();
        int Tasımatipi = Convert.ToInt32(TasımaTipi);
        Console.Clear();
        if (Tasımatipi == 1)
        {
            HubticPrice hubticprice = new HubticPrice();
            hubticprice.FiyatlandırmaFTL();
        }
        else if (Tasımatipi==2)
        {
            HubticPrice hubticprice = new HubticPrice();
            hubticprice.FiyatlandırmaLTL();
        }
        else
        {
            Console.WriteLine("Taşıma tipi bulunamadı!!!");
        }
        
    }
        
           
}











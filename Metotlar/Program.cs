// Metotlar tekrar tekrar kullanılabilirliği sağlayan bir ortam sağlıyor
//Dont repeat yourself - DRY
// Clean Code
//Best Practice - En iyi uygulama teknikleri


using Metotlar;

string urunadi = "Elma";
double fiyati = 15;
string aciklama = "Amasya Elması";

string[] meyveler = new string[] { "Elma", "Karouz" };

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elamsı";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

//type-safe -- tip güvenliği
foreach (var urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine(urun.StokAdedi);
    Console.WriteLine("--------------------\n");
}

Console.WriteLine("\n-------------Metotlar-------------\n");

//instance - örnek
//encapsulation - kapsülleme
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil Armut",12);
sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);




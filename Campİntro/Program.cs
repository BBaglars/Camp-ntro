//type safety - tip güvenliği
//değer tutucu - alias
//Do not repeat yourself - kendini tekrar etme 
//Console.WriteLine("Kategori");
//Console.WriteLine("Kategori");
//Console.WriteLine("Kategori");
//Console.WriteLine("Kategori");
//Console.WriteLine("Kategori");

string kategoriEtiketi = "kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = false;
double dolarDun = 7.45;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("Değişmedi butonu");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

Console.WriteLine(kategoriEtiketi);
Console.WriteLine(ogrenciSayisi);
Console.WriteLine(faizOrani);



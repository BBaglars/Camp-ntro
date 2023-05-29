string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";
string kurs4 = "Pyhton";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);
Console.WriteLine(kurs4+"\n");

//array - dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,
    "Programlamaya başlangıç için temel kurs",
    "Java","Pyhton",kurs4};

//lenght - eleman sayısı

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("\nfor Bitti\n");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("\nsayfa sonu - footer");
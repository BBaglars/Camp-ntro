//string adi = "Engin";
//int yas = 36;

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.İzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Kerem Varış";
kurs2.İzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Pyhton";
kurs3.Egitmen = "Berkay Bilgin";
kurs3.İzlenmeOrani = 80;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "C++";
kurs4.Egitmen = "Murat Kurtboğan";
kurs4.İzlenmeOrani = 100;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
//Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen);
//Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " -> " + kurs.İzlenmeOrani);

}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int İzlenmeOrani { get; set; }
}
  


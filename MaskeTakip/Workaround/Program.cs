using Business.Concrete;
using Entities.Concrete;

SelamVer("Furkan");
SelamVer();

Topla(10, 50);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Emre";
ogrenciler[2] = "Furkan";

ogrenciler = new string[4];
ogrenciler[3] = "Ahmet";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
yeniSehirler1.Add("Adana");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

Person person = new Person
{
    FirstName = "Furkan",
    LastName = "Dereli",
    DateOfBirthYear = 1998,
    NationalIdentity = 1453
};

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);

Console.ReadKey();

static void SelamVer(string isim = "İsimsiz")
{
    Console.WriteLine("Merhaba");
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}
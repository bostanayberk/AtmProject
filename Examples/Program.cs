// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;

Console.WriteLine("Hoşgeldiniz");
int balance = 1000;
string customer = "semih";
string password = "123";
Console.WriteLine("Kullancı adı giriniz");
string outCostumer = Convert.ToString(Console.ReadLine());



if (customer == outCostumer)
{
    Console.WriteLine("Şifre Giriniz");
    for (int i = 0; i < 3; i++)
    {
        string outPassword = Convert.ToString(Console.ReadLine());
        if (password == outPassword)
        {
            Console.WriteLine("Giriş Başarılı");
            break;
            
        }
        else if (i==1)
        {
            Console.WriteLine("2 hakkınız kaldı");
        }
        else if (i==3)
        {
            Console.WriteLine("Şifreniz Bloke oldu.Bankaya gidin");
        }


    }

}
else
{
    Console.WriteLine("Yanlış kullanıcı ismi");
    Environment.Exit(0);

}
Console.WriteLine("Para Çekmek İstiyorsanız bire basınız");
Console.WriteLine("Para Yatırmak İstiyorsanız ikiye basınız");
string outOption = Convert.ToString(Console.ReadLine());
if (outOption == "1")
{
    Console.WriteLine("Tutar Giriniz");
    int outBalance = Convert.ToInt32(Console.ReadLine());
    balance -= outBalance;
    Console.WriteLine($"İşlem başarılı yeni Bakiyeniz {balance}");
}
if (outOption == "2")
{
    Console.WriteLine("Tutarı verin");
    int inBalance = Convert.ToInt32(Console.ReadLine());
    balance += inBalance;
    Console.WriteLine($"İşlem başarılı Yeni bakiyeniz {balance}");
}


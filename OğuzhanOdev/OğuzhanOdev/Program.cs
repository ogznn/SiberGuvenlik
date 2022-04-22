using System;
using System.Diagnostics;

namespace OğuzhanOdev
{
    class Program
{
    static void Main(string[] args)
    {
        string ip;
        Console.Write("IP Giriniz: ");
        ip = Console.ReadLine();
        //Burada ip değişkeni tanımlayarak kullanıcıdan ip girmesini istedik.

        Process process = new Process();
        process.StartInfo.FileName = "nmap.exe"; //Burada ise çalıştırılması gereken dosya adını sisteme belirttik.
        process.StartInfo.Arguments = "nmap -T4 -A -v " + ip; //Devamında, çalıştırılan dosyaya girilmesi gereken metni belirtip, kullanıcının da girmiş olduğu ip adresini metin ile birleştirdik.
        process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized; //Ek olarak sisteme programın başlatılması gereken bilgiyi verdik.
        process.Start(); //Program başlatıldı.
        process.WaitForExit(); //Program bitirilip çıkışı yapıldı.
    }
}
}
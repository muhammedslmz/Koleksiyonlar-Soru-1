using System;
using System.Collections;

namespace koleksiyonlarSoru2
{
    class Program
    {
        static void Main(string []args)
        {
            ArrayList sayılar=new ArrayList();
            ArrayList büyük=new ArrayList();
            ArrayList küçük=new ArrayList();
            
            int küçükToplam=0;
            int büyükToplam=0;
        

            Console.WriteLine("Lütfen 20 adet sayı giriniz.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i+1)+". indexi giriniz: ");
                string girilen = Console.ReadLine();
                if (!Int32.TryParse(girilen, out int sayi))
                {
                    Console.WriteLine($"Geçersiz bir değer girdiniz: {girilen}");
                }
                else
                {
                    if(sayi<0)
                    {
                        Console.WriteLine("Lütfen pozitif sayı giriniz.");
                    }
                    else
                    {
                    sayılar.Add(sayi);
                    }

                }
               
                
            }

            sayılar.Sort();
            
            for (int i = 0; i < 3; i++)
            {
                küçük.Add(sayılar[i]);
            }
            
            sayılar.Reverse();
            for (int i = 0; i < 3; i++)
            {
                büyük.Add(sayılar[i]);
            }

            for (int i = 0; i < küçük.Count; i++)
            {
               küçükToplam+=(int)küçük[i];
            }
            Console.WriteLine("En küçük 3 sayının ortalaması: "+ (küçükToplam/küçük.Count));

            for (int i = 0; i < büyük.Count; i++)
            {
                büyükToplam+=(int)büyük[i];
            }
            Console.WriteLine("En büyük 3 sayının ortalaması: "+(büyükToplam/büyük.Count));

            Console.WriteLine("Ortalama toplamları: "+ ((büyükToplam/büyük.Count)+(küçükToplam/küçük.Count)));
        }
    }   
}
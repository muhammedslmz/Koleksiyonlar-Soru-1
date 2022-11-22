using System;
using System.Collections;
namespace koleksiyonlarSoru1
{
    class Program
    {
        static void Main(string[]args)
        {
            ArrayList sayılar=new ArrayList();
            ArrayList asalSayı=new ArrayList();
            ArrayList asalOlmayan=new ArrayList();
            int n =5;
            int sayaç= 0;
            int asalort=0;
            int asalOlmayanOrt=0;
            Console.WriteLine("Lütfen 20 tane pozitif sayı giriniz: ");
            for (int i = 0; i < n; i++)
            {
                

                string girilen = Console.ReadLine()  ;
                if (!Int32.TryParse(girilen, out int sayi))
                {
                    Console.WriteLine($"Geçersiz bir sayı girdiniz: "+girilen);
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
             
             for (int i = 0; i < sayılar.Count; i++)
            {
               for (int j = 1; j <= (int)(sayılar[i]); j++)
               {
                     if ((int)(sayılar[i])%j==0)
                {
                    sayaç++;
                }
                
               }
            if (sayaç==2)
            {
                asalSayı.Add(sayılar[i]);
            }
            else
            {
                asalOlmayan.Add(sayılar[i]);
            }
            sayaç=0;
            }
            Console.WriteLine("*****************");
            asalSayı.Sort();
            asalSayı.Reverse();
            foreach (var item in asalSayı)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************");
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
           foreach (var item in asalOlmayan)
           {
                Console.WriteLine(item);
           }
            Console.WriteLine("*****************");
           Console.WriteLine("Asal olmayanların sayısı: " + asalOlmayan.Count);
           Console.WriteLine("Asal olanların sayısı: "+ asalSayı.Count);


           for (int i = 0; i < asalOlmayan.Count; i++)
           {
            asalOlmayanOrt+=(int)asalOlmayan[i];
           }
            
            foreach (var item in asalSayı)
            {
                asalort+= (int)item;
            }

            Console.WriteLine("Asal olmayanların ortalaması: "+asalOlmayanOrt);
            Console.WriteLine("Asal olanların ortalaması: "+asalort);
            
            
        }
    }
}
using System;
using System.Collections;
namespace koleksiyonlarSoru3
{
    class program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Lütfen ayrıştırılmasını istediğiniz cümleyi yazınız.");
            ArrayList sesliHarfler =new ArrayList();
            
            string cümle=Console.ReadLine();
            string sesli="AaEeIıİiOoÖöUuÜü";

            for (int i = 0; i < cümle.Length; i++)
            {
                if(sesli.Contains(cümle[i]))
                sesliHarfler.Add(cümle[i]);
            }

            sesliHarfler.Sort();
            foreach (var item in sesliHarfler)
            {
                Console.WriteLine(item);
            }

        }
    }
}
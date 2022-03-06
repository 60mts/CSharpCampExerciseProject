using System;
using System.Collections.Generic;

namespace dictionary
{
    internal class Program
    {
        //Dictionary sınıfı eklendiği elemanları key ve value olarak kaydetmemize yarayan bir sınıfdır.

        //Bu sınıfın özelliğini kullanabilmemiz için System.Collections.Generic kütüphanesini ilk önce eklememiz lazım.

        //Unutmadan eğer key değerine göre otomatik sıralı bir liste oluşturmak istersek SortedList kullanmak daha iyi olur.

        static void Main()
        {
            //sortedList oluşturuldu.
            SortedList<int, string> usersSortedList = new SortedList<int, string>();
            usersSortedList.Add(2, "Ziynet Karaslan");
            usersSortedList.Add(4, "sfaf Kafrafdsfslan");
            usersSortedList.Add(3, "fsdfa gs");
            usersSortedList.Add(7, "Ziyfsdgsnet fdsgfsad");
            usersSortedList.Add(5, "fdsgasd dgfsdgf");
            //dictionary oluşturuldu.
            Dictionary<int, string> usersDictionary = new Dictionary<int, string>();
            usersDictionary.Add(2, "Ziynet Karaslan");
            usersDictionary.Add(4, "sfaf Kafrafdsfslan");
            usersDictionary.Add(3, "fsdfa gs");
            usersDictionary.Add(7, "Ziyfsdgsnet fdsgfsad");
            usersDictionary.Add(5, "fdsgasd dgfsdgf");
            Console.WriteLine("Dictionary ile");
            foreach (KeyValuePair<int,string> user in usersDictionary)
            {
                Console.WriteLine("Id:" + user.Key + "\t" + "Adı Soyadı:" + user.Value);
            }
            Console.WriteLine("");
            Console.WriteLine("SortedList ile");

            foreach (KeyValuePair<int,string> user in usersSortedList)
            {
                Console.WriteLine("Id:" + user.Key + "\t" + "Adı Soyadı:" + user.Value);
            }
            Console.WriteLine("");
            Console.WriteLine("FirstExample");    
            Dictionary<int, string> users = new Dictionary<int, string>();
            //diğer listelerde olduğu gibi Add() metodu ile ekleme yaypıyoruz.
            users.Add(5, "Özcan Öner");
            users.Add(8, "Serkan Karadeniz");
            users.Add(6, "Engin Demirog");
            users.Add(10, "Cristiano Ronaldo");
            users.Add(7, "Ricardo Quaresma");
            users.Add(9, "Muhammed Tayyib Şahin");
            //diğer listelerden farklı yazdırma işlemi 
            //keyvaluepair dictionary'deki anahtarımız.
            //ve dictionarydeki value  değer   tipimiz ne ise onlarıda aynen yazıyoruz.
            foreach (var user in users)
            {

                Console.WriteLine("Id:" + user.Key + "\t" + "Adı Soyadı:" + user.Value);
            }
            //Dictionary key uniqtir yani benzersiz. Aynı değerler gelirse hata vericektir.
            //peki bunu nasıl önlüyoruz.
            string newUser = "Muhammed Tayyib Şahin";
            bool varMi = users.TryGetValue(9, out newUser);
            //varsa true yoksa false dönderecek.
            if (varMi)
            {
                Console.WriteLine("böyle bir kayıt Mevcut!");
            }
            else
            {
                users.Add(9, newUser);
                Console.WriteLine("kayıt eklendi");
            }
        }
    }
}

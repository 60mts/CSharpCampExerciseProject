using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericIntro
{
        class myList<T> 
    {
        T[] items;    // t array'i oluşturdum
        public myList()
        {
            items = new T[0];   
            //array'a eleman eklemem için new'lemem gerek.
        }
        public void Add(T item)
        {                           
            //newlemeden önce uçmaması için içindekilerin geçiçi arraya atıyorum.
            T[] tempArray = items;
            items = new T[ items.Length+1];   
            // arayin değerini +1 arttırıyorum.


            //geçici array'den verileri items'ımıza tekrar aktarıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //aslında eklenmek istenen eleman asıl şimdi eklendi
            items[items.Length - 1]=  item;
            //items arrayının uzunluğunun bir eksiği 6 elemanlıysa bir eksiği 5 ,
            //sıfırdan başlıyor.
        }
    }
}

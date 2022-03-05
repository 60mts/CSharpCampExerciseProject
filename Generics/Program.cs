using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        //Listeler Collections'lardır.
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();

                sehirler.Add("Ankara");

                sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count);
           
            MyList<string> sehirler2 = new MyList<string>();

                sehirler2.Add("Ankara");

                sehirler2.Add("Ankara");

                sehirler2.Add("Ankara");

                sehirler2.Add("Ankara");

                sehirler2.Add("Ankara");

            Console.WriteLine(sehirler2.Count);

            //buradaki tip hangisini kullanırsanız ona dönüşüyor.
        }
        class MyList 

            //generics olmayan yapi
        {

        }
        class MyList<T> 

            //<T> type'dan gelmekte ve hangi tip gönderirsen ona dönüşüyor. //generic Class 
        {
          
            T[] _array;

            T[] _tempArray;

            public MyList()
            {
               _array = new T[0]; 
            }
            public void Add(T item)
            {
                T[] _tempArray = _array;  
                
                //tempArray Arrayın referansını tutuyor ve verilerin uçmasını engelliyor.
               
                _array=new T[_array.Length+1];

                for (int i = 0; i <_tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length-1] = item;
            }

            public int Count
            {
                get { return _array.Length; }
              
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // tip "T"olarak yazdık
    //item eleman demek
    class MyList<T>
    {
        T[] items;
        //constructor="kurucu"demek
        public MyList()
        {
            items = new T[0];
        }
        //eleman item demek
        //array dizi
        public void Add(T item)
        {
            //geciciDizi tempArray
            T[] tempArray = items;
            //diziye eleman eklemek
            items = new T[items.Length+1];//elemanlarıbir artırmak
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}

using System;

namespace Mert
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Antalya");
            sehirler.Add("Ardahan");
            sehirler.Add("Afyon");
            sehirler.Add("Antep");
            sehirler.Add("Adana");
            sehirler.Add("Antakya");
            sehirler.Add("Aydın");
            sehirler.Add("Artvin");
            sehirler.Add("Amasya");
            sehirler.Add("Ağrı");
            sehirler.Add("Aksaray");
            sehirler.Add("Adıyaman");
            Console.WriteLine("Türkiye' de " + sehirler.Count + " tane a ile başlayan il vardır");
            Console.WriteLine("1)" + sehirler.Items[0]);
            Console.WriteLine("2)" + sehirler.Items[1]);
            Console.WriteLine("3)" + sehirler.Items[2]);
            Console.WriteLine("4)" + sehirler.Items[3]);
            Console.WriteLine("5)" + sehirler.Items[4]);
            Console.WriteLine("6)" + sehirler.Items[5]);
            Console.WriteLine("7)" + sehirler.Items[6]);
            Console.WriteLine("8)" + sehirler.Items[7]);
            Console.WriteLine("9)" + sehirler.Items[8]);
            Console.WriteLine("10)" + sehirler.Items[9]);
            Console.WriteLine("11)" + sehirler.Items[10]);
            Console.WriteLine("12)" + sehirler.Items[11]);
            Console.WriteLine("13)" + sehirler.Items[12] + "' dır");
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for(int i=0;i<_tempArray.Length;i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }
        public T[] Items
        {
            get { return _array; }
        }
    }
}

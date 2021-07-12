using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSEnumeratorEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var temps = new List<Tempreture>();

            Random rnd = new Random();
            for(var i = 0; i < 100; i++)
            {
                temps.Add(new Tempreture(rnd.Next(-30, 50)));
            }

          

            temps.Sort();

            foreach (var item in temps)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    } 
    
    class Tempreture: IComparable
    {
        private int _value;

        public Tempreture(int value)
        {
            _value = value;
        }
        public int Value => _value;

        public int CompareTo(object obj)
        {
            if (obj is null)
                return 1;
            var temp = obj as Tempreture;
            
            if (temp is null)
                throw new ArgumentException("object is not a tempreture object");

            return this._value.CompareTo(temp._value);
        }
    }
}

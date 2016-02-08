using System;
using System.Runtime.InteropServices;

namespace SingleTon
{
    class Program
    {
        public static void Main(string[] args)
        {
            var obj1 = Singleton.Instance();            // protected Constructor so cannot use new
            var obj2 = Singleton.Instance();
             
            // Test for same instance
            if (obj1 == obj2)
                Console.WriteLine("Objects are the same instance"); 
            Console.ReadKey();
        } 
    }

    class Singleton
    {
        private static Singleton _instance;

        protected Singleton() { }

        public static Singleton Instance()
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }
}

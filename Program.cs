using System;

namespace delegate_event
{
    //public delegate тип_возвращаемого значения имя_делегата(тип_аргумента агрумент);
    public delegate void MyDelegate(); //сигнатура метода
    internal class Program
    {
        public Action ActionDelegate;
        public delegate int ValueDelegate(int i);
        static void Main(string[] args)
        {
            #region делегаты без аргументов
            //MyDelegate myDelegate = Method1;
            //myDelegate += Method4;
            //myDelegate();
            //Console.WriteLine("=====================");
            //MyDelegate myDelegate2 = new MyDelegate(Method4);
            //myDelegate2 += Method4;
            //myDelegate2 += Method1;
            //myDelegate2.Invoke();
            //Console.WriteLine("=====================");
            //myDelegate2 -= Method4;
            //myDelegate2();
            //Console.WriteLine("=====================");
            //MyDelegate myDelegate3 = myDelegate + myDelegate2;
            //myDelegate3.Invoke();
            //Console.WriteLine("=====================");
            //MyDelegate myDelegate4 = myDelegate2 + myDelegate;
            //myDelegate4();
            #endregion
            //var valueDelegate = new ValueDelegate(Method2);
            //valueDelegate += MethodValue;
            //var a = valueDelegate((new Random()).Next(10, 50));
            //Console.WriteLine("=================");
            //Console.WriteLine(a);

            Action<int> action = Method3;
            action(11);


            Console.ReadLine();
        }

        static void Method (int i) //сигнатура метода это void и int
        {

        }

        static void abccccc(int asdasd) //сигнатура метода это void и int
        {

        }

        static float res(float num) //сигнатура метода это floar и floar (а может и нет)  
        {
            return num;
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine($"Mehod value {i}.");
            return i;
        }

        public static void Method1()
        {
            Console.WriteLine("Method 1\n");
        }
        public static int Method2(int i)
        {
            Console.WriteLine($"Method 2/ {i*2}.");
            return i;
        }
        public static void Method3(int i)
        {
            Console.WriteLine("Method 3\n");
        }
        public static void Method4()
        {
            Console.WriteLine("Method 4\n");
        }
        
    }
}

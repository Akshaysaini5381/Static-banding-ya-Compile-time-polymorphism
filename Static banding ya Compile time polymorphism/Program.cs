using System;

namespace Static_banding_ya_Compile_time_polymorphism
{
    class MyClass
    {
        public  void show()
        {
            Console.WriteLine("Hello :");
        }
    }


    class Program : MyClass
    {
        public new  void show()
        {
            Console.WriteLine("Hii :");
        }
        static void Main(string[] args)
        {
            MyClass obj = new Program();
            obj.show();
        }
    }

}

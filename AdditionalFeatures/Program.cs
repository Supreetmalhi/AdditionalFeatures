using System;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const int a = 13;
            var  name = "supreet";
            Console.WriteLine(a + name);

            Product _product= new Product(1,"Shoes");
            Product _product2 = new Product(2,0,"Belt");
        }
    }
}

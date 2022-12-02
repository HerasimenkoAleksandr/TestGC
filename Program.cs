using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using static System.Console;


namespace TestGC
{ 
    public class Play:IDisposable
    {
        public string NamePlay { get; set; }
        public string Writer { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public Play()
        {
            NamePlay = "Ромео и Джульетта";
            Writer = "Уильям Шекспир";
            Genre = "Драма";
            Year = new DateTime(1595, 1, 1);
        }
        public override string ToString()
        {
            return $"название пьесы: {NamePlay}\nавтор: {Writer}\nжанр: {Genre}\nгод выпуска: {Year.Year}";
        }
    public void Dispose()
        {
            Console.WriteLine("Отработал Dispose класса Play");
        }
        public void Information_About_Play()
        {
            Console.WriteLine("this");
        }
         ~Play()
         {
             Console.WriteLine("Отработал финализатор класса Play");
         }
       
    }

    public  class Shop : IDisposable
    {
        public string NameShop { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public Shop(string a, string b, string c)
        {
            NameShop = a;
            Address = b;
            Type = c;
        }
        public override string ToString()
        {
            return $"Название магазина: {NameShop}\nАдрес: {Address}\nТиа: {Type}";
        }
        public  void Dispose()
        {
            Console.WriteLine("Отработал Dispose класса Shop");
        }
        public  void Information_About_Shops()
        {
            Console.WriteLine($"Название магазина {NameShop}\nАдрес: {Address}\nТип товара: {Type}");
        }
        ~Shop()
        {
            Console.WriteLine("Отработал финализатор класса Shop");
        }

    }
    


    class Program
{
        static void Main(string[] args)
        {
          
            Play A = new Play();
            Console.WriteLine(A);
            A.Dispose();

            Console.WriteLine();
            Shop B = new Shop("Фокстрот",  "Летчиков", "Магазин бытовой техники") ;
            Console.WriteLine(B);
            B.Dispose();
            Console.WriteLine();


        }
 }
}
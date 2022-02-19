using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayıyı giriniz:");
                int sayi =Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata:"+ ex.Message.ToString());
                
            }
          //finally
          //{ 
          //  Console.WriteLine("İşlem Tamamlandı");
          //}
            try
            {
               // int a =int.Parse(null);
              // int a =int.Parse("test");
              int a =int.Parse("-200000000");

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
          { 
           Console.WriteLine("İşlem Tamamlandı");
          }
        }
    }
}

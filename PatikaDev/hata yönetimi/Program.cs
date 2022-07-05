using System;

namespace hata_yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş olduğunuz sayi :"+ sayi);
                
            } 
            catch(Exception ex)
            {
                Console.WriteLine("Hata:"+ex.Message.ToString());
                      

            }
            /*finally
            {
                Console.WriteLine("işlem tamamlandı");
            }*/
           

            try
            {
                int a = int.Parse(null);    
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
        }
    }
}

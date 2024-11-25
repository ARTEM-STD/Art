using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введиет число из диапозона int");
            
            int min = 1;
            int max = 100;
           
                try
                {string input = Console.ReadLine();
                    int nam = int.Parse(input);
                    if (nam <= min || nam >= max)
                    {
                    throw new ArgumentOutOfRangeException();
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Некорректный формат ввода. Пожалуйста, введите целое число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");

                }
                finally
                {
                
                    Console.WriteLine("Число входит в диапозон");
                }
            Console.ReadLine();
        }
        
       
                
        
    }
}

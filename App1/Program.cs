using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace App1
{
    class Program
    {
        /*Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.*/
        static void Main(string[] args)
        {
            {
                Console.Write("Введите значение N для расчета факториала - ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Значение N! = {FactCalclAsync(n).Result}");
                Console.ReadKey();
            }
            
        
            
        }
   

        static async Task<int> FactCalclAsync(int n) //Метод для асинхронного расчета
        {
            int res = await Task.Run(() => FactCalc(n)); //Асинхронный запуск
            return res;
        }
        static int FactCalc(int n) //Расчетный метод
        {
            if (n == 0)
                return 1;
            else
                return n * FactCalc(n - 1); // Рекурсивный вызов функции
        }
    }
}

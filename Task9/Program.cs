using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");

            try
            {
                Console.Write("Введите целое число. Х=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("1-сложение");
                Console.WriteLine("2-вычитание");
                Console.WriteLine("3-умножение");
                Console.WriteLine("4-деление");
                Console.Write("Ваш выбор:");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат = {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат = {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат = {0}", x / y);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}

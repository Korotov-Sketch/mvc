using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MyProgram
{
	class Program
	{
		public static void Main()
		{
            StreamReader input = new StreamReader("input.txt");
			int n = int.Parse(input.ReadLine());
			Function[] Lin = new Function[n];
            int h = 0;

            Console.WriteLine("Введите значение от которого будем считать функцию");
            int z = int.Parse(Console.ReadLine());
            string s;
			for (int i = 0; i < n; i++)
			{
                s = input.ReadLine();
                string[] j = s.Split(' ');
                if (j.Length == 2)//Проверка на длинну
                {
                    Console.WriteLine("Исходные значения a={0},b={1}, не подходит для Куба. Выберите тип",j[0],j[1]);
                }
                else if (j.Length == 3)//для куба
                {
                    Console.WriteLine("Исходные значения a={0},b={1},c={2}. У вас Куб",j[0],j[1],j[2]);
                }

                    Console.WriteLine("Что хотим посчитать? Линию - 1 Куб - 2 или Гиперболу - 3?");
                h = int.Parse(Console.ReadLine()); //Вводим что хотим посчитать

                if (h == 1)//линия
                {

                    Lin[i] = new Line(int.Parse(j[0]), int.Parse(j[1]));
                    Lin[i].Func(z);
                }
                else if (h == 2)//куб
                {

                   
                    Lin[i] = new Kub(int.Parse(j[0]), int.Parse(j[1]), int.Parse(j[2]));
                    Lin[i].Func(z);
                }
                else if (h == 3)//гипер
                {

                    Lin[i] = new Hyperbola(int.Parse(j[0]), int.Parse(j[1]));
                    Lin[i].Func(z);
                }


            }
			Array.Sort(Lin);//сортировка

            Console.WriteLine("x = {0}",z);//выводим значение икса
			for (int i = 0; i < n; i++) // вывод значений функции
			{
                Lin[i].Show();
				Console.WriteLine(" f(x) = {0}",Lin[i].y);

			}

		}
	}
}
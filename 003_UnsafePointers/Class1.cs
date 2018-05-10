using System;

namespace Pointers
{
	class Class1
	{
        // Неуправляемый код.
		unsafe static void TestPointer() 
		{
			int *p;	 // Указатель.
			int i;   // Переменная.

			i = 10;  // Инициализация переменной.
			p = &i;  // Указатель на переменную.


			// Выводим значение переменной i напрямую и через указатель *p.
			Console.WriteLine(i);
			Console.WriteLine(*p);
			Console.WriteLine("----------");

			// Присваиваем значение 333 переменной - i, через указатель - *p.
			*p = 333;
			Console.WriteLine(i);
			Console.WriteLine(*p);
			Console.WriteLine("----------");

			// Изменяем переменную через собственный указатель. (&i - взятие адреса переменной i)
			i = *(&i) + 10;
			Console.WriteLine(i);
			Console.WriteLine(*p);
		}

		[STAThread]
		static void Main(string[] args)
		{
			TestPointer();

            // Задержка.
			Console.ReadKey();
		}
	}
}

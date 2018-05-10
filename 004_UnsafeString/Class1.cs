using System;

namespace UnsafeString
{
    class Class1
    {
        // Преобразование символов в верхний регистр.
        public static unsafe void MyToUpper(string str)
        {
            // fixed - запрещает Сборщику Мусора, перемещать объекты на которые указывает указатель, т.л. изменятся адреса! 
            fixed (char* pfixed = str)
                for (char* p = pfixed; *p != 0; p++)
                    *p = char.ToUpper(*p);
                
        }

        [STAThread]
        static void Main(string[] args)
        {
            string str = "test строка";

            MyToUpper(str);
            Console.WriteLine(str);

            // Задержка.
            Console.ReadKey();

        }
    }
}

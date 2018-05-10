using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;



namespace ConsoleApplication1
{
    class Program
    {
         static public void Menu(ConsoleKey key)
        {
            Console.WriteLine(@"1.Start
                                2.Set time out
                                3.Send to email
                                4.Hide
                                5.Exit");
            switch (key)
            {               
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.D0:
                    Console.WriteLine("Hello");
                    break;
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    break;
                case ConsoleKey.NumPad0:
                    break;
                case ConsoleKey.NumPad1:
                    break;
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.NumPad4:
                    break;
                case ConsoleKey.NumPad5:
                    break;
                case ConsoleKey.NumPad6:
                    break;
                case ConsoleKey.NumPad7:
                    break;
                case ConsoleKey.NumPad8:
                    break;
                case ConsoleKey.NumPad9:
                    break;
                
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            ConsoleKey key;
            key = Console.ReadKey().Key;
            Menu(key);


        }
    }
}

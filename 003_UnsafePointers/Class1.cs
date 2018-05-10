using System;

namespace Pointers
{
	class Class1
	{
        // ������������� ���.
		unsafe static void TestPointer() 
		{
			int *p;	 // ���������.
			int i;   // ����������.

			i = 10;  // ������������� ����������.
			p = &i;  // ��������� �� ����������.


			// ������� �������� ���������� i �������� � ����� ��������� *p.
			Console.WriteLine(i);
			Console.WriteLine(*p);
			Console.WriteLine("----------");

			// ����������� �������� 333 ���������� - i, ����� ��������� - *p.
			*p = 333;
			Console.WriteLine(i);
			Console.WriteLine(*p);
			Console.WriteLine("----------");

			// �������� ���������� ����� ����������� ���������. (&i - ������ ������ ���������� i)
			i = *(&i) + 10;
			Console.WriteLine(i);
			Console.WriteLine(*p);
		}

		[STAThread]
		static void Main(string[] args)
		{
			TestPointer();

            // ��������.
			Console.ReadKey();
		}
	}
}

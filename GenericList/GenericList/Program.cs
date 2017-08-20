using System; using System.Collections.Generic;  namespace GenericList {
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] a = new int[4] { 1, 2, 3, 4 };
			int[] b = new int[4];

			int index = 0;

			a.CopyTo(b, index);
			foreach (int elements in a)
				Console.WriteLine(a[elements]);
			Console.ReadLine();
		}
	} } 

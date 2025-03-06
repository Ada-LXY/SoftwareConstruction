using System;
using System.Collections.Generic;

namespace Task1 {
	class Program {
		static List<int> GetFactors(int ob) {
			List<int> factors = new List<int>();
			for (int i = 2; i * i <= ob; i++) {
				if (ob % i == 0) {
					factors.Add(i);
					while (ob % i == 0) {
						ob /= i;
					}
				}
			}
			if (ob != 1) {
				factors.Add(ob);
			}
			return factors;
		}
		static void Main(string[] args) {
			int ob;
			bool input = int.TryParse(Console.ReadLine(), out ob);
			if (input == false) {
				Console.WriteLine("Error Input");
				return;
			}
			var factors = GetFactors(ob);	
			Console.WriteLine(string.Join(" ", factors));
		}
	}
}
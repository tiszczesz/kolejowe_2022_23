﻿namespace MVC_first_v2.Models
{
	public class MyNWD
	{
		public int? A { get; set; }
		public int? B { get; set; }

		public int? Result { get; set; }

		public int? NWDRec(int? a, int? b) {
			if (b == 0) return a;
			return NWDRec(b, a % b);
		}

		public void Count()
		{
			Result = NWDRec(A, B);

		}

		public void RecCount()
		{
			Result = NWDIter(A,B);
		}

		private int? NWDIter(int? a, int? b)
		{
			int? temp = a;
			while (b != 0)
			{
				temp = a;
				a = b;
				b = temp % b;
			}
			return a;
		}
	}
}

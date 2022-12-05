namespace Web1.Models
{
	public class NWD
	{
		public static int NWDRec(int a, int b)
		{
			if (b == 0) return a;
			return NWDRec(b, a % b);
		}
        public static int NWDIter(int a, int b)
        {
			int temp = a;
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

namespace WebRazorPageGames.Models
{
    public class Nwd
    {
        public static int NwdRec(int a, int b)
        {
            if (b == 0) return a;
            return NwdRec(b, a % b);
        }
        public static int NwdIter(int a, int b)
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

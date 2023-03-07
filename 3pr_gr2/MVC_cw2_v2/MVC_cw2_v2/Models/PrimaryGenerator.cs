namespace MVC_cw2_v2.Models
{
    public class PrimaryGenerator
    {
        public int? N { get; set; }
       

        public bool IsPrimal(int a)
        {
            if(a<2) return false;
            for(int i = 2; i * i <= a; i++)
            {
                if(a%i == 0) return false;
            }
            return true;
        }
        public List<int> GetPrimals(int limit)
        {
            var list = new List<int>();
           
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrimal(i)) list.Add(i);
            }
            return list;
        }
    }
}

namespace cw6_RazorWithModel.Models
{
    public class RepoBooks
    {
        public List<Book> Books { get; set; }
        public int LastId { get; private set; }
        public RepoBooks()
        {
            LoadFromFile();
        }
        public void SaveToFile(Book book,string fileName="book.txt")
        {
            StreamWriter file = new StreamWriter(fileName, append: true);
            file.WriteLine($"{book.Id}|{book.Title}|{book.Author}|{book.Date.ToShortDateString()}");
            file.Close();
        }
        public void LoadFromFile(string filename = "book.txt")
        {
            List<string> result = new List<string>();
            if (File.Exists(filename))
            {
                if (Books == null) Books = new List<Book>();
                result = File.ReadAllLines(filename).ToList(); 
                foreach (string line in result)
                {
                    Book b = lineToBook(line);
                    if (b != null) Books.Add(b);
                }
                LastId = Books.Max(b => b.Id);
            }
            else
            {
                result = new List<string>();
                LastId = 0;
            }
                      
        }
        private Book lineToBook(string line)
        {
            var data = line.Split("|");
            Book b = null;
            if (data.Length == 4)
            {
                try
                {
                 b = new Book
                                {
                                    Id = Convert.ToInt32(data[0]),
                                    Title = data[1],
                                    Author = data[2],
                                    Date = Convert.ToDateTime(data[3])
                                };
                  
                }catch(FormatException ex)
                {
                    return null;
                }
                
            }
            return b;
        }

    }
}

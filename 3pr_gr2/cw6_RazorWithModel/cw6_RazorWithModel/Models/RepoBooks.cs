namespace cw6_RazorWithModel.Models
{
    public class RepoBooks
    {
        public List<Book> Books { get; set; }
        public int LastId { get; }

        public void SaveToFile(string fileName,Book book)
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
                result = File.ReadAllLines(filename).ToList();
            }
            
        }

    }
}

namespace cw6_RazorWithModel.Models
{
    public class RepoBooks
    {
        public List<Book> Books { get; set; }

        public void SaveToFile(string fileName,Book book)
        {
            StreamWriter file = new StreamWriter(fileName, append: true);
            file.WriteLine($"{book.Id}|{book.Title}|{book.Author}|{book.Date}");
            file.Close();
        }
    }
}

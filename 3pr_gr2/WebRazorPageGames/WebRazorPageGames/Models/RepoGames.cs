namespace WebRazorPageGames.Models
{
    public class RepoGames
    {
        public List<Game> Games { get; set; }
        public void GenerGames()
        {
            Games = new List<Game>();
            Games.Add(
                new Game {
                    Id=1,
                    Title="Wiedźmin 3",
                    Category="RPG" 
                    ,ReleaseDate=new DateTime(2018,3,12)
                });
            Games.Add(
                new Game
                {
                    Id = 2,
                    Title = "FIFA 2022",
                    Category = "Symulator"
                    ,
                    ReleaseDate = new DateTime(2022, 4, 23)
                });
            Games.Add(
                new Game
                {
                    Id = 3,
                    Title = "Wiedźmin 2",
                    Category = "RPG"
                    ,
                    ReleaseDate = new DateTime(2015, 3, 12)
                });
            Games.Add(
                new Game
                {
                    Id = 4,
                    Title = "Diablo 3",
                    Category = "RPG" ,
                    ReleaseDate = new DateTime(2021, 3, 12)
                });
            Games.Add(
               new Game
               {
                   Id = 5,
                   Title = "Jaś i Małgosia 3",
                   Category = "RPG",
                   ReleaseDate = new DateTime(2016, 3, 12)
               });
            Games.Add(
               new Game
               {
                   Id = 6,
                   Title = "Diablo 4 beta",
                   Category = "RPG",
                   ReleaseDate = new DateTime(2022, 3, 12)
               });
        }
    }
}

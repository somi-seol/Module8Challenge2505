namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5});
            games.Add(new VideoGame { Name = "Signalis", Genre = "Survival", Rating = 4.9});
            games.Add(new VideoGame { Name = "Arena Breakout Infinite", Genre = "Extraction", Rating = 4.2});
            games.Add(new VideoGame { Name = "Valorant", Genre = "Tactical", Rating = 3.9});
            games.Add(new VideoGame { Name = "My Summer Car", Genre = "Simulation", Rating = 3.1});

            var topRatedGames = (from game in games
                     where game.Rating >= 4
                     select game).ToList();

            var sortedGames = (from game in topRatedGames
                   orderby game.Name
                   select game).ToList();

            foreach (var game in sortedGames)
            {
                Console.WriteLine("Games sorted by rating above 4.0:")
                Console.WriteLine(game.Name);
            }
        }
    }
}
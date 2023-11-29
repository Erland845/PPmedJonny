namespace PPmedJonny
{
    public class Movie
    {
        string Title { get; set; }
        int PublishYear { get; set; }
        string Description { get; set; }
        string Director { get; set; }
        string[] Actors { get; set; }
        
        public Movie(string _title, int _year, string _desc, string _director, string[] _actors)
        {
            Title = _title;
            PublishYear = _year;
            Description = _desc;
            Director = _director;
            Actors = _actors;
        }

        public void printInfo()
        {
            Console.WriteLine($"Movie Title: {Title}");
            Console.WriteLine($"Year Published: {PublishYear}");
            Console.WriteLine($"Director: {Director}\n");
            Console.Write($"Actors: ");
            for (int i=0; i<Actors.Length; i++) {
                if (i == Actors.Length)
                {
                    Console.Write($"{Actors[i]} \n");
                }
                else
                {
                    Console.Write($"{Actors[i]}, ");
                }
            }

            Console.WriteLine($"Description: \n{Description}\n\n");
        }
    }
}
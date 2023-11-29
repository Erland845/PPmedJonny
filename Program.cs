namespace PPmedJonny
{
    internal class Program
    {
        public static List<Movie> ListofMovies = new List<Movie>();

        static void Main()
        {
            //PersonOppgave();
            MovieOppgave();
        }

        static void PersonOppgave()
        {
            string[] _hobby = { "Jeg trener bjj og submission wrestling", "Jeg har interesse for musikk, politikk, psykologi og diverse" };
            Person Erland = new Person("Erland", 22, "blondt", _hobby);

            string[] _hobby2 = { "Jeg spiller Final Fantasy 14", "Jeg programmerer i fritiden" };
            Person Johnny = new Person("Johnny", 31, "kort svart", _hobby2);

            Erland.printInfo();
            Johnny.printInfo();
        }

        static void MovieOppgave()
        {
            Console.WriteLine("Hva heter filmen?");
            var _title = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hvilke år ble filmen lagt ut?");
            int _year = Convert.ToInt32( Console.ReadLine() );
            Console.Clear();

            Console.WriteLine("Hvem var regissøren?");
            var _director = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hvilke skuespillere er i filmen: eks (Robert Downey,Keanu Reeves)");
            string _actorinput = Console.ReadLine();
            string[] _actors = _actorinput.Split(',');
            Console.Clear();

            Console.WriteLine("Beskriv filmen:");
            var _desc = Console.ReadLine();
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Vil du legge til en film til? y/n");
            var input = Console.ReadLine();

            Movie _movie = new Movie(_title, _year, _desc, _director, _actors);
            ListofMovies.Add(_movie);

            if (input == "y")
            {
                MovieOppgave();
            } 
            else if (input == "n")
            {
                Console.Clear();

                foreach (Movie _themovie in ListofMovies)
                {
                    _themovie.printInfo();
                }
            }
              

        }
        /*
        Title = _title;
        PublishYear = _year;
        Description = _desc;
        Director = _director;
        Actors = _actors;
        */
    }
}
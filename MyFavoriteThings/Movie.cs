using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    internal class Movie
    {
        private DateTime _timeStartedWatching;
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public List<string> Actors { get; set; } = new List<string>();
        public int WatchTimeMinutes { get; set; }
        public void Watch()
        {
            _timeStartedWatching = DateTime.Now;
            Console.WriteLine($"You started watching {Title} at {_timeStartedWatching} and will need {WatchTimeMinutes} minutes to finish the movie.");
        }
        public void FinishWatching()
        {
            TimeSpan timeWatched = DateTime.Now - _timeStartedWatching;
            bool Finished = timeWatched.TotalMinutes > WatchTimeMinutes;
            string response = Finished ? $"{Title} is all done!" : "$You still have more movie to watch.";
            Console.WriteLine(response);
        }
    }
}

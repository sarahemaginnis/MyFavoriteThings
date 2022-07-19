using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    internal class Game
    {
        public Game(string name, string type, int numberOfPlayers)
        {
            Name = name;
            Type = type;
            NumberOfPlayers = numberOfPlayers;
        }
        public bool _inProgress { get; set; } //default value of a boolean is false, so this will start out false
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfPlayers { get; set; }
        public void Start()
        {
            Console.WriteLine($"It's time to play {Name}!");
        }
        public void GameOver()
        {
            _inProgress = false;
            Console.WriteLine("Yikes, what a way to go out!");
        }
    }
}

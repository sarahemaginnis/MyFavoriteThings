using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    internal class Cat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFavorite { get; set; }
        public void PetTheCat()
        {
            Console.WriteLine($"It's time to pet {Name}");
        }
    }
}

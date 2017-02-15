using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cds = new CD
            {
                Artist = "Witt Lowry",
                Album = "Dreaming With Our Eyes Open",
                Price = 1337
            };

            List<Song> songs = new List<Song>();

            songs.Add(new Song { Name = "Dreaming With Our Eyes Open", Lenght = "3:07" });
            songs.Add(new Song { Name = "Ladders", Lenght = "3:45" });
            songs.Add(new Song { Name = "My Mistake", Lenght = "4:24" });
            songs.Add(new Song { Name = "Wonder If You Wonder", Lenght = "3:55" });
            songs.Add(new Song { Name = "Tried to Be Nice", Lenght = "4:11" });
            songs.Add(new Song { Name = "Silicone Kingdom", Lenght = "5:21" });
            songs.Add(new Song { Name = "Tourist", Lenght = "3:39" });
            songs.Add(new Song { Name = "Piece of Mind 3", Lenght = "3:33" });
            songs.Add(new Song { Name = "So Many Nights", Lenght = "3:34" });
            songs.Add(new Song { Name = "Running from Here", Lenght = "4:48" });
            songs.Add(new Song { Name = "Coupons", Lenght = "4:26" });

            Console.WriteLine(cds.ToString());

            foreach (Song s in songs)
                {
                    Console.WriteLine(" - - < {0}, {1}", s.Name, s.Lenght);
                }

            Console.WriteLine();
        }
    }
}

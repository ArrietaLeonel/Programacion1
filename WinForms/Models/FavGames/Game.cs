using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models.FavGames
{
    public class Game
    {
        public string? _id { get; set; }
        public string title { get; set; }
        public string platform { get; set; }
        public string genre { get; set; }
        public string imageUrl { get; set; }
        public int releaseYear { get; set; }
    }
}

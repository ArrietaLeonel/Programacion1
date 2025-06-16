using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models.Pelicula
{
    public class Movie
    {
        public string? _id { get; set; }
        public string title { get; set; }
        public int duration { get; set; }
        public string cover { get; set; }
        public float qualification { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models.PokeApi
{
    public class Pokemon
    {

        public List<Ability> Abilities { get; set; }
        public Sprite Sprites { get; set; }

        public List<Stat> Stats { get; set; }
    }
}

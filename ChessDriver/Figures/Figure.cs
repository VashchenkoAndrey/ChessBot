﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDriver.Figures
{
    public class Figure
    {
        public string ImgPath = "";
        public double Weight { get; set; }
        public int[] Coord { get; set; }
    }
}
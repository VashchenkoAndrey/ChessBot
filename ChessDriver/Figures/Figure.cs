﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDriver.Figures
{
    /*public enum ChessColor
    { BLACK,WHITE };*/
    public class Figure
    {
        //public ChessColor = ChessColor.
        public bool IsWhite { get; set; }
        public string ImgPath = "";
        public double Weight { get; set; }
        public int[] Coord { get; set; }
    }
}

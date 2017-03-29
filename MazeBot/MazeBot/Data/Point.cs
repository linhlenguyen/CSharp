using System;
using System.Collections.Generic;

namespace MazeBot.Data
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "(" + X.ToString() + ", " + Y.ToString() + ")";
        }

        public override bool Equals(object obj)
        {
            return ((Point)obj).X == X && ((Point)obj).Y == Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}

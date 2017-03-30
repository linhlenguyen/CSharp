using MazeBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBot.Data
{
    public class Maze
    {
        private char[][] maze;
        
        public Maze(string[] input)
        {
            maze = new char[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                var filterredRow = input[i].Where(x => (x == '0') || (x == '1')).ToArray();
                char[] row = new char[filterredRow.Length];
                for (int j = 0; j < filterredRow.Length; j++)
                {
                    row[j] = filterredRow[j];
                }
                maze[i] = row; 
            }
        }

        public string Show()
        {
            var r = maze.Select(i => i.Select(j => j == '1' ? '#' : j == '0' ? ' ' : j));

            string result = "";
            foreach (IEnumerable<char> lc in r)
            {
                result += lc.Show() + '\n';
            }
            return result;
        }

        public string Show(int x, int y)
        {
            return maze[y][x].ToString();
        }

        private bool isValid(int x, int y)
        {
            if ((y >= 0 && y < (maze.Length)) && (x >= 0 && x < maze[y].Length))
            {
                return maze[y][x] == '0';
            }
            return false;
        }
        
        public List<Point> GetSurroundings(Point p)
        {
            List<Point> results = new List<Point>();
            if (isValid(p.X, p.Y - 1))
            {
                results.Add(new Point(p.X, p.Y - 1));
            }
            if (isValid(p.X, p.Y + 1))
            {
                results.Add(new Point(p.X, p.Y + 1));
            }
            if (isValid(p.X - 1, p.Y))
            {
                results.Add(new Point(p.X -1, p.Y));
            }
            if (isValid(p.X + 1, p.Y))
            {
                results.Add(new Point(p.X + 1, p.Y));
            }
            return results;
        }

        public void ModifyWithPath(List<Point> path)
        {
            maze[path[0].Y][path[0].X] = 'S';
            for (int i = 1; i < path.Count - 1; i++)
            {
                maze[path[i].Y][path[i].X] = 'X';
            }
            maze[path[path.Count - 1].Y][path[path.Count - 1].X] = 'E';
        }
    }
}

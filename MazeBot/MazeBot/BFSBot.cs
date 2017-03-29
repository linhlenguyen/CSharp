using MazeBot.Data;
using MazeBot.Utils;
using System.Collections.Generic;
using System.Linq;

namespace MazeBot
{
    public class BFSBot
    {
        private Maze _maze;
        private Point _start;
        private Point _end;
        private HashSet<Point> _visited { get; set; }
        private Queue<Point> _queue;
        private IDictionary<Point, List<Point>> _shortestPaths;

        public BFSBot(Maze maze, Point start, Point end)
        {
            _maze = maze;
            _start = start;
            _end = end;
            _visited = new HashSet<Point>();
            _queue = new Queue<Point>();
            _shortestPaths = new Dictionary<Point, List<Point>>();
            _queue.Enqueue(start);
            _shortestPaths.Add(start, new List<Point>() { start });
            solve();
        }

        public List<Point> getResults()
        {
            if (!_shortestPaths.ContainsKey(_end))
            {
                return null;
            }
            else return _shortestPaths[_end];
        }
        
        public string ShowAllPaths()
        {
            string result = "";
            foreach (KeyValuePair<Point, List<Point>> kvp in _shortestPaths)
            {
                result += kvp.Key.X + " " + kvp.Key.Y + " - ";
                result += kvp.Value.Show() + "\n";
            }
            return result;
        }

        private void solve()
        {
            while (true)
            {
                var p = _queue.Dequeue();
                explore(p);
                if (_queue.Contains(_end) || _queue.Count == 0)
                {
                    break;
                }
            }
        }

        private void explore(Point p)
        {
            _visited.Add(p);
            var surroundings = _maze.GetSurroundings(p).Where(i => !_visited.Contains(i));
            foreach (Point pt in surroundings)
            {
                if (!_shortestPaths.ContainsKey(pt))
                {
                    List<Point> path = _shortestPaths[p].Select(i => new Data.Point(i.X, i.Y)).ToList();
                    path.Add(pt);
                    _shortestPaths.Add(pt, path);
                }
                if (!_queue.Contains(pt))
                {
                    _queue.Enqueue(pt);
                }
            }           
        }
    }
}

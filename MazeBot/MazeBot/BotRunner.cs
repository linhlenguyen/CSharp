using MazeBot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBot
{
    public static class BotRunner
    {
        public static string FindResult(string[] input)
        {
            var start = input[1].Split(' ').Select(i => Int32.Parse(i)).ToArray();
            var end = input[2].Split(' ').Select(i => Int32.Parse(i)).ToArray();
            var maze = new Maze(input.Skip(3).ToArray());
            var bot = new BFSBot(maze, new Data.Point(start[0], start[1]), new Data.Point(end[0], end[1]));
            var result = bot.getResults();
            if (result == null)
            {
                return "No path was found";
            }
            else
            {
                maze.ModifyWithPath(result);
                return maze.Show();
            }
        }
    }
}

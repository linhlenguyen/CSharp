using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeBot.Utils;
using MazeBot.Data;
using MazeBot;
using System.Linq;

namespace MazeBotTests
{
    [TestClass]
    public class BotTest
    {
        [TestMethod]
        public void Test1()
        {
            string[] input = FileIO.ReadLines("../../Tests/input.txt");
            FileIO.WriteToFile("../../Tests/input.out", BotRunner.FindResult(input));
        }

        [TestMethod]
        public void TestSmall()
        {
            string[] input = FileIO.ReadLines("../../Tests/small.txt");
            FileIO.WriteToFile("../../Tests/small.out", BotRunner.FindResult(input));
        }

        [TestMethod]
        public void TestMedium()
        {
            string[] input = FileIO.ReadLines("../../Tests/medium_input.txt");            
            FileIO.WriteToFile("../../Tests/medium_input.out", BotRunner.FindResult(input));
        }

        [TestMethod]
        public void TestLarge()
        {
            string[] input = FileIO.ReadLines("../../Tests/large_input.txt");
            FileIO.WriteToFile("../../Tests/large_input.out", BotRunner.FindResult(input));
        }

        [TestMethod]
        public void TestSparseMedium()
        {
            string[] input = FileIO.ReadLines("../../Tests/sparse_medium.txt");
            FileIO.WriteToFile("../../Tests/sparse_medium.out", BotRunner.FindResult(input));
        }

        [TestMethod]
        public void TestJaggedMaze()
        {
            string[] input = FileIO.ReadLines("../../Tests/jaggedMaze.txt");
            FileIO.WriteToFile("../../Tests/jaggedMaze.out", BotRunner.FindResult(input));
        }

        [TestMethod]
        public void MazeTest1()
        {
            string[] input = FileIO.ReadLines("../../Tests/input.txt");
            var maze = new Maze(input.Skip(3).ToArray());
            var validSurroundingPoints = maze.GetSurroundings(new Point(1, 1));
            Assert.AreEqual(1, validSurroundingPoints.Count);
            validSurroundingPoints = maze.GetSurroundings(new Point(0, 0));
            Assert.AreEqual(0, validSurroundingPoints.Count);
            validSurroundingPoints = maze.GetSurroundings(new Point(2, 1));
            Assert.AreEqual(2, validSurroundingPoints.Count);
            validSurroundingPoints = maze.GetSurroundings(new Point(3, 1));
            Assert.AreEqual(1, validSurroundingPoints.Count);
        }

        [TestMethod]
        public void MazeTest2()
        {
            string[] input = FileIO.ReadLines("../../Tests/input.txt");
            var maze = new Maze(input.Skip(3).ToArray());
            var point1 = new MazeBot.Data.Point(1, 1);
            Assert.AreEqual("(1, 2)",(maze.GetSurroundings(point1).Show()));
            var point2 = new MazeBot.Data.Point(2, 1);
            Assert.AreEqual("(1, 1) (3, 1)", (maze.GetSurroundings(point2).Show()));
        }
    }
}

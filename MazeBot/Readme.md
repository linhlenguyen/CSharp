# MazeBot

To run the bot, open MazeBot solution in Visual Studio and execute the tests.

This employs a version of Breath First Search and Memoization for traversing the maze and finding the shortest path from a Point A to Point B. A breath first solution is guaranteed to always find the shortest path.

Summary of the algorithm
* 1 Add the starting point to a queue.
* 2 Get the first point P in the queue 
* 3 Look at adjacent points of P (Up, Down, Left, Right) and add them to the queue if they are traversable and not already in the queue or visited
* 4 Compute the shortest path from starting point to adjacent points of P using the shortest path from starting point to P and store it in a Point to list of Point map.
  *If there's already a key with the same point in the map, there's a shorter or equivalent path presented, do nothing*
* 5 Add P to visited set
* 6 Repeat step 2 until there's no item in the queue or the end point is found
* If there is no key with the end point is found in the shortest paths Map, there is no solution. The list of points in the shortest paths Map should give all the step to reach a point

## Tests
|Test case|Time taken|Input|Output|
|---|---|---|---|
|Small| <1 ms|[in](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/small.txt)|[out](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/small.out)
|Medium| 1 ms|[in](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/medium_input.txt)|[out](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/medium_input.out)
|Large|600-800ms|[in](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/large_input.txt)|[out](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/large_input.out)
|Sparse medium| 4 ms|[in](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/sparse_medium.txt)|[out](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/sparse_medium.out)
|Jagged|<1ms|[in](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/jaggedMaze.txt)|[out](https://github.com/linhlenguyen/CSharp/blob/master/MazeBot/MazeBotTests/Tests/jaggedMaze.out)

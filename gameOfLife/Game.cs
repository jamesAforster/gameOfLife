using System;
using System.Linq;

namespace gameOfLife
{
    public class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[][] grid;
        public Game(int[][] inputGrid)
        {
            grid = inputGrid;
        }

        public int[][] newGrid()
        {
            int[][] emptyGrid = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                emptyGrid[i] = Enumerable.Repeat(0, 4).ToArray();
            }
            return emptyGrid;
        }

        public int[][] Step()
        {
            int[][] returnGrid = newGrid();

            for (int arrayIndex = 0; arrayIndex < grid.Length; arrayIndex++)
            {
                int[] array = grid[arrayIndex];
                for (int elementIndex = 0; elementIndex < array.Length; elementIndex++)
                {
                    int count = 0;
                    for (int arrayCheck = -1; arrayCheck < 2; arrayCheck++)
                    {
                        for (int elementCheck = -1; elementCheck < 2; elementCheck++)
                        {
                            try
                            {
                                if (grid[arrayIndex + arrayCheck][elementIndex + elementCheck] == 1 && !(arrayCheck == 0 && elementCheck == 0))
                                {
                                    count++;
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                            }
                        }
                    }
                    int newValue;
                    if (grid[arrayIndex][elementIndex] == 1 && count == 2 || count == 3)
                    {
                        newValue = 1;
                    }
                    else if (grid[arrayIndex][elementIndex] == 0 && count == 3)
                    {
                        newValue = 1;
                    }
                    else
                    {
                        newValue = 0;
                    }
                    returnGrid[arrayIndex][elementIndex] = newValue;
                }
            }
            return returnGrid;
        }
    }
}

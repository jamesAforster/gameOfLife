using System;
using System.Linq;

namespace gameOfLife
{
    public class Game
    { 
    public int[][] grid;

        public Game(int[][] inputGrid)
        {
            grid = inputGrid;
        }

        public int[][] newGrid()
        {
            int[][] emptyGrid = new int[4][];
            emptyGrid[0] = new int[] { 0, 0, 0, 0 };
            emptyGrid[1] = new int[] { 0, 0, 0, 0 };
            emptyGrid[2] = new int[] { 0, 0, 0, 0 };
            emptyGrid[3] = new int[] { 0, 0, 0, 0 };
            return emptyGrid;
        }

        public int[][] Step()
        {
            int[][] returnGrid = newGrid();
            int rowIndex = 0;
            foreach (int[] row in grid)
            {
                int elementIndex = 0;
                foreach (int i in row)
                {
                    int count = 0;
                        try
                        {
                            if (row[elementIndex + 1] == 1)
                            {
                                count += 1;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (row[elementIndex - 1] == 1)
                            {
                                count += 1;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (grid[rowIndex + 1][elementIndex] == 1)
                            {
                                count += 1;
                            }

                        }
                        catch
                        {

                        }
                        try
                        {
                            if (grid[rowIndex - 1][elementIndex] == 1)
                            {
                                count += 1;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (grid[rowIndex + 1][elementIndex + 1] == 1)
                            {
                                count += 1;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (grid[rowIndex + 1][elementIndex - 1] == 1)
                            {
                                count += 1;
                            }

                        }
                        catch
                        {

                        }
                        try
                        {
                            if (grid[rowIndex - 1][elementIndex + 1] == 1)
                            {
                                count += 1;
                            }
                        }
                        catch
                        {

                        }
                        try
                        {
                            if (grid[rowIndex - 1][elementIndex - 1] == 1)
                            {
                                count += 1;
                            }
                        }
                        catch
                        {

                        }

                        if (i == 1)
                        {
                            if (count < 2)
                            {
                                returnGrid[rowIndex][elementIndex] = 0;
                            }
                            else if (count == 2 || count == 3)
                            {
                                returnGrid[rowIndex][elementIndex] = 1;
                            }
                            if (count > 3)
                            {
                                returnGrid[rowIndex][elementIndex] = 0;
                            }
                        }
                        if ( i == 0 )
                        {
                            if (count == 3)
                            {
                                returnGrid[rowIndex][elementIndex] = 1;
                            }
                        }
                    elementIndex++;
                }
                rowIndex++;
            }
            return returnGrid;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;

namespace minesweeperHiraaaa
{
    public class Utils
    {
        public static void Draw(int grid_size, char[,] grid)
        {
            // Display the grid
            for (int i = 0; i < grid_size; i++)
            {
                for (int j = 0; j < grid_size; j++)
                    Console.Write(grid[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static char[,] GenerateBomb(char[,] grid, int grid_size)
        {
            // generate bombs randomly > 
            // create for loop that will run bomb number of times. 
                // row - roll a dice between 0 and grid_size
                // column - roll a dice between 0 and grid_size
                // assign to coordinate using the row and column number
            // return the grid

            Random rnd = new Random();

            for (int a = 0; a < 4; a++)
            {
                for(int b = 0; b < 4; b++)
                {
                    int xbomb = rnd.Next(0, grid_size);
                    int ybomb = rnd.Next(0, grid_size);
                    int bomb = grid[a, b];
                    grid[a, b] = grid[xbomb, ybomb];
                    grid[xbomb, ybomb] = bomb.ToString("*").ToCharArray()[0];
                    //Console.WriteLine();
                }
                

                
                //bomb = '*';
            }
            
                return grid;
        }
    }
}

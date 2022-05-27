using System;
using System.Collections.Generic;

namespace minesweeperHiraaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Minesweeper!");

            // grid size
            int grid_size = 10;

            // Create a 2-D array of given size
            char[,] grid = new char[grid_size, grid_size];

            // Fill the array with .
            for (int i = 0; i < grid_size; i++)
                for (int j = 0; j < grid_size; j++)
                    grid[i, j] = '.';

            Utils.Draw(grid_size, grid);

            

            // Variable
            // -1 indicate player lostc
            // 0 indicate game is still in progress
            // 1 indicate player won
            int game = 0;

            while (game == 0)
            {
                Utils.GenerateBomb(grid, grid_size);
                // Ask for Coordinates
                Console.Write("Enter your X coordinate: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your Y coordinate: ");
                int y = Convert.ToInt32(Console.ReadLine());

                // Update the grid according to user input
                if (grid[x, y] == '*')  // replace mine to inside of your grid
                {
                    // Also update the value of game variable to -1 if player hit a mine
                    game = -1;
                }
                else
                {
                    grid[x, y] = CountMineAroundCell(grid, x, y);
                    //grid[x, y] = '.';
                }
                    

                //        
                //Console.WriteLine('_');

                Utils.Draw(grid_size, grid);
            }
            

            // Display the updated grid and count the number of '_' symbols in the grid
            

            //Console.WriteLine(CountMinesRoundCell(counter));

            // Update the value of game variable to 1 if player won i.e. number of '_' symbols matches the grid size
            //if (count == grid_size)
            //    game = 1;

            // Display appropriate message if player won or hit a mine
            if (game == 1)
                Console.WriteLine("You win!");
            
            else if (game == -1)
                Console.WriteLine("Boom! You hit a mine.");

            // Check surrounding mines and display the amount of bombs nearby
            
        }

        static char CountMineAroundCell(char[,] grid, int x, int y)
        {
            int counter = 0;
            if (grid[x - 1, y - 1] == '*')
            {
                counter++;
            }
            if (grid[x, y - 1] == '*')
            {
                counter++;
            }
            if (grid[x + 1, y] == '*')
            {
                counter++;
            }
            if (grid[x + 1, y] == '*')
            {
                counter++;
            }
            if (grid[x - 1, y + 1] == '*')
            {
                counter++;
            }
            if (grid[x, y + 1] == '*')
            {
                counter++;
            }
            if (grid[x + 1, y + 1] == '*')
            {
                counter++;
            }


            return counter.ToString().ToCharArray()[0];
            Console.WriteLine($"There are {counter} bombs near you");
            
        }


    }
}


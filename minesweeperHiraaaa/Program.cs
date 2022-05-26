using System;

namespace minesweeperHiraaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the game title
            Console.WriteLine("Welcome to Minesweeper!");

            // grid size
            int grid_size = 10;

            // Create a 2-D array of given size
            char[,] grid = new char[grid_size, grid_size];

            // Fill the array with .
            for (int i = 0; i < grid_size; i++)
                for (int j = 0; j < grid_size; j++)
                    grid[i, j] = '.';

            // Display the grid
            for (int i = 0; i < grid_size; i++)
            {
                for (int j = 0; j < grid_size; j++)
                    Console.Write(grid[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();

            // Create a 1-D array to store the column numbers of mine in each row
            int[] mines = new int[grid_size];

            // Random number generator object
            Random rnd = new Random();

            // Iterate for the size of the grid
            for (int i = 0; i < grid_size; i++)
                // Random position of mine
                mines[0] = rnd.Next(0, grid_size);
            mines[1] = rnd.Next(0, grid_size);
            mines[2] = rnd.Next(0, grid_size);
            mines[3] = rnd.Next(0, grid_size);
            mines[4] = rnd.Next(0, grid_size);
            mines[5] = rnd.Next(0, grid_size);
            mines[6] = rnd.Next(0, grid_size);
            mines[7] = rnd.Next(0, grid_size);
            mines[8] = rnd.Next(0, grid_size);
            mines[9] = rnd.Next(0, grid_size);


            // Variable
            // -1 indicate player lostc
            // 0 indicate game is still in progress
            // 1 indicate player won
            int game = 0;

            while (game == 0)
            {
                // Ask for Coordinates
                Console.Write("Enter your X coordinate: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your Y coordinate: ");
                int y = Convert.ToInt32(Console.ReadLine());

                // Update the grid according to user input
                if (mines[x] == y)
                {
                    grid[x, y] = '*';

                    // Also update the value of game variable to -1 if player hit a mine
                    game = -1;
                }
                else
                    grid[x, y] = '_';
            }

                
            

            // Display the updated grid and count the number of '_' symbols in the grid
            int count = 0;
            Console.WriteLine();
            for (int i = 0; i < grid_size; i++)
            {
                for (int j = 0; j < grid_size; j++)
                {
                    Console.Write(grid[i, j]);
                    if (grid[i, j] == '_')
                        count++;
                    //CountMineAroundCell(i,j);
                    //Console.WriteLine($"There are {counter} bombs near you");
                }
                Console.WriteLine();
            }


            //Console.WriteLine(CountMinesRoundCell(counter));

            // Update the value of game variable to 1 if player won i.e. number of '_' symbols matches the grid size
            if (count == grid_size)
                game = 1;

            // Display appropriate message if player won or hit a mine
            if (game == 1)
                Console.WriteLine("You win!");
            else if (game == -1)
                Console.WriteLine("Boom! You hit a mine.");
            //{
            //Console.WriteLine($"There are {count} bombs near you");
            //}

            // Check surrounding mines and display the amount of bombs nearby
            static int CountMineAroundCell(char[,] grid, int x, int y)
            {
                int counter = 0;
                if (grid[x - 1, y - 1] == '*')
                {
                    counter++;
                }
                else if (grid[x, y - 1] == '*')
                {
                    counter++;
                }
                else if (grid[x + 1, y] == '*')
                {
                    counter++;
                }
                else if (grid[x + 1, y] == '*')
                {
                    counter++;
                }
                else if (grid[x - 1, y + 1] == '*')
                {
                    counter++;
                }
                else if (grid[x, y + 1] == '*')
                {
                    counter++;
                }
                else if (grid[x + 1, y + 1] == '*')
                {
                    counter++;
                }

                return counter++;
                Console.WriteLine($"There are {counter++} bombs near you");
            }

        }

    }
}


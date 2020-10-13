using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuesser
{
    class Game
    {
        const int maximumLevels = 50;

        int currentLevel = 0;
        int points = 0;

        readonly List<LevelData> levels = new List<LevelData>();

        private readonly Random random = new Random();

        public void Start()
        {
            LoadLevels();

            PrintHeader();

            Console.WriteLine("You're currently on level 1! You can see at which level you're at the top.");
            Console.WriteLine("Please hit Enter to start your game!");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                PlayLevels();
            }
        }

        private void PlayLevels()
        {
            int turns;
            int target;
            int guess;

            foreach (LevelData level in levels)
            {
                turns = 0;
                target = level.Target;
                guess = -1;

                Console.Clear();
                PrintHeader();
                PrintLevel(level);

                while (guess != target)
                {
                    turns++;

                    if (int.TryParse(Console.ReadLine(), out guess))
                    {
                        if (guess > target)
                        {
                            Console.WriteLine("Too high! Next guess?");
                        }
                        else if (guess < target)
                        {
                            Console.WriteLine("Too low! Next guess?");
                        }
                        else if (guess == target)
                        {
                            int earnedPoints = level.MaximumTries - turns;
                            earnedPoints = (earnedPoints > 0) ? earnedPoints : 0;

                            Console.WriteLine("Yeah! You guessed the right number!");
                            Console.WriteLine("It took you " + (turns + 1) + " turns!");
                            Console.WriteLine("You earned " + (earnedPoints) + " points!");
                            Console.WriteLine("Please hit Enter to go to the next level!");

                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                points += earnedPoints;

                                currentLevel++;
                                turns = 0;

                            }
                        }
                    }

                    /*if (!int.TryParse(Console.ReadLine(), out guess))
                    {
                        continue;
                    }*/

                    /*if (guess > target)
                    {
                        Console.WriteLine("Too high! Next guess?");
                    } else if (guess < target)
                    {
                        Console.WriteLine("Too low! Next guess?");
                    } else if (guess == target)
                    {
                        int earnedPoints = level.MaximumTries - turns;
                        earnedPoints = (earnedPoints > 0) ? earnedPoints : 0;

                        Console.WriteLine("Yeah! You guessed the right number!");
                        Console.WriteLine("It took you " + (turns + 1) + " turns!");
                        Console.WriteLine("You earned " + (earnedPoints) + " points!");
                        Console.WriteLine("Please hit Enter to go to the next level!");

                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            points += earnedPoints;

                            currentLevel++;
                            turns = 0;

                        }
                    }*/
                }

                if (currentLevel >= levels.Count)
                {
                    Console.Clear();
                    PrintHeader();
                    Console.WriteLine("You've completed all levels! Congratulations.");
                    Console.WriteLine("Hit Enter to close the game!");

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        private void PrintLevel(LevelData level)
        {
            Console.WriteLine("I'm thinking of a number between " + level.StartRange + " and " + level.EndRange + ".");
            Console.WriteLine("Guess my number, and I'll tell you if it's too high,");
            Console.WriteLine("too low, or correct.  Try to guess in the fewest turns.");
            Console.WriteLine("For this level, you will have to guess within " + level.MaximumTries + " turns");
            Console.WriteLine("to earn points.");
        }

        private void PrintHeader()
        {
            Console.WriteLine("====+] Number Guesser Game [+====");
            Console.WriteLine("==] - Level: " + (currentLevel + 1).ToString());
            Console.WriteLine("==] - Points: " + (points).ToString());
            Console.WriteLine("");
        }

        private void LoadLevels()
        {
            for (int i = 0; i < maximumLevels; i++)
            {
                int multiplier = i + 1;

                int startRange = 0;
                int endRange = multiplier * 10;

                var numbers = new List<int>();
                numbers.AddRange(Enumerable.Range(0, 100000));
                var answer = numbers.BinarySearchWithCount(2);

                levels.Add(new LevelData(startRange, endRange, CreateTarget(startRange, endRange), answer.Item2));
            }
        }

        private int CreateTarget(int startRange, int endRange)
        {
            return random.Next(startRange, endRange);
        }
    }
}

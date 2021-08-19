using System;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var startPositions = Console.ReadLine().Trim().Split(' ');
            Rover position = new Rover();

            if (startPositions.Count() == 3)
            {
                position.X = Convert.ToInt32(startPositions[0]);
                position.Y = Convert.ToInt32(startPositions[1]);
                position.Direction = startPositions[2];
            }

            var moves = Console.ReadLine().ToUpper();

            try
            {
                position.StartAction(maxPoints, moves);
                Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
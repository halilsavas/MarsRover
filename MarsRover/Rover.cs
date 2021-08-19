using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Rover
    {
        public int X;
        public int Y;
        public string Direction;
        public Rover(string location)
        {
            Int32.TryParse(location.Split(" ")[0], out X);
            Int32.TryParse(location.Split(" ")[1], out Y);
            Direction = location.Split(" ")[2];
        }

        public Rover()
        {
        }

        public void RotateLeft()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "W";
                    break;
                case "E":
                    Direction = "N";
                    break;
                case "S":
                    Direction = "E";
                    break;
                case "W":
                    Direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void RotateRight()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void MoveInSameDirection()
        {
            switch (Direction)
            {
                case "N":
                    Y += 1;
                    break;
                case "E":
                    X += 1;
                    break;
                case "S":
                    Y -= 1;
                    break;
                case "W":
                    X -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void StartAction(List<int> maxPoints, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.MoveInSameDirection();
                        break;
                    case 'L':
                        this.RotateLeft();
                        break;
                    case 'R':
                        this.RotateRight();
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (this.X < 0 || this.X > maxPoints[0] || this.Y < 0 || this.Y > maxPoints[1])
                {
                    throw new Exception($"Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
        }
    }
}

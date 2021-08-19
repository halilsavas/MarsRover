using System;
using Xunit;
using MarsRover;
using System.Collections.Generic;

namespace MarsRoverTest
{
    public class UnitTest
    {
        [Fact]
        public void LMLMLMLMM()
        {
            Rover position = new Rover()
            {
                X = 1,
                Y = 2,
                Direction = "N"
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            position.StartAction(maxPoints, moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void MMRMMRMRRM()
        {
            Rover position = new Rover()
            {
                X = 3,
                Y = 3,
                Direction = "E"
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MMRMMRMRRM";

            position.StartAction(maxPoints, moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "5 1 E";

            Assert.Equal(expectedOutput, actualOutput);
        } 
    }
}

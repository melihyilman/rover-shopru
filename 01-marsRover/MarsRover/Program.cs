using System;

namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var marsRover = new MarsRover("3 3 E");
            marsRover.Move("MMRMMRMRRM");
        }
    }
}

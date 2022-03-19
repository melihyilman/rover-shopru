using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class MarsRover
    {
        public int x;
        public int y;
        public string direction;
        public MarsRover(string location)
        {
            var information = location.Split(" ");
            int.TryParse(information[0], out x);
            int.TryParse(information[1], out y);
            direction = information[2];
        }
        public void SpinLeft()
        {
            _= direction switch
            {
                "N" =>direction="W",
                "E" =>direction="N",
                "S" =>direction="E",
                "W" => direction="S",
                _ => throw new ArgumentOutOfRangeException(nameof(direction))
            };
        }
        public void SpinRight()
        {
            direction = direction switch
            {
                "N" => direction="E",
                "E" => direction="S",
                "S" => direction="W",
                "W" => direction="N",
                _ => throw new ArgumentOutOfRangeException(nameof(direction))
            };
        }
        public void StepForward()
        {
            _ = direction switch
            {
                "N" =>y=y+1,
                "E" =>x=x+1,
                "S" => y=y-1,
                "W" => x=x-1,
                _ => throw new ArgumentOutOfRangeException(nameof(direction))
            };
        }
        public void Move(string roverCommand)
        {
            var instructions = roverCommand.ToCharArray();
            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case 'L': SpinLeft(); break;
                    case 'R': SpinRight(); break;
                    case 'M': StepForward(); break;


                    default:
                        throw new ArgumentException();
                }
            
            }
        }
       
    }
}

using System;

namespace MarsRover.Entity
{
    public class Rover
    {
        public int x { get; set; }
        public int y { get; set; }
        public string direction { get; set; }    

        public Rover(string location)
        {
        this.x = Int32.Parse(location.Split(" ")[0]);
        this.y = Int32.Parse(location.Split(" ")[1]);
        this.direction = location.Split(" ")[2];
        }

        public void TurnLeft()
        {
           switch (direction)
           {
               case "N":
                    direction = "W";
                    break;
               case "E":
                    direction = "N";
                    break;
               case "S":
                    direction = "E";
                    break;
               case "W":
                    direction = "S";
                    break;
               default: 
                    throw new ArgumentException();                                 
           }    
        }

        public void TurnRight()
        {
        switch (direction)
           {
               case "N":
                    direction = "E";
                    break;
               case "E":
                    direction = "S";
                    break;
               case "S":
                    direction = "W";
                    break;
               case "W":
                    direction = "N";
                    break;
               default: 
                    throw new ArgumentException();                                 
           }            }

        public void StepForward()
        {
            switch(direction)
            {
             case "N":
                  y += 1;
                  break;
             case "E":
                  x += 1;
                  break;
             case "W":
                  x -=1 ;
                  break;
             case "S":
                  y -=1 ;
                  break;       
             default:
                  throw new ArgumentException();    
            }
        }

        public void Move(string command)
        {
            char[] instructions = command.ToCharArray();

            for(int i=0; i < instructions.Length; i++)
            {
                switch(instructions[i])
                {
                    case 'L':
                          TurnLeft();
                          break;
                    case 'R':
                          TurnRight();
                          break;
                    case 'M':
                          StepForward();
                          break;                  
                    default:
                          throw new ArgumentException();

                }
            }

        }    

    }
}

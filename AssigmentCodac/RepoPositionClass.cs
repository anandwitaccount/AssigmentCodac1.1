using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssigmentCodac.IserviceClass;

namespace AssigmentCodac
{
    public enum Directions
    {
        N ,
        S ,
        E ,
        W 
    }
    public class RepoPositionClass : IRepoPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public RepoPositionClass()
        {
            X = Y = 1;
            Direction = Directions.N;
        }
        public string GetNameOfDirection(Directions Direction)
        {
            string direction = string.Empty;
            switch (this.Direction)
            {
                case Directions.N:
                    direction = "North";
                    break;
                case Directions.E:
                    direction = "East";
                    break;
                case Directions.S:
                    direction = "South";
                    break;
                case Directions.W:
                    direction = "West";
                    break;
                default:
                    break;
            }
            return direction;
        }
        private void MoveRight()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }
        private void MoveLeft()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }
        private void MoveInSameDirection()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void MovingStart(List<int> maximumPoints, string newMoves)
        {
            foreach (var move in newMoves)
            {
                switch (move)
                {
                    case 'F':
                        this.MoveInSameDirection();
                        break;
                    case 'L':
                        this.MoveLeft();
                        break;
                    case 'R':
                        this.MoveRight();
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (this.X < 0 || this.X > maximumPoints[0] || this.Y < 0 || this.Y > maximumPoints[1])
                {
                   throw new Exception($"Position can not be beyond bounderies (0,0) and ({maximumPoints[0]},{maximumPoints[1]})");
                }
            }
        }
    }
}

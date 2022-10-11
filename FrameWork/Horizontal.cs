using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FrameWork
{
    public class Horizontal : Imovment
    {
        private Point boundary;
        private int speed;
        private string direction;

        public Horizontal(Point boundary , int speed , string direction)
        {
            this.boundary = boundary;
            this.speed = speed;
            this.direction = direction;
        }

        public Point MoveObject(Point location)
        {

            if(location.X <= 0)
            {
                direction = "right";
            }
            else if (location.X + 50 > boundary.X)
            {
                direction = "left";
            }
            if(direction == "left")
            {
                location.X -= speed;
            }
            if(direction == "right")
            {
                location.X += speed;
            }
            return location;

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FrameWork
{
    public class Verticalcs : Imovment
    {
        private Point boundary;
        private int speed;
        private string direction;

        public Verticalcs(Point boundary , int speed , string direction)
        {
            this.boundary = boundary;
            this.speed = speed;
            this.direction = direction;
        }

        public Point MoveObject(Point location)
        {
            if(location.Y <=0)
            {
                direction = "down";
            }
            else if(location.Y + 90 >= boundary.Y)
            {
                direction = "up";
            }
            if (direction == "up")
            {
                location.Y -= speed;
            }
            if(direction == "down")
            {
                location.Y += speed;
            }
            return location;

        }
    }
}

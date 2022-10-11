using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FrameWork
{
    public class Keyboardk : Imovment
    {
        private Point boundary;
        private int speed;
        private string KeyAction;

        public Keyboardk(Point boundary , int speed)
        {
            this.boundary = boundary;
            this.speed = speed;
        }

        public void CheckKeyPressed(Keys keyCode)
        {
            if(keyCode == Keys.Up)
            {
                KeyAction = "up";
            }
            if(keyCode == Keys.Down)
            {
                KeyAction = "down";
            }
            if(keyCode == Keys.Left)
            {
                KeyAction = "left";
            }
            if(keyCode == Keys.Right)
            {
                KeyAction = "right";
            }
        }

        public Point MoveObject(Point location)
        {
            if (KeyAction != null)
            {

                if (KeyAction == "up" && location.Y >= boundary.Y)
                {
                    location.Y -= speed;
                }
                if (KeyAction == "down" && location.Y <= 375)
                {
                    location.Y += speed;
                }
                if (KeyAction == "left" && location.X > boundary.X)
                {
                    location.X -= speed;
                }
                if (KeyAction == "right" && location.X < 485)
                {
                    location.X += speed;
                }
                KeyAction = null;
            }
            return location;
        }
    }
}

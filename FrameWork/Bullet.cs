using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FrameWork
{
    public class Bullet : GameObject
    {
        public Bullet(Image img, int top, int left, Imovment MovementType, string ObjectType) : base(img,top,left,MovementType,ObjectType)
        {

            
        }
        
    }
}

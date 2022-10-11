using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork
{
    class healthCollision : Icollosion2
    {
        public void PerformAction(igame2 game, GameObject g1, GameObject g2)
        {
            GameObject ob = null;
            if (g1.ObjectType1 == "health")
            {
                ob = g1;

            }
            else if (g2.ObjectType1 == "health")
            {
                ob = g2;

            }
            game.increasehealthEvent(ob.Pb1);
           



        }
    }
}

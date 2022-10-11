using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameWork;

namespace FrameWork
{
    public class PlayerCollosion : Icollosion
    {
        public void PerformAction(Igame game , GameObject g1 , GameObject g2)
        {
            GameObject ob = null;
            if(g1.ObjectType1 == "enemy")
            {
                ob = g1;
                
            }
            else if(g2.ObjectType1 == "enemy")
            {
                ob = g2;
                
            }
            if (ob != null)
            {


                game.DecreaseHealthEvent(ob.Pb1);
            }


        }
    }
}

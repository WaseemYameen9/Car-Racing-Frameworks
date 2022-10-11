using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork
{
    public class Collosion 
    {
        private string g1;
        private string g2;
        private Icollosion behaviour;

        public Collosion(string g1, string g2, Icollosion behaviour)
        {
            this.G1 = g1;
            this.G2 = g2;
            this.Behaviour = behaviour;
        }

       
        public Icollosion Behaviour { get => behaviour; set => behaviour = value; }
        public string G1 { get => g1; set => g1 = value; }
        public string G2 { get => g2; set => g2 = value; }
    }
}

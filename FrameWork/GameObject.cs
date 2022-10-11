using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FrameWork
{
    public class GameObject
    {
        private PictureBox Pb;
        private Imovment MovementType;
        private string ObjectType;
       
        

        public GameObject(Image img , int top , int left, Imovment MovementType,string ObjectType)
        {
            Pb1 = new PictureBox();
            Pb1.Image = img;
            Pb1.Height = 60;
            Pb1.Width = 35;
            Pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb1.BackColor = Color.Transparent;
            Pb1.Top = top;
            Pb1.Left = left;
            this.MovementType1 = MovementType;
            this.ObjectType1 = ObjectType;
        }

        public PictureBox Pb1 { get => Pb; set => Pb = value; }
        public string ObjectType1 { get => ObjectType; set => ObjectType = value; }
        internal Imovment MovementType1 { get => MovementType; set => MovementType = value; }

        public void update()
        {
          Pb.Location = MovementType.MoveObject(Pb.Location);
          
        }
        
    }
}

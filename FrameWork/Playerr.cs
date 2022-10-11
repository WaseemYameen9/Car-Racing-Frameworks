using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FrameWork
{
    public class Playerr
    {
        private Image img;
        private int top;
        private int left;
        private List<PictureBox> bulletList = new List<PictureBox>();
        public event EventHandler AddBulletIntoControls;
        

        public Playerr(Image img,int top, int left)
        {
            this.Img = img;
            this.Top = top;
            this.Left = left;

        }
        public void CreateBullet(Image img)
        {
            PictureBox b = new PictureBox();
            b.Image = img;
            b.Top = this.top;
            b.Left = this.left;
            b.BackColor = Color.Transparent;
            BulletList.Add(b);
            AddBulletIntoControls?.Invoke(b, EventArgs.Empty);

            
            
            
        }
        public void update()
        {
            foreach (PictureBox p in bulletList)
            {
                p.Top -= 10;
            }
        }
        public void DeleteFire(Form f)
        {
            for (int i = 0; i < BulletList.Count; i++)
            {
                if (BulletList[i].Top >= f.Height)
                {
                    BulletList.RemoveAt(i);

                }
            }
        }

        public Image Img { get => img; set => img = value; }
        public int Top { get => top; set => top = value; }
        public int Left { get => left; set => left = value; }
        public List<PictureBox> BulletList { get => bulletList; set => bulletList = value; }
    }
}

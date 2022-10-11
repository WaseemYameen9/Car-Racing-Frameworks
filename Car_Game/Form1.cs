using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameWork;
using EZInput;


namespace Car_Game
{
    public partial class Form1 : Form
    {
        Game g;
        Playerr p = new Playerr(Properties.Resources.Car_2_01, 380, 300);
        Random rand = new Random();
        System.Drawing.Point boundary = new System.Drawing.Point(300, 600);
        System.Drawing.Point boundary2 = new System.Drawing.Point(275,5);
        int health = 100;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = new Game();
            g.OnObjectAdded += new EventHandler(AddIntoControls);
            g.DecreaseHealth += new EventHandler(decreaseHealth);
            g.IncreaseScore += new EventHandler(incScore);
            g.increaseHealth += new EventHandler(IncreaseHealth);
            p.AddBulletIntoControls += new EventHandler(addbulletsinControls);
            


            g.addGameObject(p.Img, p.Top, p.Left, new Keyboardk(boundary2, 20), "player");


            Collosion c = new Collosion("player", "enemy", new PlayerCollosion());
            g.AddCollosion(c);
            Collosion c2 = new Collosion("player", "health", new PlayerCollosion());
            g.AddCollosion(c2);
        }

        private void addbulletsinControls(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }

        private void IncreaseHealth(object sender, EventArgs e)
        {
            health += 25;
        }

        private void incScore(object sender, EventArgs e)
        {
            score += 5;
        }

        private void decreaseHealth(object sender, EventArgs e)
        {
            this.Controls.Remove((PictureBox)sender);
            health = health - 25;
            PgBar.Value  =  health;
        }

        private void AddIntoControls(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }

        private void Loop_Tick(object sender, EventArgs e)
        {
            lblscore.Text = "Score" + score;
            g.update();
            EnemyCars();
            getHealth();
            g.DeleteObjects(this);
            p.update();
            p.DeleteFire(this);
            if (health <= 0)
            {
                GameOver();
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                p.CreateBullet(Properties.Resources.laserBlue03);
            }
            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            g.KeyPressed(e.KeyCode);
        }
        public Image GetEnemyImage()
        {
            Image img = null;
            int num = rand.Next(1, 4);
            if (num == 1)
            {
                img = Properties.Resources.Car_2_011;
            }
            if (num == 2)
            {
                img = Properties.Resources.red;

            }
            else if (num == 3)
            {
                img = Properties.Resources.Car_3_01;
            }

            return img;
        }

        public void EnemyCars()
        {
            int num = rand.Next(0, 100);
            if (num == 1)
            {
                Image e1 = GetEnemyImage();
                g.addGameObject(e1, 5, 500, new Verticalcs(boundary, 18, "down"), "enemy");

            }
            if (num == 5)
            {

                Image e1 = GetEnemyImage();
                g.addGameObject(e1, 5, 425, new Verticalcs(boundary, 18, "down"), "enemy");


            }
            if (num == 10)
            {
                Image e1 = GetEnemyImage();
                g.addGameObject(e1, 5, 260, new Verticalcs(boundary, 18, "down"), "enemy");


            }
            if (num == 20)
            {
                Image e1 = GetEnemyImage();
                g.addGameObject(e1, 5, 330, new Verticalcs(boundary, 18, "down"), "enemy");

            }

        }
        public void getHealth()
        {
            int num = rand.Next(0, 200);
            if (num == 28)
            {
                Image e1 = Properties.Resources.HP_Dot;
                g.addGameObject(e1, 5, 260, new Verticalcs(boundary, 16, "down"), "health");

            }
            if (num == 29)
            {

                Image e1 = Properties.Resources.HP_Dot;
                g.addGameObject(e1, 5, 260, new Verticalcs(boundary, 16, "down"), "health");

            }
        }

        public void GameOver()
        {
           
                this.Close();
                GameOver f = new GameOver();
                f.Show();

        }

       
    }
}

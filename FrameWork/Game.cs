using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FrameWork
{
    public class Game : Igame
    {
        private List<GameObject> ObjectList;
        public event EventHandler OnObjectAdded;
        private List<Collosion> collosion;
        public event EventHandler DecreaseHealth;
        public event EventHandler IncreaseScore;
        public event EventHandler increaseHealth;
        internal List<GameObject> ObjectList1 { get => ObjectList; set => ObjectList = value; }

        public Game()
        {
            ObjectList = new List<GameObject>();
            collosion  = new List<Collosion>();
        }

        public void update()
        {
            int s = DetectCollosion();
            foreach (GameObject ob in ObjectList)
            {
                ob.update();
            }

        }

        public void addGameObject(Image img, int top, int left,Imovment MovementType,string ObjectType)
        {
            GameObject ob = new GameObject(img, top, left,MovementType,ObjectType);
            ObjectList.Add(ob);
            OnObjectAdded?.Invoke(ob.Pb1 , EventArgs.Empty);

        }

        public void KeyPressed(Keys keycode)
        {
            foreach (GameObject ob in ObjectList)
            {
                if(ob.MovementType1.GetType() == typeof(Keyboardk))
                {
                    Keyboardk k = (Keyboardk)ob.MovementType1;
                    k.CheckKeyPressed(keycode);
                }
            }
            
        }

        public int DetectCollosion()
        {
            for(int i = 0; i < ObjectList.Count; i++)
            {
                for(int j = 0; j < ObjectList.Count; j++)
                {
                    if (ObjectList[i].Pb1.Bounds.IntersectsWith(ObjectList[j].Pb1.Bounds))
                    {
                        foreach (Collosion c in collosion)
                        {
                            if ((ObjectList[i].ObjectType1 == c.G1) && (ObjectList[j].ObjectType1 == c.G2))
                            {
                                c.Behaviour.PerformAction(this, ObjectList[i], ObjectList[j]);
                                if (ObjectList[i].ObjectType1 == "enemy")
                                {
                                    ObjectList.RemoveAt(i);
                                    return 1;

                                }
                                if (ObjectList[i].ObjectType1 == "health")
                                {
                                    ObjectList.RemoveAt(i);
                                    return 1;
                                }
                                if (ObjectList[j].ObjectType1 == "enemy")
                                {
                                    ObjectList.RemoveAt(j);
                                    return 1;
                                }
                                if (ObjectList[j].ObjectType1 == "health")
                                {
                                    ObjectList.RemoveAt(j);
                                    return 1;
                                }

                            }
                        }
                    }
                }
            }
            return 0;
        }

        public void DecreaseHealthEvent(PictureBox PlGameObject)
        {
            DecreaseHealth?.Invoke(PlGameObject , EventArgs.Empty);
        }
        public void IncreaseHealthEvent(PictureBox PlGameObject)
        {
            increaseHealth?.Invoke(PlGameObject, EventArgs.Empty);
        }

        public void AddCollosion(Collosion c)
        {
            collosion.Add(c);
        }

        public void DeleteObjects(Form f)
        {
            for(int i = 0; i < ObjectList.Count;i++)
            {
                if(ObjectList[i].Pb1.Top >= f.Height && ObjectList[i].ObjectType1 != "player")
                {
                    ObjectList.RemoveAt(i);
                    IncreaseScore?.Invoke(" ", EventArgs.Empty);

                }
            }
        }

        public void increasehealthEvent(PictureBox p2)
        {
            increaseHealth?.Invoke(p2,EventArgs.Empty);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSpritesheetTest
{
    public partial class Form1 : Form
    {
        SpriteSheetHandler sprite = new SpriteSheetHandler(@"H:\advnt_full.png", 32,65);
        SpriteSheetHandler sprite2 = new SpriteSheetHandler(@"H:\advnt_full.png", 32, 65);
        double tick;
       int distance;
        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void FrameUpdate_Tick(object sender, EventArgs e)
        {


           
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            pb_char1.Image = sprite.curState;
            pb_char2.Image = sprite2.curState;

            sprite.InitialiseSprite(5,1,6, 0);
            sprite2.InitialiseSprite(5,1, 6, 0);

        }

        private void StartAnimation(string animate)            
        {


            if (animate=="walk")
            {
                sprite.InitialiseSprite(5, 1, 6, 0);
                  sprite2.InitialiseSprite(5, 1, 6, 0);
            }
            if (animate =="idle")
            {
                sprite.InitialiseSprite(5, 0, 0, 0);
                sprite2.InitialiseSprite(5, 0, 0, 0);

            }
        }



        private void Frame_Tick_Tick(object sender, EventArgs e)
        {
            pb_char1.Image = sprite.curState;
            pb_char2.Image = sprite2.curState;
            sprite.playSprite(false);          
            sprite2.playSprite(true);




            //
            tick += 1;
            label1.Text = Convert.ToString(tick);
            //




            if (CheckDistance()<-32)
            {
                pb_char2.Left -= 2;// moving pb right
                pb_char1.Left += 2;
            }
            else
            {
                StartAnimation("idle");
            }

        }
        private int CheckDistance()
        {
            distance = pb_char1.Location.X-pb_char2.Location.X;

            return distance;
        }

        
    }
}

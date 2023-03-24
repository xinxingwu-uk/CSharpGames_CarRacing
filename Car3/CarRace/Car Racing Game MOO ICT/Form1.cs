using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int playerSpeed = 12;


        bool goleft, goright;


        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                roadSpeed = roadSpeed + 1;
            }

            if (e.KeyCode == Keys.Down)
            {
                roadSpeed = roadSpeed - 1;
            }

            if (e.KeyCode == Keys.Q)
            {
                gameTimer.Stop();
                btnStart.Enabled = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {


            if (goleft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            if (roadTrack2.Top < -519)
            {
                roadTrack2.Top = 519;
            }
            if (roadTrack1.Top < -519)
            {
                roadTrack1.Top = 519;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            goleft = false;
            goright = false;

            roadSpeed = 12;

            gameTimer.Start();

            btnStart.Enabled = false;
        }


    }
}

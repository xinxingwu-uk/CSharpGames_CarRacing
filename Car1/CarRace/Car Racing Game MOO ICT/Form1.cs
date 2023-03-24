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

        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            roadSpeed = 12;
            gameTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
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
        }

    }
}

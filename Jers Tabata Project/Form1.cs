using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jers_Tabata_Project
{
    public partial class Form1 : Form
    {
        int prepareSeconds = 10;
        int goSecondsLeft = 20;
        int restSecondsLeft = 10;
        int tabatas = 8;

        SoundPlayer beep = new SoundPlayer(Resource1.Beep);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (goSecondsLeft >= 0)
            {
                lbGoOrRest.Text = "Go!";
                lbSecondsRemaining.Text = goSecondsLeft.ToString() + " seconds";
                goSecondsLeft--;

                if (goSecondsLeft <= 3)
                {
                    beep.Play();
                }


            }
            else if (restSecondsLeft >= 0)
            {
                lbGoOrRest.Text = "Rest";
                lbSecondsRemaining.Text = restSecondsLeft.ToString() + " seconds";
                restSecondsLeft--;

                if (restSecondsLeft <= 3)
                {
                    beep.Play();
                }
            }
            else
            {
                goSecondsLeft = 20;
                restSecondsLeft = 10;
                tabatas--;
                lbTabatasRemaining.Text = "Tabatas remaining " + tabatas.ToString();
                timerGo.Stop();
                timerGo.Start();
            }   
                 
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            timerPrepare.Start();
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timerGo.Stop();
        }

        private void timerPrepare_Tick(object sender, EventArgs e)
        {
            if (prepareSeconds >= 0)
            {
                lbPrepare.Text = "Prepare!";
                lbSecondsRemaining.Text = prepareSeconds.ToString() + " seconds";
                prepareSeconds--;

                if (prepareSeconds <= 3)
                {
                    beep.Play();
                }
            }
            else
            {
                lbPrepare.Text = "";
                timerPrepare.Stop();
                timerPrepare.Dispose();
                
                timerGo.Start();

            }
        }
    }
}

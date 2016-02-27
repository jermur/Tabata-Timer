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
        int prepareSeconds = 10; //Second before exercising begins.
        int goSecondsLeft = 20; // Number of seconds of work per set
        int restSecondsLeft = 10; // number of seconds of rest set
        int tabatas = 8; // Number of sets

        SoundPlayer beep = new SoundPlayer(Resource1.Beep); //Beeb sound to warn user of next phase change

        public Form1()
        {
            InitializeComponent();
        }

        /*
        *  The timer counts down from 20 to zero displaying 'Go' to indicate the work phase.
        *  The timer then counts down from 10 displaying rest indicating the rest phase.
        *  Beeb tones are used to prepare the user for the next phase change.
        */
        private void timer1_Tick(object sender, EventArgs e)
        {

            // The work phase
            if (goSecondsLeft >= 0)
            {
                lbGoOrRest.Text = "Go!";
                lbSecondsRemaining.Text = goSecondsLeft.ToString() + " seconds";
                goSecondsLeft--;

                if (goSecondsLeft <= 3) 
                {
                    beep.Play(); //Outputs beep sounds to warn user audibly
                }


            } //The rest phase
            else if (restSecondsLeft >= 0)
            {
                lbGoOrRest.Text = "Rest";
                lbSecondsRemaining.Text = restSecondsLeft.ToString() + " seconds";
                restSecondsLeft--;

                if (restSecondsLeft <= 3)
                {
                    beep.Play(); //Outputs beep sounds to warn user audibly
                }
            }
            else // resets the counter variables,decrements the number of tabatas left and resets the timer
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
            timerPrepare.Start(); // Gives the user 10 second to prepare.
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timerGo.Stop(); // stops the timer
            timerGo.Dispose(); // releases resouses used by the timer
        }
        
        /*
        *  This timer counts down from 10 allowing the user to prepare for the workout.
        *  The text 'Prepare' is displayed in bold
        *  the time counts down from 10 beeping for the las 4 seconds so the user doesn't hae to lok at the screen
        */
        private void timerPrepare_Tick(object sender, EventArgs e)
        {
            // Gives the user 10 seconds to prepare
            if (prepareSeconds >= 0)
            {
                lbPrepare.Text = "Prepare!";
                lbSecondsRemaining.Text = prepareSeconds.ToString() + " seconds";
                prepareSeconds--;

                if (prepareSeconds <= 3)
                {
                    beep.Play(); //Outputs beep sounds to warn user audibly
                }
            }
            else 
            {
                lbPrepare.Text = ""; // clears the prepare label
                timerPrepare.Stop(); // stops the timer
                timerPrepare.Dispose(); //releases teh resources used by the timer
                
                timerGo.Start(); //starts the workout

            }
        }
    }
}

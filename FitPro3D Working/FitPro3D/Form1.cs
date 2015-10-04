using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using kinect_backend;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Media;

namespace FitPro3D
{
    public partial class Form1 : Form
    {
        String exerciseChosen;        
        double timerMin = 0.00;
        double timerSec = 0.00;
        double timerMill = 0.00;
        int jump = 0;
        int sq = 0;
        int bi = 0;
        int sh = 0;
        int minute, second, millisecond;
        Boolean track = false;
        Boolean recording = false;
        double calories;
        Image pic;
        Core body;

        private KinectSensor sensor;
        

        public Form1()
        {
            body = new Core();
            InitializeComponent();
            sensor = body.GetSensor();
            Process p = new Process();
            p.StartInfo.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            p.StartInfo.FileName = "ColorBasics-WPF.exe";
            p.Start();
            Thread.Sleep(500); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            //runPy("hello world");
        }

        //private void runPy(string ttsString)
        //{
        //    ProcessStartInfo pyt = new ProcessStartInfo("audio.py", ttsString);
        //    pyt.UseShellExecute = false;              
        //    pyt.CreateNoWindow = true;
        //    pyt.RedirectStandardOutput = true;
        //    Process.Start(pyt);
        //}

        private void startRec_Click(object sender, EventArgs e)
        {
            if(recording ==false)
            {                
                recording = true;                

                if (pushRadio.Checked)
                {                    
                    exerciseChosen = "Push-Ups";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/pushup.gif");
                    startProgram();
                }
                else if (sitRadio.Checked)
                {                    
                    exerciseChosen = "Sit-Ups";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/situp.gif");
                    startProgram();
                }
                else if (wallRadio.Checked)
                {                    
                    exerciseChosen = "Wall-Sits";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/wallsit.jpg");
                    startProgram();
                }
                else if (plankRadio.Checked)
                {                    
                    exerciseChosen = "Planking";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/plank.gif");
                    startProgram();
                }
                else if (jacksRadio.Checked)
                {                    
                    track = true;
                    exerciseChosen = "jumpingjacks";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/jumpingjack.gif");
                    startProgram();
                }
                else if (squatRadio.Checked)
                {                    
                    track = true;
                    exerciseChosen = "squat";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/squats.gif");
                    startProgram();
                }
                else if (biRadio.Checked)
                {                   
                    track = true;
                    exerciseChosen = "bicep";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/curls.gif");
                    startProgram();
                }
                else if (shoulderRadio.Checked)
                {                    
                    track = true;
                    exerciseChosen = "shoulderpress";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/press.gif");
                    startProgram();
                }
                else
                {
                    recording = false;
                    MessageBox.Show("Please select an exercise!");
                }
                
            }            
        }    
        private void startProgram()
        {
            timer2.Start();
            pushRadio.Enabled = false;
            sitRadio.Enabled = false;
            wallRadio.Enabled = false;
            plankRadio.Enabled = false;
            jacksRadio.Enabled = false;
            squatRadio.Enabled = false;
            biRadio.Enabled = false;
            shoulderRadio.Enabled = false;

            picRef.Image = pic;
            outLabel.Text = "Perform " + exerciseChosen;
            debugLabel.Text = "Capturing user performing " + exerciseChosen;
            if (track == true)
            {
                body.SetExercise(exerciseChosen);
                body.Start();
            }
        }    
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);


        private void timer2_Tick(object sender, EventArgs e)
        {
            timerMin++;
            timerSec++;
            timerMill++;
            if(track == true)
            {
                curCountLabel.Text = "" + body.count[exerciseChosen];                
            }
            
            minute = (int)timerMin / 600;

            if ((int)timerSec % 600 == 0)
            {
                timerSec = 0;
            }
            second = (int)timerSec / 10;

            if ((int)timerMill % 10 == 0)
            {
                timerMill = 0;
            }
            millisecond = (int)timerMill;

            if (second < 10)
            {
                if (minute < 10)
                {
                    timerLabel.Text = "0" + minute.ToString() + ":0" + second.ToString() + ":" + millisecond.ToString();
                }
            }

            else
            {
                if (minute < 10)
                {
                    timerLabel.Text = "0" + minute.ToString() + ":" + second.ToString() + ":" + millisecond.ToString();
                }
            }
        }           

        private void stopRec_Click(object sender, EventArgs e)
        {
            
            if(recording == true)
            {
                recording = false;
                pushRadio.Enabled = true;
                sitRadio.Enabled = true;
                wallRadio.Enabled = true;
                plankRadio.Enabled = true;
                jacksRadio.Enabled = true;
                squatRadio.Enabled = true;
                biRadio.Enabled = true;
                shoulderRadio.Enabled = true;
                track = false;
                picRef.Image = null;
                debugLabel.Text = "Stopped recording user";
                recordKeeping();
                body.Stop();
                timer2.Stop();
                checkCalories();
                MessageBox.Show("You just burned " + (int)calories + " calorie(s)!");
                
                timerMin = 0;
                timerSec = 0;
                timerMill = 0;
            }            
        }

        private void recordKeeping()
        {
            if (jacksRadio.Checked)
            {
                jump += body.count[exerciseChosen];
                jumpLabel.Text = "" + jump;
            }
            else if (squatRadio.Checked)
            {
                sq += body.count[exerciseChosen];
                sqLabel.Text = "" + sq;
            }
            else if (biRadio.Checked)
            {
                bi += body.count[exerciseChosen];
                biLabel.Text = "" + bi;
            }
            else if (shoulderRadio.Checked)
            {
                sh += body.count[exerciseChosen];
                shLabel.Text = "" + sh;
            }
            body.count[exerciseChosen] = 0;
            curCountLabel.Text = "0";
        }

        private void checkCalories()
        {
            if (jacksRadio.Checked)
            {
                calories = 10 * (timerMin / 600);
            }
            else if (squatRadio.Checked)
            {
                calories = 7.2 * (timerMin / 600);
            }
            else if (biRadio.Checked)
            {
                calories = 7 * (timerMin / 600);
            }
            else if (shoulderRadio.Checked)
            {
                calories = 6.3 * (timerMin / 600);
            }
        }

    }
}

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

namespace FitPro3D
{
    public partial class Form1 : Form
    {
        String exerciseChosen;
        Boolean record = false;
        double timerMin = 0.00;
        double timerSec = 0.00;
        double timerMill = 0.00;
        int minute, second, millisecond;
        Boolean startTimer = false;
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
        }
        private void Window_Loaded(object sender, EventArgs e)
        {
            //if (sensor.Count == 0)
            //{
            //    MessageBox.Show("No Kinects device detected", "Camera View");
            //    Application.Exit();
            //    return;
            //}

            //try
            //{
            //    // get first Kinect device attached on computer
            //    sensor = KinectSensor.GetDefault;

            //    // enable depth stream
            //    sensor.DepthStream.Enable();

            //    // enable color video stream
            //    sensor.ColorStream.Enable();

            //    // start the sensor
            //    sensor.Start();


            //    // connect up the video event handler
            //    sensor.ColorFrameReady += new EventHandler<ColorImageFrameReadyEventArgs>(myKinect_ColorFrameReady);

            //}
            //catch
            //{
            //    MessageBox.Show("Kinect initialise failed", "Camera viewer");
            //    Application.Exit();
            //}


        }

        private void startRec_Click(object sender, EventArgs e)
        {
            timer2.Start();
            record = true;
            if (pushRadio.Checked)
            {
                exerciseChosen = "Push-Ups";
                pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/pushup.gif");
            }
            else if (sitRadio.Checked)
            {
                exerciseChosen = "Sit-Ups";
                pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/situp.gif");
            }
            else if (wallRadio.Checked)
            {

                timer2.Start();
                exerciseChosen = "Wall-Sits";
                pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/wallsit.jpg");
            }
            else if (plankRadio.Checked)
            {
                startTimer = true;

                exerciseChosen = "Planking";
                pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/plank.gif");
            }
            else if (jacksRadio.Checked)
            {

                exerciseChosen = "jumpingjacks";
                pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/jumpingjack.gif");
            }
            else if (squatRadio.Checked)
            {
                exerciseChosen = "squat";
                pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/squats.gif");
            }
            else if (biRadio.Checked)
            {                
                exerciseChosen = "bicep";
                pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/curls.gif");
            }
            else if (shoulderRadio.Checked)
            {
                exerciseChosen = "shoulderpress";
                pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/press.gif");
            }
            else
            {
                MessageBox.Show("Please select an exercise!");
            }
            picRef.Image = pic;
            outLabel.Text = "Perform " + exerciseChosen;
            debugLabel.Text = "Capturing user performing " + exerciseChosen;            
            body.SetExercise(exerciseChosen);
            body.Start();
            
        }        
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);


        private void timer2_Tick(object sender, EventArgs e)
        {
            timerMin++;
            timerSec++;
            timerMill++;
            curCountLabel.Text = "" + body.count[exerciseChosen];
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

            record = false;
            debugLabel.Text = "Stopped recording user";
            body.Stop();
            timer2.Stop();
            checkCalories();
            MessageBox.Show("You just burned " + (int)calories + " calories!");
            
            timerMin = 0;
            timerSec = 0;
            timerMill = 0;
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

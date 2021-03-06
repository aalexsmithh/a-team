﻿using System;
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
        AudioFeedback input = new AudioFeedback();
        Boolean firstTime = true;
        String welcome = "OK! Let's get started. Please enter the starting position, and I'll make sure I can see you";
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
            Thread.Sleep(600); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            input.speak("Welcome to Fit Pro 3D. Please choose an exercise below, and click start to begin.");
        }


        private void exit_speech(String exercise, int count)
        {
            if (count < 2)
            {
                if (count == 0)
                {
                    input.speak("Haha, try again!");
                }
                else
                {
                    input.speak("Good job on that " + count + " " + exercise + "!");
                }
            }
            else
            {
                input.speak("Good job on those " + count + " " + exercise + "!");
            }
        }

        //OnFirstExerciseChosen


        //EntersBasePosition
        //private void enterPos()
        //{
        //    input.speak("Great, I can see you! Now you can start the exercise. After each repetition, I'll ring a bell to register the rep.");
        //}


        private void startRec_Click(object sender, EventArgs e)
        {           
            if (recording == false)
            {
                

                recording = true;

                if (pushRadio.Checked)
                {
                    if (firstTime == true)
                    {
                        input.speak(welcome);
                    }
                    firstTime = false;
                    exerciseChosen = "Push-Ups";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/pushup.gif");
                    startProgram();

                }
                else if (sitRadio.Checked)
                {
                    if (firstTime == true)
                    {
                        input.speak(welcome);
                    }
                    firstTime = false;
                    exerciseChosen = "Sit-Ups";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/situp.gif");
                    startProgram();
                }
                else if (wallRadio.Checked)
                {
                    if (firstTime == true)
                    {
                        input.speak(welcome);
                    }
                    firstTime = false;
                    exerciseChosen = "Wall-Sits";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/wallsit.jpg");
                    startProgram();
                }
                else if (plankRadio.Checked)
                {
                    if (firstTime == true)
                    {
                        input.speak(welcome);
                    }
                    firstTime = false;
                    exerciseChosen = "Planking";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/plank.gif");
                    startProgram();
                }
                else if (jacksRadio.Checked)
                {
                    if (firstTime == true)
                    {
                        input.speak(welcome);
                    }
                    firstTime = false;
                    track = true;
                    exerciseChosen = "jumpingjacks";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/jumpingjack.gif");
                    startProgram();
                }
                else if (squatRadio.Checked)
                {
                    if (firstTime == true)
                    {
                        input.speak(welcome);
                    }
                    firstTime = false;
                    track = true;
                    exerciseChosen = "squat";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/squats.gif");
                    startProgram();
                }
                else if (biRadio.Checked)
                {
                    if (firstTime == true)
                    {
                        input.speak(welcome);
                    }
                    firstTime = false;
                    track = true;
                    exerciseChosen = "bicep";
                    pic = Image.FromFile("C:/Users/Robert/Desktop/FitPro3D/curls.gif");
                    startProgram();
                }
                else if (shoulderRadio.Checked)
                {
                    if (firstTime == true)
                    {
                        input.speak(welcome);
                    }
                    firstTime = false;
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
            
            if (track == true)
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

            if (recording == true)
            {
                exit_speech(exerciseChosen, body.count[exerciseChosen]);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;

using Microsoft.Kinect;

namespace kinect_backend
{
    class Core
    {
        public Core()
        {
            InitExercises();

            sensor = KinectSensor.GetDefault();
            sensor.Open();

            reader = sensor.OpenMultiSourceFrameReader(FrameSourceTypes.Color | FrameSourceTypes.Depth | FrameSourceTypes.Infrared | FrameSourceTypes.Body);
            reader.MultiSourceFrameArrived += Reader_MultiSourceFrameArrived;

            frameLock = new Mutex();
        }

        public void SetExercise(string e)
        {
            currentExercise = e;
        }

        private void Reader_MultiSourceFrameArrived(object sender, MultiSourceFrameArrivedEventArgs e)
        {
            var reference = e.FrameReference.AcquireFrame();

            // Color
            // ...

            // Depth
            // ...
            
            // Infrared
            // ...

            // Body

            frameLock.WaitOne();
            using (var frame = reference.BodyFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    bodies = new Microsoft.Kinect.Body[frame.BodyFrameSource.BodyCount];

                    frame.GetAndRefreshBodyData(bodies);
                    int index = 0;
                    double[] angles = new double[actions[currentExercise].Length];

                    Body b = null;
                    foreach (var body in bodies)
                    {
                        if (body != null)
                        {
                            if (body.IsTracked)
                            {
                                b = body;
                                break;
                            }
                        }
                    }

                    if (b == null)
                    {
                        return;
                    }

                    bool pass = true;
                    bool good = true;
                    foreach (var act in actions[currentExercise])
                    {
                        Joint j1 = b.Joints[(JointType)act.x]; Vector3 v1 = new Vector3(j1);
                        Joint j2 = b.Joints[(JointType)act.y]; Vector3 v2 = new Vector3(j2);
                        Joint j3 = b.Joints[(JointType)act.z]; Vector3 v3 = new Vector3(j3);
                        double angle = Calc.getAngle(v1, v2, v3);
                        angles[index] = angle;

                        if (started)
                        {
                            if (angle > exercises[currentExercise][exercises[currentExercise].Length - 1][index] * 1.3 || angle < exercises[currentExercise][exercises[currentExercise].Length - 1][index] * 0.7)
                            {
                                good = false;
                            }
                        }
                        else
                        {
                            if (Math.Abs(exercises[currentExercise][0][index] - angle) > exercises[currentExercise][0][index] * 0.3)
                            {
                                pass = false;
                            }
                        }
                        index++;
                    }
                    if (started == false && pass)
                    {
                        started = true;
                        Console.WriteLine("Started");
                    }
                    else if (started && good)
                    {
                        count[currentExercise]++;
                        started = false;
                        Console.WriteLine("Count: " + count[currentExercise]);
                    }
                    Console.Clear();
                    foreach (double a in angles)
                    {
                        Console.WriteLine("angle: " + a);
                    }
                    Console.WriteLine("Count: " + count[currentExercise]);
                }
            }
            frameLock.ReleaseMutex();
        }

        void InitExercises()
        {
            count = new Dictionary<string, int>();
            actions = new Dictionary<string, Vector3[]>();
            exercises = new Dictionary<string, double[][]>();
            type = new Dictionary<string, string>();

            //test
            actions["test"] = new Vector3[2];
            actions["test"][0] = new Vector3((double)JointType.WristLeft, (double)JointType.ElbowLeft, (double)JointType.ShoulderLeft);
            actions["test"][1] = new Vector3((double)JointType.WristRight, (double)JointType.ElbowRight, (double)JointType.ShoulderRight);

            exercises["test"] = new double[2][];
            exercises["test"][0] = new double[actions["test"].Length];   //start position
            exercises["test"][1] = new double[actions["test"].Length];   //end position
            exercises["test"][0][0] = 170.0;
            exercises["test"][0][1] = 170.0;
            exercises["test"][1][0] = 90.0;
            exercises["test"][1][1] = 90.0;

            count["test"] = 0;

            type["test"] = "rep";

            //squat
            actions["squat"] = new Vector3[7];
            actions["squat"][0] = new Vector3(JointType.WristRight, JointType.ElbowRight, JointType.ShoulderRight);
            actions["squat"][1] = new Vector3(JointType.WristLeft, JointType.ElbowLeft, JointType.ShoulderLeft);
            actions["squat"][2] = new Vector3(JointType.Head, JointType.SpineMid, JointType.SpineBase);
            actions["squat"][3] = new Vector3(JointType.AnkleRight, JointType.KneeRight, JointType.HipRight);
            actions["squat"][4] = new Vector3(JointType.AnkleLeft, JointType.KneeLeft, JointType.HipLeft);
            actions["squat"][5] = new Vector3(JointType.ElbowRight, JointType.HipRight, JointType.AnkleRight);
            actions["squat"][6] = new Vector3(JointType.ElbowLeft, JointType.HipLeft, JointType.AnkleLeft);

            exercises["squat"] = new double[2][];
            exercises["squat"][0] = new double[actions["squat"].Length];   //start position
            exercises["squat"][1] = new double[actions["squat"].Length];   //end position
            exercises["squat"][0][0] = 60.0;
            exercises["squat"][0][1] = 60.0;
            exercises["squat"][0][2] = 170.0;
            exercises["squat"][0][3] = 170.0;
            exercises["squat"][0][4] = 170.0;
            exercises["squat"][0][5] = 150.0;
            exercises["squat"][0][6] = 150.0;
            exercises["squat"][1][0] = 45.0;
            exercises["squat"][1][1] = 45.0;
            exercises["squat"][1][2] = 175.0;
            exercises["squat"][1][3] = 50.0;
            exercises["squat"][1][4] = 50.0;
            exercises["squat"][1][5] = 120.0;
            exercises["squat"][1][6] = 120.0;

            count["squat"] = 0;

            type["squat"] = "rep";

            //push up
            actions["pushup"] = new Vector3[4];
            actions["pushup"][0] = new Vector3(JointType.WristRight, JointType.ElbowRight, JointType.ShoulderRight);
            //actions["pushup"][1] = new Vector3(JointType.WristLeft, JointType.ElbowLeft, JointType.ShoulderLeft);
            actions["pushup"][1] = new Vector3(JointType.Head, JointType.SpineMid, JointType.SpineBase);
            actions["pushup"][2] = new Vector3(JointType.AnkleRight, JointType.KneeRight, JointType.HipRight);
            //actions["pushup"][4] = new Vector3(JointType.AnkleLeft, JointType.KneeLeft, JointType.HipLeft);
            actions["pushup"][3] = new Vector3(JointType.ShoulderRight, JointType.Neck, JointType.ShoulderLeft);

            exercises["pushup"] = new double[2][];
            exercises["pushup"][0] = new double[actions["pushup"].Length];   //start position
            exercises["pushup"][1] = new double[actions["pushup"].Length];   //end position
            exercises["pushup"][0][0] = 165.0;
            //exercises["pushup"][0][1] = 175.0;
            exercises["pushup"][0][1] = 170.0;
            exercises["pushup"][0][2] = 170.0;
            //exercises["pushup"][0][4] = 160.0;
            exercises["pushup"][0][3] = 110.0;
            exercises["pushup"][1][0] = 90.0;
            //exercises["pushup"][1][1] = 65.0;
            exercises["pushup"][1][1] = 170.0;
            exercises["pushup"][1][2] = 175.0;
            //exercises["pushup"][1][4] = 100.0;
            exercises["pushup"][1][3] = 140.0;

            count["pushup"] = 0;

            //crunches
            actions["crunch"] = new Vector3[5];
            actions["crunch"][0] = new Vector3(JointType.WristRight, JointType.ElbowRight, JointType.ShoulderRight);
            actions["crunch"][1] = new Vector3(JointType.WristLeft, JointType.ElbowLeft, JointType.ShoulderLeft);
            actions["crunch"][2] = new Vector3(JointType.Head, JointType.SpineMid, JointType.SpineBase);
            actions["crunch"][3] = new Vector3(JointType.AnkleRight, JointType.KneeRight, JointType.HipRight);
            actions["crunch"][4] = new Vector3(JointType.AnkleLeft, JointType.KneeLeft, JointType.HipLeft);

            //situps
            actions["situp"] = new Vector3[5];
            actions["situp"][0] = new Vector3(JointType.WristRight, JointType.ElbowRight, JointType.ShoulderRight);
            actions["situp"][1] = new Vector3(JointType.WristLeft, JointType.ElbowLeft, JointType.ShoulderLeft);
            actions["situp"][2] = new Vector3(JointType.Head, JointType.SpineMid, JointType.SpineBase);
            actions["situp"][3] = new Vector3(JointType.AnkleRight, JointType.KneeRight, JointType.HipRight);
            actions["situp"][4] = new Vector3(JointType.AnkleLeft, JointType.KneeLeft, JointType.HipLeft);

            //wallsit
            actions["wallsit"] = new Vector3[5];
            //actions["wallsit"][0] = new Vector3(JointType.WristRight, JointType.ElbowRight, JointType.ShoulderRight);
            //actions["wallsit"][1] = new Vector3(JointType.WristLeft, JointType.ElbowLeft, JointType.ShoulderLeft);
            actions["wallsit"][0] = new Vector3(JointType.Head, JointType.SpineMid, JointType.SpineBase);
            actions["wallsit"][1] = new Vector3(JointType.AnkleRight, JointType.KneeRight, JointType.HipRight);
            actions["wallsit"][2] = new Vector3(JointType.AnkleLeft, JointType.KneeLeft, JointType.HipLeft);
            actions["wallsit"][3] = new Vector3(JointType.ElbowRight, JointType.HipRight, JointType.AnkleRight);
            actions["wallsit"][4] = new Vector3(JointType.ElbowLeft, JointType.HipLeft, JointType.AnkleLeft);

            exercises["wallsit"] = new double[1][];
            exercises["wallsit"][0] = new double[actions["wallsit"].Length];
            //exercises["wallsit"][0][0] = 160.0;
            //exercises["wallsit"][0][1] = 145.0;
            exercises["wallsit"][0][0] = 175.0;
            exercises["wallsit"][0][1] = 110.0;
            exercises["wallsit"][0][2] = 110.0;
            exercises["wallsit"][0][3] = 130.0;
            exercises["wallsit"][0][4] = 145.0;

            count["wallsit"] = 0;

            //bicep
            actions["bicep"] = new Vector3[3];
            actions["bicep"][0] = new Vector3(JointType.WristRight, JointType.ElbowRight, JointType.ShoulderRight);
            actions["bicep"][1] = new Vector3(JointType.WristLeft, JointType.ElbowLeft, JointType.ShoulderLeft);
            actions["bicep"][2] = new Vector3(JointType.Head, JointType.SpineMid, JointType.SpineBase);

            exercises["bicep"] = new double[2][];
            exercises["bicep"][0] = new double[actions["bicep"].Length];
            exercises["bicep"][1] = new double[actions["bicep"].Length];
            exercises["bicep"][0][0] = 170.0;
            exercises["bicep"][0][1] = 170.0;
            exercises["bicep"][0][2] = 175.0;
            exercises["bicep"][1][0] = 30.0;
            exercises["bicep"][1][1] = 30.0;
            exercises["bicep"][1][2] = 175.0;

            count["bicep"] = 0;

            //shoulderpress
            actions["shoulderpress"] = new Vector3[3];
            actions["shoulderpress"][0] = new Vector3(JointType.WristRight, JointType.ElbowRight, JointType.ShoulderRight);
            actions["shoulderpress"][1] = new Vector3(JointType.WristLeft, JointType.ElbowLeft, JointType.ShoulderLeft);
            actions["shoulderpress"][2] = new Vector3(JointType.Head, JointType.SpineMid, JointType.SpineBase);

            exercises["shoulderpress"] = new double[2][];
            exercises["shoulderpress"][0] = new double[actions["shoulderpress"].Length];
            exercises["shoulderpress"][1] = new double[actions["shoulderpress"].Length];
            exercises["shoulderpress"][0][0] = 90.0;
            exercises["shoulderpress"][0][1] = 90.0;
            exercises["shoulderpress"][0][2] = 175.0;
            exercises["shoulderpress"][1][0] = 175.0;
            exercises["shoulderpress"][1][1] = 175.0;
            exercises["shoulderpress"][1][2] = 175.0;

            count["shoulderpress"] = 0;

            //jumpingjacks
            actions["jumpingjacks"] = new Vector3[4];
            actions["jumpingjacks"][0] = new Vector3(JointType.WristRight, JointType.ShoulderRight, JointType.HipRight);
            actions["jumpingjacks"][1] = new Vector3(JointType.WristLeft, JointType.ShoulderLeft, JointType.HipLeft);
            actions["jumpingjacks"][2] = new Vector3(JointType.AnkleLeft, JointType.SpineBase, JointType.AnkleRight);
            actions["jumpingjacks"][3] = new Vector3(JointType.Head, JointType.SpineMid, JointType.SpineBase);

            exercises["jumpingjacks"] = new double[2][];
            exercises["jumpingjacks"][0] = new double[actions["jumpingjacks"].Length];
            exercises["jumpingjacks"][1] = new double[actions["jumpingjacks"].Length];
            exercises["jumpingjacks"][0][0] = 15.0;
            exercises["jumpingjacks"][0][1] = 15.0;
            exercises["jumpingjacks"][0][2] = 10.0;
            exercises["jumpingjacks"][0][3] = 175.0;
            exercises["jumpingjacks"][1][0] = 165.0;
            exercises["jumpingjacks"][1][1] = 165.0;
            exercises["jumpingjacks"][1][2] = 42.0;
            exercises["jumpingjacks"][1][3] = 175.0;

            count["jumpingjacks"] = 0;
        }

        private KinectSensor sensor;
        private MultiSourceFrameReader reader;
        private Microsoft.Kinect.Body[] bodies;
       
        private Mutex frameLock;

        bool started = false;
        double eps = 0.2;
        
        Dictionary<string, int> count;
        Dictionary<string, Vector3[]> actions;                  
        Dictionary<string, double[][]> exercises;
        Dictionary<string, string> type;

        string currentExercise = "shoulderpress";

        bool run;
    }
}

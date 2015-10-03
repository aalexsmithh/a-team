using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Kinect;

namespace kinect_backend
{
    class Core
    {
        public Core()
        {
            timer = new System.Diagnostics.Stopwatch();

            sensor = KinectSensor.GetDefault();
            sensor.Open();

            reader = sensor.OpenMultiSourceFrameReader(FrameSourceTypes.Color | FrameSourceTypes.Depth | FrameSourceTypes.Infrared | FrameSourceTypes.Body);
            reader.MultiSourceFrameArrived += Reader_MultiSourceFrameArrived;

            action = new Vector3[2];
            action[0] = new Vector3((double)JointType.HandLeft, (double)JointType.ElbowLeft, (double)JointType.ShoulderLeft);
            action[1] = new Vector3((double)JointType.HandRight, (double)JointType.ElbowRight, (double)JointType.ShoulderRight);
            mref = new double[2];
            mref[0] = 90.0;
            mref[1] = 90.0;
        }

        void Reader_MultiSourceFrameArrived(object sender, MultiSourceFrameArrivedEventArgs e)
        {
            if (timer.IsRunning && timer.ElapsedMilliseconds < 5000)
            {
                return;
            }
            timer.Stop();

            var reference = e.FrameReference.AcquireFrame();

            // Color
            // ...

            // Depth
            // ...

            // Infrared
            // ...

            // Body
            using (var frame = reference.BodyFrameReference.AcquireFrame())
            {
                if (frame != null)
                {
                    bodies = new Microsoft.Kinect.Body[frame.BodyFrameSource.BodyCount];

                    frame.GetAndRefreshBodyData(bodies);

                    double [] angle = new double[action.Length];
                    int index = 0;

                    int count = 0;
                    foreach (var body in bodies)
                    {
                        if (body != null)
                        {
                            if(body.IsTracked)
                            {
                                count++;
                            }
                        }
                    }

                    //if (count > 0)
                    //{
                        foreach (var body in bodies)
                        {
                            if (body != null)
                            {
                                if (body.IsTracked)
                                {
                                    foreach (var act in action)
                                    {
                                        Joint j1 = body.Joints[(JointType)act.x]; Vector3 v1 = new Vector3(j1.Position.X, j1.Position.Y, j1.Position.Z);
                                        Joint j2 = body.Joints[(JointType)act.y]; Vector3 v2 = new Vector3(j2.Position.X, j2.Position.Y, j2.Position.Z);
                                        Joint j3 = body.Joints[(JointType)act.z]; Vector3 v3 = new Vector3(j3.Position.X, j3.Position.Y, j3.Position.Z);
                                        angle[index++] = Calc.getAngle(v1, v2, v3);
                                    }
                                }
                            }
                        }
                        //angle[0] = 90.0; angle[1] = 90.0;
                        bool[] b = Calc.totalDiff(mref, angle, 5.0);
                        Calc.correct(b);
                    //}
                }
            }

            timer.Start();
        }

        private KinectSensor sensor;
        private MultiSourceFrameReader reader;
        private Microsoft.Kinect.Body[] bodies;
        private System.Diagnostics.Stopwatch timer;
       
        private Vector3[] action;
        private double[]  mref;
    }
}

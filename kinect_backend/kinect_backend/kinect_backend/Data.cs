using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Kinect;

namespace kinect_backend
{
    class Data
    {
        private KinectSensor sensor;

        Data()
        {
            sensor = KinectSensor.GetDefault();

            sensor.Open();
        }


    }
}

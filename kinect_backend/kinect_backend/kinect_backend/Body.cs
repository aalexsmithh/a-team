using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinect_backend
{
    class Body
    {
        public Body()
        {
            joints = new List<Vector3>();
        }

        public void addJoints(Vector3 j)
        {
            joints.Add(j);
        }

        public List<Vector3> joints;
    }
}

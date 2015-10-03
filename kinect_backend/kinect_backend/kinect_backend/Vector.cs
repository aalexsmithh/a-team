using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinect_backend
{
    class Vector3
    {
        public static double Dot(Vector3 v1, Vector3 v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public static Vector3 Cross(Vector3 v1, Vector3 v2)
        {
            double x = v1.y * v2.z - v1.z * v2.y;
            double y = v1.z * v2.x - v1.x * v2.z;
            double z = v1.x * v2.y - v1.y * v2.x;

            return new Vector3(x, y, z);
        }

        public Vector3 Sub(Vector3 v2)
        {
            return new Vector3(x - v2.x, y - v2.y, z - v2.z);
        }

        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + ")";
        }

        public void Normalize()
        {
            double l = Length();
            x /= l;
            y /= l;
            z /= l;
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double x, y, z;
    }
}

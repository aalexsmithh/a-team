using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinect_backend
{
    class Test
    {
        public static void Main()
        {
            Vector3 v1 = new Vector3(-1,1,1);
            Vector3 v2 = new Vector3(2,2,2);
            v1.Normalize();
            Console.WriteLine(v1.Length());
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinect_backend
{
    class Calc
    {
        static public double getAngle(Vector3 j0, Vector3 j1, Vector3 j2)
        {

            Vector3 v1; //declaration of the two vectors used
            Vector3 v2;

            v1 = j0.Sub(j1);
            v2 = j2.Sub(j1);

            v1.Normalize();
            v2.Normalize();

            double dotProduct = Vector3.Dot(v1, v2); 	//get dot product

            Vector3 crossProduct;						//get cross product vector and length of cross product
            crossProduct = Vector3.Cross(v1, v2);
            double crossProductLength = crossProduct.Length();

            double radianAngle = Math.Atan2(crossProductLength, dotProduct); //get radian angle between vectors
            double degreeAngle = radianAngle * (180 / Math.PI); //get angle in degrees
            double threedecimal = Math.Round(degreeAngle, 3);  //get degree angle in 3 decimal point accuracy

            return threedecimal;
        }

        static public double getDiff(double reference, double live)
        {

            double error = (Math.Abs(live - reference) / (reference)) * 100; //simple method to calculate %error given two angles
            return error;
        }

        static public bool[] totalDiff(double[] reference, double[] live, double threshold)
        { //iterates through an array of angles and calculates a total error

            double counter = 0; //totals number of terms for averaging later
            double totalError = 0; //totals error percentages

            bool[] correctness = new bool[live.Length + 1];

            for (int i = 0; i < live.Length; i++)
            {
                counter++;
                totalError += getDiff(reference[i], live[i]);

                if (getDiff(reference[i], live[i]) > threshold)
                {

                    correctness[i] = false; //denotes incorrect in the array
                }

                else
                {

                    correctness[i] = true; //denotes correct in the array

                }
            }
            if (totalError / counter > threshold)
            {
                correctness[correctness.Length - 1] = false;
            }
            else
            {
                correctness[correctness.Length - 1] = true;
            }

            return correctness;
        }

        static public bool correct(bool[] correctness)
        {

            bool total = true;
            String errs = "";
            bool individual = true;

            if (correctness[correctness.Length - 1] == false)
            {
                total = false;
            }
            for (int i = 0; i < correctness.Length - 1; i++)
            {
                if (correctness[i] == false)
                {
                    errs += " " + i;
                    individual = false;
                }
            }
            if (total && individual)
            {
                Console.WriteLine("Success!");
                return true;
            }
            else if (!total && individual)
            {
                Console.WriteLine("Individual joints have proper form but overall form is not");
                return false;
            }
            else if (total && !individual)
            {
                Console.WriteLine("Total form ok but individual joint form incorrect at array position(s):" + errs);
                return false;
            }
            else
            {
                Console.WriteLine("Total form incorrect and individual joint form incorrect at array position(s):" + errs);
                return false;
            }

        }
    }
}

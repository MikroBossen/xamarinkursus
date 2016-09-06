using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class Vector3D
    {
        //public double x, y, z;
        //private readonly double x, y, z;
        //private double x, y, z;

        // properties
        public double x
        {
            set; get; 
        }

        public double y
        {
            set; get;
        }

        public double z
        {
            set; get;
        }

        // constructor
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // find length of vector
        public double Length()
        {
            //return (Math.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z)));
            return (Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2)));
        }

        // add a new vector and return a Vector
        public Vector3D addVector(Vector3D nextVector)
        {
            double newX = this.x + nextVector.x;
            double newY = this.y + nextVector.y;
            double newZ = this.z + nextVector.z;

            Vector3D newVector = new Vector3D(newX, newY, newZ);

            return newVector;
        }

        // add multiple vectors and return a Vector
        public Vector3D addMultipleVector(Vector3D first, params Vector3D[] allVectors)
        {
            Vector3D newVector = new Vector3D(first.x, first.y, first.z);

            foreach (Vector3D item in allVectors)
            {
                newVector.x += item.x;
                newVector.y += item.y;
                newVector.z += item.z;
            }

            return newVector;
        }






        // add a new vector to existing vector
        public void addVector2(Vector3D nextVector)
        {
            this.x += nextVector.x;
            this.y += nextVector.y;
            this.z += nextVector.z;
        }

        // add multiple vectors to existing vector
        public void addMultipleVector2(params Vector3D[] allVectors)
        {
            foreach (Vector3D item in allVectors)
            {
                this.x += item.x;
                this.y += item.y;
                this.z += item.z;
            }
        }

        // add multiple vectors to existing vector using metode addVector2
        public void addMultipleVector3(params Vector3D[] allVectors)
        {
            foreach (Vector3D item in allVectors)
            {
                addVector2(item);
            }
        }
    }
}

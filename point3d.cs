using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdOOPtasks
{
    internal class point3d : IComparable, ICloneable
    {
        public int x {  get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public static point3d[] arr;

       

        public point3d() : this(0,0,0)
        {
           
        }
        public point3d(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates:({this.x},{this.y},{this.z})";
        }
        public  static bool operator == (point3d left, point3d right)
        {
            return left.x==right.x && left.y==right.y && left.z==right.z ;
        }
        public static bool operator != (point3d left, point3d right)
            { return !(left == right); }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;   // any object is greater than null

            point3d other = obj as point3d;
         
            // First compare by X
            if (this.x != other.x)
                return this.x.CompareTo(other.x);

            // If X is equal, compare by Y
            if (this.y != other.y)
                return this.y.CompareTo(other.y);

            //If X and Y are equal, compare by Z
            return this.z.CompareTo(other.z);
        }

        public object Clone()
        {
            return new point3d(this.x,this.y,this.z);
        }
       
    }
}

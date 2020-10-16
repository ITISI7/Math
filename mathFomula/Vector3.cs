using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace mathFomula
{
    public class Vector3
    {
       
        float x;
        float y;
        float z;

        public Vector3()
        {
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 VectorTranslate(Vector3 point, Vector3 vec)
        {
            Vector3 retVal = new Vector3();
            retVal.x = point.x + vec.x;
            retVal.y = point.y + vec.y;
            retVal.z = point.z + vec.z;
            return retVal;
        }

        public static Vector3 PointDiffrence(Vector3 lhs, Vector3 rhs)
        {
            Vector3 retVal = new Vector3();
            retVal.x = lhs.x - rhs.x;
            retVal.y = lhs.y - rhs.y;
            retVal.z = lhs.z - rhs.z;
            return retVal;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        public static Vector3 operator *(Vector3 vec, Vector3 scale)
        {
            Vector3 retval = new Vector3();
            retval.x = vec.x * scale.x;
            retval.y = vec.y * scale.y;
            retval.z = vec.z * scale.z;
            return retval;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mathFomula
{
     public class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

        public Matrix3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;

            this.m4 = m4;
            this.m5 = m5;
            this.m6 = m6;

            this.m7 = m7;
            this.m8 = m8;
            this.m9 = m9;
        }

        public void Set(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;

            this.m4 = m4;
            this.m5 = m5;
            this.m6 = m6;

            this.m7 = m7;
            this.m8 = m8;
            this.m9 = m9;
        }

        public void Set(Matrix3 other)
        {
            m1 = other.m1;
            m2 = other.m2;
            m3 = other.m3;

            m4 = other.m4;
            m5 = other.m5;
            m6 = other.m6;

            m7 = other.m7;
            m8 = other.m8;
            m9 = other.m9;
        }


        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            Matrix3 retVal = new Matrix3();
            retVal.m1 = lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3;
            retVal.m4 = lhs.m1 * rhs.m4 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m6;
            retVal.m7 = lhs.m1 * rhs.m7 + lhs.m4 * rhs.m8 + lhs.m7 * rhs.m9;

            retVal.m2 = lhs.m2 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m8 * rhs.m3;
            retVal.m5 = lhs.m2 * rhs.m4 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m6;
            retVal.m7 = lhs.m2 * rhs.m7 + lhs.m5 * rhs.m8 + lhs.m8 * rhs.m9;

            retVal.m3 = lhs.m3 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m9 * rhs.m3;
            retVal.m6 = lhs.m3 * rhs.m4 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m6;
            retVal.m9 = lhs.m3 * rhs.m7 + lhs.m6 * rhs.m8 + lhs.m9 * rhs.m9;

            return retVal;


        }

        public void setRotateX(float xRadians)
        {
            m1 = 1;
            m2 = 0;
            m3 = 0;

            m4 = 0;
            m5 = (float)Math.Cos(xRadians);
            m6 = (float)Math.Sin(xRadians);

            m7 = 0;
            m8 = (float)Math.Sin(xRadians);
            m9 = (float)Math.Cos(xRadians);

        }

        public void setRotateY(float yRadians)
        {
            m1 = (float)Math.Cos(yRadians);
            m2 = 0;
            m3 = (float)Math.Sin(yRadians);

            m4 = 0;
            m5 = 1;
            m6 = 0;

            m7 = (float)Math.Sin(yRadians);
            m8 = 0;
            m9 = (float)Math.Cos(yRadians);

        }
        public void setRotateZ(float zRadians)
        {
            m1 = (float)Math.Cos(zRadians);
            m2 = (float)Math.Sin(zRadians);
            m3 = 0;

            m4 = (float)Math.Sin(zRadians);
            m5 = (float)Math.Cos(zRadians);
            m6 = 0;

            m7 = 0;
            m8 = 0;
            m9 = 1;

        }



        public void rotateX(float xRadians)
        {
            Matrix3 rot = new Matrix3();
            rot.setRotateX(xRadians);

            Set(this * rot);
        }
        public void rotateY(float yRadians)
        {
            Matrix3 rot = new Matrix3();
            rot.setRotateY(yRadians);

            Set(this * rot);
        }
        public void rotateZ(float zRadians)
        {
            Matrix3 rot = new Matrix3();
            rot.setRotateZ(zRadians);

            Set(this * rot);
        }
    }
}

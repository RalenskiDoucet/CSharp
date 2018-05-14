using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{

        class Vector2
        {
            private static object other;
            public float mX;
            public float mY;
            public float mZ;
            public Vector2 add(Vector2)
            {
                Vector2 V2 = new Vector2();
                V2.mX = mX + other.mX;
                V2.mY = mY + other.mY;
                V2.mZ = mZ + other.mZ;
                return V2;
            }
            Vector2 subtract(Vector2)
            {
                Vector2 V2 = new Vector2();
                V2.mX = mX - other.mX;
                V2.mY = mY - other.mY;
                V2.mZ = mZ - other.mZ;
                return V2;
            }
            Vector2 multiply(Vector2)
            {
                Vector2 V2 = new Vector2();
                V2.mX = mX * other.mX;
                V2.mY = mY * other.mY;
                V2.mZ = mZ * other.mZ;
                return V2;
            }
            Vector2 dot(Vector2)
            {
                Vector2 V2 = new Vector2();
                V2.mX = mX * other.mX + mX * other.mX;
                V2.mY = mY * other.mY + mY * other.mY;
                V2.mZ = mZ + other.mZ + mZ * other.mZ;
                return V2;
            }

            Vector2 Cross(Vector2)
            {
                Vector2 V2 = new Vector2();
                V2.mX = mY * other.mZ - mZ * other.mY;
                V2.mY = mZ * other.mX - mX * other.mZ;
                V2.mZ = mX * other.mY - mY * other.mX;
                return V2;
            }
            Vector2 Magnitude(Vector2)
            {
                float mag = ((mX * mX) + (mY * mY));
                return mag;
            }
            Vector2 normalise(Vector2)
            {
                Vector2 V2;
                V2.mX = mX / Magnitude();
                V2.mY = mY / Magnitude();
                return V2;
            }

    }
    namespace Vec3
    {
        public class Vector3
        {
            public float mX;
            public float mY;
            public float mZ;
            Vector3 add(Vector3)
            {
                Vector3 V3 = new Vector3();
                V3.mX = mX + other.mX;
                V3.mY = mY + other.mY;
                V3.mZ = mZ + other.mZ;
                return V3;
            }
            Vector3 subtract(Vector3)
            {
                Vector3 V3 = new Vector3();
                V3.mX = mX - other.mX;
                V3.mY = mY - other.mY;
                V3.mZ = mZ - other.mZ;
                return V3;
            }

            Vector3 multilpy(Vector3)
            {
                Vector3 V3 = new Vector3();
                V3.mX = mX *other.mX;
                V3.mY = mY *other.mY;
                V3.mZ = mZ * other.mZ;
                return V3;
            }
            Vector3 Cross(Vector3)
            {
                Vector3 V3 = new Vector3();
                V3.mX = mY * other.mZ - mZ * other.mY;
                V3.mY = mZ * other.mX - mX * other.mZ;
                V3.mZ = mX * other.mY - mY * other.mX;
                return V2;
            }
            Vector3 Magnitude(Vector3)
            {
                float mag = ((mX * mX) + (mY * mY));
                return mag;
            }
            Vector3 normalise(Vector3)
            {
                Vector3 V3;
                V3.mX = mX / Magnitude();
                V3.mY = mY / Magnitude();
                return V3;
            }
    }
}

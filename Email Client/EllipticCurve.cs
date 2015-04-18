using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Email_Client
{
    class EllipticCurve
    {
        //parameter y^2 = x^3 + ax + b mod p
        BigInteger a, b, p;

        public BigInteger B
        {
            get { return b; }
            set { b = value; }
        }

        public BigInteger P
        {
            get { return p; }
            set { p = value; }
        }

        public BigInteger A
        {
            get { return a; }
            set { a = value; }
        }

        public static Point OH = new Point(BigInteger.Zero, BigInteger.Zero);
        public static BigInteger TWO = new BigInteger(2);

        public EllipticCurve(BigInteger a, BigInteger b, BigInteger p)
        {
            this.a = a;
            this.b = b;
            this.p = p;
        }


        public BigInteger modInverse(BigInteger a, BigInteger n)
        {
            BigInteger i = n, v = 0, d = 1;
            while (a > 0)
            {
                BigInteger t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0) v = (v + n) % n;
            return v;
        }

        public BigInteger mod(BigInteger a, BigInteger b)
        {

            BigInteger result = a % b;
            return (result.Sign >= 0 ? result : BigInteger.Add(result, b));
        }

        public Point invers(Point p)
        {
            return new Point(p.getX(), mod(BigInteger.Negate(p.getY()), this.p));
        }

        public Point substractPoint(Point p1, Point p2)
        {
            return addPoint(p1, invers(p2));
        }

        public Point addPoint(Point p1, Point p2)
        {
            if (p1.equal(OH))
            {
                return p2;
            }
            else if (p2.equal(OH))
            {
                return p1;
            }

            BigInteger gradient;

            if (!p1.getX().Equals(p2.getX()))
            {
                gradient = mod(BigInteger.Multiply(mod(BigInteger.Subtract(p1.getY(), p2.getY()), this.p), modInverse(mod(BigInteger.Subtract(p1.getX(), p2.getX()), this.p), this.p)), this.p);
            }
            else if (!p1.getY().Equals(p2.getY()))
            {
                return OH;
            }
            else //p1=p2
            {
                return doublePoint(p1);
            }

            BigInteger xr = mod(BigInteger.Subtract(BigInteger.Subtract(mod(BigInteger.Multiply(gradient, gradient), this.p), p1.getX()), p2.getX()), this.p);

            BigInteger yr = mod(BigInteger.Subtract(mod(BigInteger.Multiply(BigInteger.Subtract(p2.getX(), xr), gradient), this.p), p2.getY()), this.p);

            return new Point(xr, yr);
        }

        public Point doublePoint(Point p)
        {
            if (p.getY().Equals(BigInteger.Zero))
            {
                return OH;
            }

            BigInteger gradient;

            BigInteger x1sqr = mod(BigInteger.Multiply(p.getX(), p.getX()), this.p);
            BigInteger inv2y1 = modInverse(BigInteger.Add(p.getY(), p.getY()), this.p);
            gradient = mod(BigInteger.Multiply(BigInteger.Add(BigInteger.Add(BigInteger.Add(x1sqr, x1sqr), x1sqr), this.a), inv2y1), this.p);

            BigInteger xr = mod(BigInteger.Subtract(BigInteger.Subtract(mod(BigInteger.Multiply(gradient, gradient), this.p), p.getX()), p.getX()), this.p);
            BigInteger yr = mod(BigInteger.Subtract(mod(BigInteger.Multiply(BigInteger.Subtract(p.getX(), xr), gradient), this.p), p.getY()), this.p);

            return new Point(xr, yr);
        }

        public Point multiplyPoint(Point p, BigInteger k)
        {
            if (k.Equals(BigInteger.Zero))
            {
                return OH;
            }

            if (k.Equals(BigInteger.One))
            {
                return p;
            }
            else if (k % 2 == BigInteger.One)
            {
                return addPoint(p, multiplyPoint(p, BigInteger.Subtract(k, BigInteger.One)));
            }
            else
            {
                return multiplyPoint(doublePoint(p), BigInteger.Divide(k, TWO));
            }
        }
    }
}

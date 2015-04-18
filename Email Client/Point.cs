using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Numerics;

namespace Email_Client
{
    class Point
    {
        BigInteger x;

        public BigInteger X
        {

            set { x = value; }
        }
        BigInteger y;

        public BigInteger Y
        {

            set { y = value; }
        }

        public Point(BigInteger x, BigInteger y)
        {
            this.x = x;
            this.y = y;
        }

        public BigInteger getX()
        {
            return this.x;
        }

        public BigInteger getY()
        {
            return this.y;
        }

        public bool equal(Point p)
        {
            return (this.x.Equals(p.getX()) && this.y.Equals(p.getY()));
        }
    }
}

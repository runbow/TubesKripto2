using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TubesKripto2
{
    class Point
    {
        BigInteger x;
        BigInteger y;

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

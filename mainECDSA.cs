using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TubesKripto2
{
    class mainECDSA
    {
        //static string msgDigest = "2F82D0C845121B953D57E4C3C5E91E63";
        static string msgDigest;

        public static string MsgDigest
        {
            get { return mainECDSA.msgDigest; }
            set { mainECDSA.msgDigest = value; }
        }
        BigInteger n; // elliptic curve order
        EllipticCurve ec;
        private static Point G = new Point(15, 19); //basis point
        BigInteger privatekey;

        public BigInteger Privatekey
        {
            get { return privatekey; }
            set { privatekey = value; }
        }

        BigInteger decMsgDigest = BigInteger.Parse(MsgDigest, System.Globalization.NumberStyles.HexNumber);

        public mainECDSA()
        {
            n = new BigInteger(2819);
            ec = new EllipticCurve(15,2567,2903);
        }

        public void generateSignature(BigInteger privatekey, BigInteger decMsgDigest)
        {
            Random rand = new Random();
            BigInteger r = BigInteger.Zero;
            BigInteger s = BigInteger.Zero;

            getRandomk:
                BigInteger k = new BigInteger(rand.Next(1, 2009));

            Point p = ec.multiplyPoint(G, k);
            r = ec.mod(p.getX(), n);

            if (r.Equals(BigInteger.Zero))
            {
                goto getRandomk;
            }

            s = BigInteger.Multiply(ec.modInverse(k, n), ec.mod(BigInteger.Add(decMsgDigest, BigInteger.Multiply(privatekey, r)), n));

            if (s.Equals(BigInteger.Zero))
            {
                goto getRandomk;
            }

        }

        public bool verifySignature(BigInteger r, BigInteger s, Point Q)
        {
            if ((r >= 1 && r <= 2009) || (s >= 1 && s <= 2009))
            {
                return false;
            }

            BigInteger w = ec.modInverse(s, n);
            BigInteger u1 = ec.mod(BigInteger.Multiply(decMsgDigest, w), n);
            BigInteger u2 = ec.mod(BigInteger.Multiply(r, w), n);
            Point p = ec.addPoint(ec.multiplyPoint(G, u1), ec.multiplyPoint(Q, u2));
            if (p.getX().Equals(ec.mod(r, n)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

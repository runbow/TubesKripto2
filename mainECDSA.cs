using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ECDSAlgo
{
    class mainECDSA
    {
        //static string msgDigest = "2F82D0C845121B953D57E4C3C5E91E63";
        string msgDigest;

        public string MsgDigest
        {
            get { return msgDigest; }
            set { msgDigest = value; }
        }


        BigInteger n; // elliptic curve order
        EllipticCurve ec;
        private static Point G = new Point(15, 19); //basis point
        

        Point publicKey;

        internal Point PublicKey
        {
            get { return publicKey; }
            set { publicKey = value; }
        }
        Random rand = new Random();
        BigInteger r = BigInteger.Zero;

        public BigInteger R
        {
            get { return r; }
            set { r = value; }
        }
        BigInteger s = BigInteger.Zero;

        public BigInteger S
        {
            get { return s; }
            set { s = value; }
        }

        BigInteger privatekey;
        public BigInteger Privatekey
        {
            get { return privatekey; }
            set { privatekey = value; }
        }

        BigInteger decMsgDigest;

        // decMsgDigest = BigInteger.Parse(MsgDigest , System.Globalization.NumberStyles.HexNumber);

        public BigInteger DecMsgDigest
        {
            get { return decMsgDigest; }
            set { decMsgDigest = value; }
        }


        public mainECDSA()
        {
            n = new BigInteger(2819);
            ec = new EllipticCurve(15, 2567, 2903);
        }

        public void generateSignature()
        {


        getRandomk:
            BigInteger k = new BigInteger(rand.Next(1, 2818));

            Point p = ec.multiplyPoint(G, k);
            r = ec.mod(p.getX(), n);

            if (r.Equals(BigInteger.Zero))
            {
                goto getRandomk;
            }

            s = BigInteger.Multiply(ec.modInverse(k, n), ec.mod(BigInteger.Add(this.decMsgDigest, BigInteger.Multiply(this.privatekey, r)), n));

            if (s.Equals(BigInteger.Zero))
            {
                goto getRandomk;
            }

        }

        public bool verifySignature()
        {
            if ((this.r >= 1 && this.r <= 2817) || (this.s >= 1 && this.s <= 2817))
            {
                return false;
            }

            BigInteger w = ec.modInverse(this.s, n);
            BigInteger u1 = ec.mod(BigInteger.Multiply(decMsgDigest, w), n);
            BigInteger u2 = ec.mod(BigInteger.Multiply(this.r, w), n);
            Point p = ec.addPoint(ec.multiplyPoint(G, u1), ec.multiplyPoint(this.Q, u2));
            if (p.getX().Equals(ec.mod(this.r, n)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void generatePrivateKey()
        {
            this.Privatekey = rand.Next(1, 2817);

        }
        public void generatePublicKey()
        {
            this.PublicKey = ec.multiplyPoint(G, Privatekey);
        }
    }
}

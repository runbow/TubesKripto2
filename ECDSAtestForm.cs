using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;


namespace TubesKripto2
{
    public partial class ECDSAtestForm : Form
    {
        public ECDSAtestForm()
        {
            InitializeComponent();
        }

        mainECDSA mECDSA;
        static string md = "2F82D0C845121B953D57E4C3C5E91E63";

        private void enableSignatureCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSignatureCheck.Checked)
            {
                mECDSA = new mainECDSA();
                generateSignaturePair.Enabled = true;

            }
            else
            {
                generateSignaturePair.Enabled = false;
            }
        }

        private void generateSignaturePair_Click(object sender, EventArgs e)
        {
            mECDSA.MsgDigest = md;
            mECDSA.DecMsgDigest = mECDSA.mdToDecimal(md);
            mECDSA.generateSignature();

            rBox.Text = mECDSA.R.ToString();
            sBox.Text = mECDSA.S.ToString();

            //simpan nilai pada field ke dalam sistem
        }

        private void generatePublicKey_Click(object sender, EventArgs e)
        {
            if (privateKeyBox.Text == null)
            {
                MessageBox.Show("input private key");
            }
            else
            {
                mECDSA.generatePublicKey();
                publicKeyXBox.Text = mECDSA.PublicKey.getX().ToString();
                publicKeyYBox.Text = mECDSA.PublicKey.getY().ToString();
            }
        }

        private void generatePrivateKey_Click(object sender, EventArgs e)
        {
            mECDSA.generatePrivateKey();
            privateKeyBox.Text = mECDSA.Privatekey.ToString();
        }

        private void verifySignature_Click(object sender, EventArgs e)
        {
            mECDSA.R = BigInteger.Parse(rBox.Text);
            mECDSA.S = BigInteger.Parse(sBox.Text);
            if (mECDSA.verifySignature())
            {
                MessageBox.Show("Signature Valid");
            }
            else
            {
                MessageBox.Show("Siganture Invalid");
            }
        }
    }
}

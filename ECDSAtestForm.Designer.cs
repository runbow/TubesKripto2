namespace TubesKripto2
{
    partial class ECDSAtestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enableSignature = new System.Windows.Forms.CheckBox();
            this.generatePrivateKey = new System.Windows.Forms.Button();
            this.generatePublicKey = new System.Windows.Forms.Button();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.publicKeyXBox = new System.Windows.Forms.TextBox();
            this.publicKeyYBox = new System.Windows.Forms.TextBox();
            this.generateSignaturePair = new System.Windows.Forms.Button();
            this.rBox = new System.Windows.Forms.TextBox();
            this.sBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verifySignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enableSignature
            // 
            this.enableSignature.AutoSize = true;
            this.enableSignature.Location = new System.Drawing.Point(29, 28);
            this.enableSignature.Name = "enableSignature";
            this.enableSignature.Size = new System.Drawing.Size(104, 17);
            this.enableSignature.TabIndex = 0;
            this.enableSignature.Text = "enable signature";
            this.enableSignature.UseVisualStyleBackColor = true;
            this.enableSignature.CheckedChanged += new System.EventHandler(this.enableSignature_CheckedChanged);
            // 
            // generatePrivateKey
            // 
            this.generatePrivateKey.Location = new System.Drawing.Point(29, 60);
            this.generatePrivateKey.Name = "generatePrivateKey";
            this.generatePrivateKey.Size = new System.Drawing.Size(126, 23);
            this.generatePrivateKey.TabIndex = 1;
            this.generatePrivateKey.Text = "generate private key";
            this.generatePrivateKey.UseVisualStyleBackColor = true;
            this.generatePrivateKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // generatePublicKey
            // 
            this.generatePublicKey.Location = new System.Drawing.Point(29, 103);
            this.generatePublicKey.Name = "generatePublicKey";
            this.generatePublicKey.Size = new System.Drawing.Size(126, 23);
            this.generatePublicKey.TabIndex = 2;
            this.generatePublicKey.Text = "generate public key";
            this.generatePublicKey.UseVisualStyleBackColor = true;
            this.generatePublicKey.Click += new System.EventHandler(this.generatePublicKey_Click);
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(161, 62);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.Size = new System.Drawing.Size(100, 20);
            this.privateKeyBox.TabIndex = 3;
            // 
            // publicKeyXBox
            // 
            this.publicKeyXBox.Location = new System.Drawing.Point(161, 105);
            this.publicKeyXBox.Name = "publicKeyXBox";
            this.publicKeyXBox.Size = new System.Drawing.Size(100, 20);
            this.publicKeyXBox.TabIndex = 4;
            // 
            // publicKeyYBox
            // 
            this.publicKeyYBox.Location = new System.Drawing.Point(302, 105);
            this.publicKeyYBox.Name = "publicKeyYBox";
            this.publicKeyYBox.Size = new System.Drawing.Size(100, 20);
            this.publicKeyYBox.TabIndex = 5;
            // 
            // generateSignaturePair
            // 
            this.generateSignaturePair.Enabled = false;
            this.generateSignaturePair.Location = new System.Drawing.Point(105, 154);
            this.generateSignaturePair.Name = "generateSignaturePair";
            this.generateSignaturePair.Size = new System.Drawing.Size(148, 23);
            this.generateSignaturePair.TabIndex = 6;
            this.generateSignaturePair.Text = "generate signature pair";
            this.generateSignaturePair.UseVisualStyleBackColor = true;
            this.generateSignaturePair.Click += new System.EventHandler(this.generateSignaturePair_Click);
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(161, 203);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(100, 20);
            this.rBox.TabIndex = 7;
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(302, 202);
            this.sBox.Name = "sBox";
            this.sBox.Size = new System.Drawing.Size(100, 20);
            this.sBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "signature pair (r,s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = ",";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = ",";
            // 
            // verifySignature
            // 
            this.verifySignature.Location = new System.Drawing.Point(105, 251);
            this.verifySignature.Name = "verifySignature";
            this.verifySignature.Size = new System.Drawing.Size(148, 23);
            this.verifySignature.TabIndex = 12;
            this.verifySignature.Text = "verify signature";
            this.verifySignature.UseVisualStyleBackColor = true;
            this.verifySignature.Click += new System.EventHandler(this.verifySignature_Click);
            // 
            // ECDSAtestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 345);
            this.Controls.Add(this.verifySignature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.generateSignaturePair);
            this.Controls.Add(this.publicKeyYBox);
            this.Controls.Add(this.publicKeyXBox);
            this.Controls.Add(this.privateKeyBox);
            this.Controls.Add(this.generatePublicKey);
            this.Controls.Add(this.generatePrivateKey);
            this.Controls.Add(this.enableSignature);
            this.Name = "ECDSAtestForm";
            this.Text = "ECDSAtestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableSignature;
        private System.Windows.Forms.Button generatePrivateKey;
        private System.Windows.Forms.Button generatePublicKey;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.TextBox publicKeyXBox;
        private System.Windows.Forms.TextBox publicKeyYBox;
        private System.Windows.Forms.Button generateSignaturePair;
        private System.Windows.Forms.TextBox rBox;
        private System.Windows.Forms.TextBox sBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button verifySignature;
    }
}
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
            this.enableSignatureCheck = new System.Windows.Forms.CheckBox();
            this.generatePrivateKey = new System.Windows.Forms.Button();
            this.generatePublicKey = new System.Windows.Forms.Button();
            this.generateSignaturePair = new System.Windows.Forms.Button();
            this.verifySignature = new System.Windows.Forms.Button();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.publicKeyXBox = new System.Windows.Forms.TextBox();
            this.publicKeyYBox = new System.Windows.Forms.TextBox();
            this.rBox = new System.Windows.Forms.TextBox();
            this.sBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enableSignatureCheck
            // 
            this.enableSignatureCheck.AutoSize = true;
            this.enableSignatureCheck.Location = new System.Drawing.Point(28, 29);
            this.enableSignatureCheck.Name = "enableSignatureCheck";
            this.enableSignatureCheck.Size = new System.Drawing.Size(104, 17);
            this.enableSignatureCheck.TabIndex = 0;
            this.enableSignatureCheck.Text = "enable signature";
            this.enableSignatureCheck.UseVisualStyleBackColor = true;
            this.enableSignatureCheck.CheckedChanged += new System.EventHandler(this.enableSignatureCheck_CheckedChanged);
            // 
            // generatePrivateKey
            // 
            this.generatePrivateKey.Location = new System.Drawing.Point(28, 63);
            this.generatePrivateKey.Name = "generatePrivateKey";
            this.generatePrivateKey.Size = new System.Drawing.Size(115, 23);
            this.generatePrivateKey.TabIndex = 1;
            this.generatePrivateKey.Text = "generate private key";
            this.generatePrivateKey.UseVisualStyleBackColor = true;
            this.generatePrivateKey.Click += new System.EventHandler(this.generatePrivateKey_Click);
            // 
            // generatePublicKey
            // 
            this.generatePublicKey.Location = new System.Drawing.Point(28, 107);
            this.generatePublicKey.Name = "generatePublicKey";
            this.generatePublicKey.Size = new System.Drawing.Size(115, 23);
            this.generatePublicKey.TabIndex = 2;
            this.generatePublicKey.Text = "generate public key";
            this.generatePublicKey.UseVisualStyleBackColor = true;
            this.generatePublicKey.Click += new System.EventHandler(this.generatePublicKey_Click);
            // 
            // generateSignaturePair
            // 
            this.generateSignaturePair.Location = new System.Drawing.Point(119, 167);
            this.generateSignaturePair.Name = "generateSignaturePair";
            this.generateSignaturePair.Size = new System.Drawing.Size(141, 23);
            this.generateSignaturePair.TabIndex = 3;
            this.generateSignaturePair.Text = "generate pair signature";
            this.generateSignaturePair.UseVisualStyleBackColor = true;
            this.generateSignaturePair.Click += new System.EventHandler(this.generateSignaturePair_Click);
            // 
            // verifySignature
            // 
            this.verifySignature.Location = new System.Drawing.Point(119, 272);
            this.verifySignature.Name = "verifySignature";
            this.verifySignature.Size = new System.Drawing.Size(141, 23);
            this.verifySignature.TabIndex = 4;
            this.verifySignature.Text = "vierify signature";
            this.verifySignature.UseVisualStyleBackColor = true;
            this.verifySignature.Click += new System.EventHandler(this.verifySignature_Click);
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(160, 65);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.Size = new System.Drawing.Size(100, 20);
            this.privateKeyBox.TabIndex = 5;
            // 
            // publicKeyXBox
            // 
            this.publicKeyXBox.Location = new System.Drawing.Point(160, 109);
            this.publicKeyXBox.Name = "publicKeyXBox";
            this.publicKeyXBox.Size = new System.Drawing.Size(100, 20);
            this.publicKeyXBox.TabIndex = 6;
            // 
            // publicKeyYBox
            // 
            this.publicKeyYBox.Location = new System.Drawing.Point(289, 109);
            this.publicKeyYBox.Name = "publicKeyYBox";
            this.publicKeyYBox.Size = new System.Drawing.Size(100, 20);
            this.publicKeyYBox.TabIndex = 7;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(133, 221);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(100, 20);
            this.rBox.TabIndex = 8;
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(262, 221);
            this.sBox.Name = "sBox";
            this.sBox.Size = new System.Drawing.Size(100, 20);
            this.sBox.TabIndex = 9;
            // 
            // ECDSAtestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 329);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.publicKeyYBox);
            this.Controls.Add(this.publicKeyXBox);
            this.Controls.Add(this.privateKeyBox);
            this.Controls.Add(this.verifySignature);
            this.Controls.Add(this.generateSignaturePair);
            this.Controls.Add(this.generatePublicKey);
            this.Controls.Add(this.generatePrivateKey);
            this.Controls.Add(this.enableSignatureCheck);
            this.Name = "ECDSAtestForm";
            this.Text = "ECDSAtestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableSignatureCheck;
        private System.Windows.Forms.Button generatePrivateKey;
        private System.Windows.Forms.Button generatePublicKey;
        private System.Windows.Forms.Button generateSignaturePair;
        private System.Windows.Forms.Button verifySignature;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.TextBox publicKeyXBox;
        private System.Windows.Forms.TextBox publicKeyYBox;
        private System.Windows.Forms.TextBox rBox;
        private System.Windows.Forms.TextBox sBox;
    }
}
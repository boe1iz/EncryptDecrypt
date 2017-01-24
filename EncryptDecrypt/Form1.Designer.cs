namespace EncryptDecrypt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEncryptText = new System.Windows.Forms.Label();
            this.txtEncryptText = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtPassKey = new System.Windows.Forms.TextBox();
            this.lblPassKey = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.optEncrypt = new System.Windows.Forms.RadioButton();
            this.optDecrypt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblEncryptText
            // 
            this.lblEncryptText.AutoSize = true;
            this.lblEncryptText.Location = new System.Drawing.Point(12, 71);
            this.lblEncryptText.Name = "lblEncryptText";
            this.lblEncryptText.Size = new System.Drawing.Size(56, 13);
            this.lblEncryptText.TabIndex = 0;
            this.lblEncryptText.Text = "Your Text:";
            // 
            // txtEncryptText
            // 
            this.txtEncryptText.Location = new System.Drawing.Point(143, 68);
            this.txtEncryptText.Name = "txtEncryptText";
            this.txtEncryptText.Size = new System.Drawing.Size(227, 20);
            this.txtEncryptText.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(143, 138);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(227, 20);
            this.txtResult.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 141);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(82, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Encrypted Text:";
            // 
            // txtPassKey
            // 
            this.txtPassKey.Location = new System.Drawing.Point(143, 103);
            this.txtPassKey.Name = "txtPassKey";
            this.txtPassKey.Size = new System.Drawing.Size(227, 20);
            this.txtPassKey.TabIndex = 2;
            // 
            // lblPassKey
            // 
            this.lblPassKey.AutoSize = true;
            this.lblPassKey.Location = new System.Drawing.Point(12, 106);
            this.lblPassKey.Name = "lblPassKey";
            this.lblPassKey.Size = new System.Drawing.Size(76, 13);
            this.lblPassKey.TabIndex = 4;
            this.lblPassKey.Text = "Your PassKey:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(143, 183);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(227, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Proceed...";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(12, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(285, 20);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Text Encryption for IT Package  01";
            // 
            // optEncrypt
            // 
            this.optEncrypt.AutoSize = true;
            this.optEncrypt.Checked = true;
            this.optEncrypt.Location = new System.Drawing.Point(12, 183);
            this.optEncrypt.Name = "optEncrypt";
            this.optEncrypt.Size = new System.Drawing.Size(61, 17);
            this.optEncrypt.TabIndex = 5;
            this.optEncrypt.TabStop = true;
            this.optEncrypt.Text = "Encrypt";
            this.optEncrypt.UseVisualStyleBackColor = true;
            this.optEncrypt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.optEncrypt_MouseClick);
            // 
            // optDecrypt
            // 
            this.optDecrypt.AutoSize = true;
            this.optDecrypt.Location = new System.Drawing.Point(12, 207);
            this.optDecrypt.Name = "optDecrypt";
            this.optDecrypt.Size = new System.Drawing.Size(62, 17);
            this.optDecrypt.TabIndex = 6;
            this.optDecrypt.Text = "Decrypt";
            this.optDecrypt.UseVisualStyleBackColor = true;
            this.optDecrypt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.optDecrypt_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 234);
            this.Controls.Add(this.optDecrypt);
            this.Controls.Add(this.optEncrypt);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPassKey);
            this.Controls.Add(this.lblPassKey);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEncryptText);
            this.Controls.Add(this.lblEncryptText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encryption for IT Package  01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncryptText;
        private System.Windows.Forms.TextBox txtEncryptText;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtPassKey;
        private System.Windows.Forms.Label lblPassKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RadioButton optEncrypt;
        private System.Windows.Forms.RadioButton optDecrypt;
    }
}


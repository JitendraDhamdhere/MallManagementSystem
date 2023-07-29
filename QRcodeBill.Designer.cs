
namespace MMS
{
    partial class QRcodeBill
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Instance = new System.Windows.Forms.Panel();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Instance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Instance
            // 
            this.Instance.Controls.Add(this.btnDecode);
            this.Instance.Controls.Add(this.txtQRCode);
            this.Instance.Controls.Add(this.pictureBox);
            this.Instance.Controls.Add(this.cboDevice);
            this.Instance.Controls.Add(this.btnStart);
            this.Instance.Controls.Add(this.label1);
            this.Instance.Location = new System.Drawing.Point(40, 48);
            this.Instance.Name = "Instance";
            this.Instance.Size = new System.Drawing.Size(686, 420);
            this.Instance.TabIndex = 0;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(522, 182);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(116, 48);
            this.btnDecode.TabIndex = 17;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click_1);
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(400, 236);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.Size = new System.Drawing.Size(276, 163);
            this.txtQRCode.TabIndex = 16;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(22, 95);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(369, 304);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(111, 65);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(280, 24);
            this.cboDevice.TabIndex = 14;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(400, 182);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 48);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Camera";
            // 
            // QRcodeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 600);
            this.Controls.Add(this.Instance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QRcodeBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRcodeBill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRcodeBill_FormClosing);
            this.Load += new System.EventHandler(this.QRcodeBill_Load);
            this.Instance.ResumeLayout(false);
            this.Instance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Instance;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
    }
}
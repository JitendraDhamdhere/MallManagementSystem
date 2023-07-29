
namespace MMS
{
    partial class LoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Passtxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Passwordtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Emailtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoleList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Role :";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(171, 434);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(169, 45);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Login";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Forget Password...";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Passtxt
            // 
            this.Passtxt.AutoSize = true;
            this.Passtxt.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.Passtxt.Location = new System.Drawing.Point(31, 310);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(103, 24);
            this.Passtxt.TabIndex = 13;
            this.Passtxt.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(164, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login Panel";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordtxt.DefaultText = "";
            this.Passwordtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Passwordtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Passwordtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Passwordtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Passwordtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Passwordtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Passwordtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Passwordtxt.Location = new System.Drawing.Point(171, 298);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '\0';
            this.Passwordtxt.PlaceholderText = "";
            this.Passwordtxt.SelectedText = "";
            this.Passwordtxt.Size = new System.Drawing.Size(290, 36);
            this.Passwordtxt.TabIndex = 10;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emailtxt.DefaultText = "";
            this.Emailtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Emailtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Emailtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emailtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emailtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emailtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Emailtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emailtxt.Location = new System.Drawing.Point(171, 226);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.PasswordChar = '\0';
            this.Emailtxt.PlaceholderText = "";
            this.Emailtxt.SelectedText = "";
            this.Emailtxt.Size = new System.Drawing.Size(290, 36);
            this.Emailtxt.TabIndex = 9;
            // 
            // RoleList
            // 
            this.RoleList.FormattingEnabled = true;
            this.RoleList.Items.AddRange(new object[] {
            "Admin",
            "Member",
            "Tanant"});
            this.RoleList.Location = new System.Drawing.Point(171, 157);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(290, 24);
            this.RoleList.TabIndex = 18;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 553);
            this.Controls.Add(this.RoleList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Emailtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Passtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Passwordtxt;
        private Guna.UI2.WinForms.Guna2TextBox Emailtxt;
        private System.Windows.Forms.ComboBox RoleList;
    }
}
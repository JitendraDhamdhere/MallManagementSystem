using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (RoleList.Text == "Admin")    //logic to go what you choose in combobox
            {
                if (Emailtxt.Text == Passwordtxt.Text)
                {
                    AdminDash AD = new AdminDash();
                    AD.Show();
                    this.Hide();

                }
            }
            if (RoleList.Text == "Member")
            {
                if (Emailtxt.Text == Passwordtxt.Text)
                {
                    MemberDash MD = new MemberDash();
                    MD.Show();
                    this.Hide();
                }
            }
            if (RoleList.Text == "Tanant")
            {
                if (Emailtxt.Text == Passwordtxt.Text)
                {
                    TanantDash TD = new TanantDash();
                    TD.Show();
                    this.Hide();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

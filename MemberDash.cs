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
    public partial class MemberDash : Form
    {
        public MemberDash()
        {
            InitializeComponent();
        }

        public void loadform(object Form)     //create for pannel to call new forms
        {
            if (this.MPanel.Controls.Count > 0)
                this.MPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MPanel.Controls.Add(f);
            this.MPanel.Tag = f;
            f.Show();
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(Form: new QRcodeBill());    //calling form
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

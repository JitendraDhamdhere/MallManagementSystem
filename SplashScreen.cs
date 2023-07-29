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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void GetStartedBtn_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();  //use to go next page
            LF.Show();
            this.Hide();

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

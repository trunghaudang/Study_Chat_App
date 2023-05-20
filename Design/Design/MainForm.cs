using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChatRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select select = new Select();
            select.ShowDialog();
            this.Show();
        }

        private void btnVideoCallRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select select = new Select();
            select.ShowDialog();
            this.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
            this.Show();
        }
    }
}

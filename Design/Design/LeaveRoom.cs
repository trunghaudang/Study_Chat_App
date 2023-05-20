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
    public partial class LeaveRoom : Form
    {
        public LeaveRoom()
        {
            InitializeComponent();
        }

        private void gnBtnStay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void gnBtnLeave_Click(object sender, EventArgs e)
        {
            
        }
    }
}

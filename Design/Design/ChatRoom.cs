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
    public partial class ChatRoom : Form
    {
        public ChatRoom()
        {
            InitializeComponent();
        }

        private void gnBtnLeaveRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaveRoom leaveRoom = new LeaveRoom();
            leaveRoom.ShowDialog();
            this.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

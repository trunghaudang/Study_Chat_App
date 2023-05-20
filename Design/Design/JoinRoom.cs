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
    public partial class JoinRoom : Form
    {
        public JoinRoom()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatRoom chatRoom = new ChatRoom();
            chatRoom.ShowDialog();
            this.Show();
        }
    }
}

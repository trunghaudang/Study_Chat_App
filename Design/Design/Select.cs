﻿using System;
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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRoom createRoom = new CreateRoom();
            createRoom.ShowDialog();
            this.Show();
        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinRoom joinRoom = new JoinRoom();
            joinRoom.ShowDialog();
            this.Show();
        }
    }
}

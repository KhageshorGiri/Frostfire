﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrostFire.Adventure
{
    public partial class GameInterface : Form
    {
        public GameInterface()
        {
            InitializeComponent();
        }

        private void TestBtnClikcEvent(object sender, EventArgs e)
        {
            lblGold.Text = "Gold Here";
        }
    }
}

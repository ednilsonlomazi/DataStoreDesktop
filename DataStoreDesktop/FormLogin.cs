﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStoreDesktop
{
    public partial class FormLogin : Form
    {
        internal bool logado = false;
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogout_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.logado = true;
            
        }
    }
}

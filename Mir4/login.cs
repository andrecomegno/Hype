﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mir4
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bt_entrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                new menu().Show();
            }
            catch
            {

            }
            finally
            {
                
            }            
        }

        private void lb_novo_cad_Click(object sender, EventArgs e)
        {
            new criar_login().ShowDialog();
        }
    }
}

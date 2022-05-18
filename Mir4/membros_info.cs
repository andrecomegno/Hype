﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Mir4.Properties;
using Mir4.painel;

namespace Mir4
{
    public partial class membros_info : Form
    {

        public membros_info()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;            
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DadosMembros()
        {
            txt_data_entrada.Texts = membros.Instance.data_entrada;
            //membros.Instance.data_saida;
            //membros.Instance.data_remanejamento;
            txt_nick.Texts = membros.Instance.nick;
            txt_level.Texts = membros.Instance.level;
            txt_poder.Texts = membros.Instance.poder;
            txt_patente.Text = membros.Instance.patente;
            txt_classe.Text = membros.Instance.classe;
            txt_veio_cla.Texts =  membros.Instance.vem_do_cla;
            txt_esta_cla.Texts = membros.Instance.foi_para_cla;

            txt_esta_cla_rema.Texts = membros.Instance.foi_para_cla;
        }

        private void membros_info_Load(object sender, EventArgs e)
        {
            DadosMembros();
        }

        private void txt_data_entrada__TextChanged(object sender, EventArgs e)
        {
            txt_data_entrada.Texts = DateTime.Now.Date.ToShortDateString();
        }

        private void txt_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_classe.SelectedIndex == 0)
            {
                foto_classe.Image = Resources.Arbalista;

            }
            else if (txt_classe.SelectedIndex == 1)
            {
                foto_classe.Image = Resources.Mago;
            }
            else if (txt_classe.SelectedIndex == 2)
            {
                foto_classe.Image = Resources.Guerreiro;
            }
            else if (txt_classe.SelectedIndex == 3)
            {
                foto_classe.Image = Resources.Lanceiro;
            }
            else if (txt_classe.SelectedIndex == 4)
            {
                foto_classe.Image = Resources.Taoista;
            }
        }
    }
}
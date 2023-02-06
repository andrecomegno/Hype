using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hype.painel;
using Hype.script;
using MySql.Data.MySqlClient;

namespace Hype.painel
{
    public partial class conta_alt : UserControl
    {
        string id_alt = string.Empty;


        public conta_alt()
        {
            InitializeComponent();
        }

        public void DadosMembros()
        {
            // ALT
            id_alt = membros.Instance.id_membro;
            lb_data_entrada.Text = membros.Instance.data_entrada;
            txt_nick.Texts = membros.Instance.nick;

            txt_nick_01.Texts = membros.Instance.nick;


        }

    }
}

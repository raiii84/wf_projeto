using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_projeto
{
    public partial class Frm_DemostacaoKey : Form
    {
        public Frm_DemostacaoKey()
        {
            InitializeComponent();
        }

        private void Frm_DemostacaoKey_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Lower_Click(object sender, EventArgs e)
        {

        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Msg.AppendText("\r\n" + "Preessionei uma tecl" + e.KeyCode + "\r\n");
            txt_Msg.AppendText("\t" + "Codigo da tecla " + (int)e.KeyCode + "\r\n");
        }

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

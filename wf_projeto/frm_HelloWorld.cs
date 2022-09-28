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
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void frm_HelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Label Modificada !";
        }

        private void txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_ConteudoLabel.Text;
        }
    }
}

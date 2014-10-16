using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class F_prueba : Form
    {
        public F_prueba()
        {
            InitializeComponent();
        }

        private void B_msj_Click(object sender, EventArgs e)
        {
            L_msj.Text = "Haro TE AMO <3 ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            L_msj.Text = "Kuro yo también";
        }
    }
}

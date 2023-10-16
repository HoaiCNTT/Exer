using Giao_dien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT
{
    public partial class FormX : Form
    {
        public FormX()
        {
            InitializeComponent();
        }

        private void giaodien_Click(object sender, EventArgs e)
        {
            Form1 link1 = new Form1();
            link1.DialogShow();
        }
    }
}

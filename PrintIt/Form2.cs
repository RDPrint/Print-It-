using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintIt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formaprogram
{
    public partial class formText : Form
    {
        public formText()
        {
            InitializeComponent();
        }

        string name, desc;

        public string Name1 { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            name = txtNew.Text;
            desc = txtDescNew.Text;
            DialogResult = DialogResult.OK;
        }
    }
}

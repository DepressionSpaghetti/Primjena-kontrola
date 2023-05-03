using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Formaprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            switch(chkShow.Checked)
            {
                case false:
                    groupBox2.Hide();
                    break;
                case true:
                    groupBox2.Show();
                    break;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            switch(cmboRun.SelectedIndex)
            {
                case 0:
                    Process.Start("notepad.exe");
                    break;
                case 1:
                    Process.Start("mspaint.exe");
                    break;
            }
        }

        private void cmboRun_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmboRun.SelectedIndex)
            {
                case 0:
                    txtName.Text = "Notepad";
                    txtDesc.Text = "Allows the creation of simple text documents";
                    break;
                case 1:
                    txtName.Text = "Microsoft Paint";
                    txtDesc.Text = "Allows the creation of simple drawings";
                    break;
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDesc.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme.", "Obavjestenje", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Jeste li sigurni da zelite zatvoriti program", "Upozorenje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (msgBox == DialogResult.Yes) this.Close();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formText text = new formText();
            if (text.ShowDialog(Owner) == DialogResult.OK)
            {
                txtName.AppendText(text.Name1);
                txtDesc.AppendText(text.Desc);
            }
        }
    }
}

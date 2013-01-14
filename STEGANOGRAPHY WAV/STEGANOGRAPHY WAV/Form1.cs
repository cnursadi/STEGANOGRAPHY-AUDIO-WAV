using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STEGANOGRAPHY_WAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            GetFileName(dlg, browsefield, true);
        }
        private void GetFileName(FileDialog dialog, TextBox control, bool useFilter)
        {
            if (useFilter) { dialog.Filter = "Wave Audio (*.wav)|*.wav"; }
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                control.Text = dialog.FileName;
            }
        }
    }
}

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
using System.IO;

using AForge.Imaging.Filters;

namespace ScoreAnalysis
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult res = dlgOpen.ShowDialog();
            if (res != DialogResult.OK)
                return;

            String filename = dlgOpen.FileName;
            //pbImage.Load(filename);

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

        }
    }
}

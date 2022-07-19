using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InferenceV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (!CBOverlay.Checked)
            {
                FO.Hide();
                return;
            }

            FO.Show();
        }
        FormOverlay FO = new FormOverlay();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

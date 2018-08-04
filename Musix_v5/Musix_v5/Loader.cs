using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musix_v5
{
    public partial class Loader : Form
    {
        public Form1 Parent;

        public Loader()
        {
            InitializeComponent();
        }

        public void changeValue(int i)
        {
            progressBar1.Value += i;
            label1.Text = "Analysing " + (progressBar1.Value / progressBar1.Maximum) + " %";
        }

        private void Loader_Load(object sender, EventArgs e)
        {

        }
    }
}

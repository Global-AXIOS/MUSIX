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

namespace Musix_v5
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            foreach(string Path in Properties.Settings.Default.SearchPaths)
            {
                listBox1.Items.Add(Path);
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            
        }

        private void macTrackBar2_ValueChanged(object sender, decimal value)
        {
            label2.Text = macTrackBar2.Value + "%";
            Properties.Settings.Default.VolumeLimit = macTrackBar2.Value;
        }

        private void macTrackBar3_ValueChanged(object sender, decimal value)
        {
            Properties.Settings.Default.Balance = macTrackBar3.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(folderBrowserDialog1.SelectedPath);
                Properties.Settings.Default.SearchPaths.Add(folderBrowserDialog1.SelectedPath);
                try
                {
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Successfully Saved");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Could not save");
                }
            }
        }

        void DeleteSelectedItem()
        {
            MessageBox.Show("Delete " + listBox1.SelectedItem.ToString() + " ?");
            Properties.Settings.Default.SearchPaths.Remove(Properties.Settings.Default.SearchPaths[listBox1.SelectedIndex]);
            listBox1.Items.Remove(listBox1.SelectedItem);
            try
            {
                Properties.Settings.Default.Save();
                MessageBox.Show("Successfully Saved");
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not save");
            }
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (macTrackBar1.Checked == true)
            {
                macTrackBar2.Enabled = true;
            }
            else
            {
                macTrackBar2.Enabled = false;
            }
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            macTrackBar3.Value = 0;
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            Process.Start("MUSIX_Updator\\MUSIX_Updator.exe");
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            Process.Start("MUSIX_Repair\\MUSIX_Repair.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DeleteSelectedItem();
            }
        }
    }
}

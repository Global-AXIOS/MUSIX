using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Media;

namespace Musix_v5
{
    public partial class Form1 : Form
    {
        int min, s, min1, s1;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        SoundPlayer simpleSound = new SoundPlayer(@"Pling-SE.wav");
        bool RadioTab = false; 

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
           
        }

        void Playmusic(string src)
        {
           axWindowsMediaPlayer1.URL = src;

        }

        void loadMedia()
        {
                string SongTitle, songArtist, songAlbum;
                int year;

                Loader ld = new Loader();
                ld.Parent = this;
                ld.Show();
                listView1.Items.Clear();
                Properties.Settings.Default.SongURL.Clear();

                foreach (String radioNames in Properties.Settings.Default.IRadio_Name)
                {
                    listBox1.Items.Add(radioNames);
                }

                foreach (string Spath in Properties.Settings.Default.SearchPaths)
                {
                    var files = Directory.GetFiles(Spath, "*.*", SearchOption.AllDirectories)
                            .Where(s => s.EndsWith(".mp3") || s.EndsWith(".m4a") || s.EndsWith(".wav"));



                    foreach (string songs in files)
                    {
                        Properties.Settings.Default.SongURL.Add(songs);
                        ld.progressBar1.Maximum += 1;
                    }

                }

                foreach (string sng in Properties.Settings.Default.SongURL)
                {
                    if (sng != null && sng != "" && sng != " ")
                    {
                        TagLib.File musicFile = TagLib.File.Create(sng);
                        if (musicFile.Tag.Title != null && musicFile.Tag.Title.Length > 0)
                        {
                            SongTitle = musicFile.Tag.Title;
                        }
                        else
                            SongTitle = new FileInfo(sng).Name;

                        if (musicFile.Tag.Album != null && musicFile.Tag.Album.Length > 0)
                        {
                            songAlbum = musicFile.Tag.Album;
                        }
                        else
                            songAlbum = "N/A";


                        if (musicFile.Tag.Year > 0)
                        {
                            year = (int)musicFile.Tag.Year;
                        }
                        else
                            year = 0000;

                        ListViewItem itm = new ListViewItem(SongTitle);
                        itm.SubItems.Add(songAlbum);
                        itm.SubItems.Add(year.ToString());
                        listView1.Items.Add(itm);
                        ld.changeValue(1);

                    }

                }
            ld.Close();
            listView1.Focus();
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadMedia();            
        }
                 

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //formSkin1.Text = "MUSIX v5 - " + axWindowsMediaPlayer1.status;

            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsReady && axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying &&
                axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPaused && axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsStopped &&
                axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsUndefined)
                pictureBox3.Visible = true;
            else
                pictureBox3.Visible = false;

            flatTrackBar1.Maximum = Properties.Settings.Default.VolumeLimit;
            axWindowsMediaPlayer1.settings.volume = flatTrackBar1.Value;
            axWindowsMediaPlayer1.settings.balance = Properties.Settings.Default.Balance;

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                roundButton1.Visible = false;
                macTrackBar1.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                min = Convert.ToInt16(axWindowsMediaPlayer1.Ctlcontrols.currentPosition) / 60;
                s = Convert.ToInt16(axWindowsMediaPlayer1.Ctlcontrols.currentPosition) % 60;

                min1 = Convert.ToInt16(axWindowsMediaPlayer1.currentMedia.duration - axWindowsMediaPlayer1.Ctlcontrols.currentPosition) / 60;
                s1 = Convert.ToInt16(axWindowsMediaPlayer1.currentMedia.duration - axWindowsMediaPlayer1.Ctlcontrols.currentPosition ) % 60;

                string tim = string.Format("{0} : {1}", min.ToString("00"), s.ToString("00"));
                string tim1 = string.Format("{0} : {1}", min1.ToString("00"), s1.ToString("00"));

                label2.Text = tim;
                label3.Text = tim1;
            }
            else
            {
                roundButton1.Visible = true;
            }
        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            macTrackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);
            if (!axWindowsMediaPlayer1.URL.StartsWith("http"))
            {
                TagLib.File song = TagLib.File.Create(axWindowsMediaPlayer1.URL);
                if (song.Tag.Title != null && song.Tag.Title.Length > 0)
                {
                    label1.Text = song.Tag.Title;
                }
                else
                    label1.Text = new FileInfo(axWindowsMediaPlayer1.URL).Name;

                if (song.Tag.Pictures.Length >= 1)
                {
                    var bin = (byte[])(song.Tag.Pictures[0].Data.Data);
                    pictureBox1.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Dtafalonso_Yosemite_Flat_Music.ToBitmap();
                }
            }

        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            Settings sttng = new Settings();
            sttng.Show();
        }

        void playMusicURL()
        {
            int index = listView1.FocusedItem.Index;
            Playmusic(Properties.Settings.Default.SongURL[index]);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            playMusicURL();
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.ToLower().Contains(textBox1.Text.ToLower()) && textBox1.Text.Length > 0)
                    {
                        item.Selected = true;
                        item.BackColor = Color.CornflowerBlue;
                        item.ForeColor = Color.White;
                        listView1.FocusedItem = item;
                        listView1.EnsureVisible(listView1.FocusedItem.Index);
                    }
                    else
                    {
                        item.Selected = false;
                        item.BackColor = Color.White;
                        item.ForeColor = Color.Black;
                    }
                }
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SongURL.Clear();
            Properties.Settings.Default.SongNames.Clear();
            Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                axWindowsMediaPlayer1.settings.setMode("Loop", true);
            else
                axWindowsMediaPlayer1.settings.setMode("Loop", false);
        }

        private void playerColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reloadMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadMedia();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Musix will Restart\nIf you wish to stop this action select no","MUSIX SYSTEM ALERT", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("MUSIX will now Restart", "MUSIX SYSTEM ALERT");
                Application.Restart();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flatTrackBar1_Scroll(object sender)
        {
            //Properties.Settings.Default.VolumeLimit = flatTrackBar1.Value;
        }

        void playRadioURL()
        {
            try
            {
                axWindowsMediaPlayer1.URL = Properties.Settings.Default.IRadio_URL[listBox1.SelectedIndex];
                label1.Text = listBox1.SelectedItem + " (Live)";
            }
            catch (Exception err)
            {
                MessageBox.Show("Could not connect to " + listBox1.SelectedItem);
            }
            pictureBox1.Image = Properties.Resources.LiveListen;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            playRadioURL();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(flatTextBox2.Text, UriKind.Absolute))
            {
                Properties.Settings.Default.IRadio_Name.Add(flatTextBox1.Text);
                Properties.Settings.Default.IRadio_URL.Add(flatTextBox2.Text);
                listBox1.Items.Add(flatTextBox1.Text);
                MessageBox.Show("Radio station listed");
                flatTextBox1.Text = "Enter Radio Name Here";
                flatTextBox2.Text = "Enter Radio URL Here";
                Properties.Settings.Default.Save();
            }
            else
                MessageBox.Show("Invalid URL is given in Radio URL field");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                string itm = listBox1.Items[i].ToString();
                if (itm.ToLower().Contains(textBox1.Text.ToLower()) && textBox1.Text.Length > 0)
                {
                    listBox1.SelectedItem = listBox1.Items[i];
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playMusicURL();
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            simpleSound.Stop();
            if (e.Shift && e.KeyCode == Keys.Add && flatTrackBar1.Value < flatTrackBar1.Maximum)
            {
                flatTrackBar1.Value += 5;
                //simpleSound.Play();
            }
            else if (e.Shift && e.KeyCode == Keys.Subtract && flatTrackBar1.Value > 0)
            {
                flatTrackBar1.Value -= 5;
                //simpleSound.Play();
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.S)
                textBox1.Focus();
            
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playMusicURL();
                listView1.Focus();
                textBox1.Clear();
            }

            if (e.Shift && e.KeyCode == Keys.Add && flatTrackBar1.Value < flatTrackBar1.Maximum)
            {
                flatTrackBar1.Value += 5;
                //simpleSound.Play();
            }
            else if (e.Shift && e.KeyCode == Keys.Subtract && flatTrackBar1.Value > 0)
            {
                flatTrackBar1.Value -= 5;
                //simpleSound.Play();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void formSkin1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Add && flatTrackBar1.Value < flatTrackBar1.Maximum)
            {
                flatTrackBar1.Value += 5;
                //simpleSound.Play();
            }
            else if (e.Shift && e.KeyCode == Keys.Subtract && flatTrackBar1.Value > 0)
            {
                flatTrackBar1.Value -= 5;
                //simpleSound.Play();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            if (index < listView1.Items.Count - 1)
            {
                index++;
                listView1.FocusedItem = listView1.Items[index];
                axWindowsMediaPlayer1.URL = Properties.Settings.Default.SongURL[index];
            }
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            if (index > 0) {
                index--;
                listView1.FocusedItem = listView1.Items[index];
                axWindowsMediaPlayer1.URL = Properties.Settings.Default.SongURL[index];
            }
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void roundButton2_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void macTrackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToDouble(macTrackBar1.Value);
        }
    }
}

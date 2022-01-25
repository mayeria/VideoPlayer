using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            trackBarTime.Enabled = false;
            buttonDelete.Enabled = false;
            buttonDown.Enabled = false;
            buttonUp.Enabled = false;
            buttonPlayPlaylist.Enabled = false;
            labelRemain.Text = "";
            textBoxParameters.Text = "";
            labelTime.Text = "";
            panelPlaylistMenu.Visible = true;
        }

        bool menuPlaylist = true, largeVideo = false, full = false;

        private void listViewPlaylist_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string selectedFile = listViewPlaylist.FocusedItem.SubItems[1].Text;
                axWindowsMediaPlayer1.URL = @selectedFile;
                if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsTransitioning)
                    textBoxParameters.Text = "Ładowanie pliku...";
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Nie można odtworzyć pliku!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listViewPlaylist.Items.Count > 0)
                listViewPlaylist.SelectedItems[0].Remove();
            if (listViewPlaylist.Items.Count == 0)
            {
                trackBarTime.Enabled = false;
                buttonDelete.Enabled = false;
                buttonDown.Enabled = false;
                buttonUp.Enabled = false;
                buttonPlayPlaylist.Enabled = false;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listViewPlaylist.Items.Count > 0)
            {
                if (listViewPlaylist.SelectedItems.Count == 0)
                {
                    listViewPlaylist.Items[0].Focused = true;
                    listViewPlaylist_DoubleClick(sender, e);
                }
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
            }
        }

        private void buttonPlaylistMenu_Click(object sender, EventArgs e)
        {
            if (menuPlaylist)
            {
                menuPlaylist = false;
                panelPlaylistMenu.Visible = false;
            }
            else
            {
                menuPlaylist = true;
                panelPlaylistMenu.Visible = true;
            }
        }

        private void buttonPlayPlaylist_Click(object sender, EventArgs e)
        {
            if (listViewPlaylist.Items.Count > 0)
            {
                IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
                IWMPMedia media;

                for (int i = 0; i < listViewPlaylist.Items.Count; i++)
                {
                    media = axWindowsMediaPlayer1.newMedia(listViewPlaylist.Items[i].SubItems[1].Text);
                    playlist.appendItem(media);
                }

                axWindowsMediaPlayer1.currentPlaylist = playlist;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void trackBarTime_Scroll(object sender, EventArgs e)
        {
            labelRemain.Left = trackBarTime.Location.X + (trackBarTime.Width - 28) * trackBarTime.Value / trackBarTime.Maximum;
            labelRemain.Text = TimeSpan.FromSeconds(trackBarTime.Value).ToString(@"h\:m\:ss");
        }

        private void trackBarTime_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double remainTime = axWindowsMediaPlayer1.currentMedia.duration - axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            labelRemain.Text = TimeSpan.FromSeconds(remainTime).ToString(@"h\:m\:ss");
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition >= 0)
                labelTime.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration).ToString(@"h\:m\:ss");
            trackBarTime.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);
            try
            {
                trackBarTime.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            }
            catch { };
            toolTip1.SetToolTip(trackBarTime, TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString(@"h\:m\:ss"));
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (listViewPlaylist.SelectedItems.Count > 0)
            {
                var currentIndex = listViewPlaylist.SelectedItems[0].Index;
                var item = listViewPlaylist.Items[currentIndex];
                if (currentIndex > 0)
                {
                    listViewPlaylist.Items.RemoveAt(currentIndex);
                    listViewPlaylist.Items.Insert(currentIndex - 1, item);
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listViewPlaylist.SelectedItems.Count > 0)
            {
                var currentIndex = listViewPlaylist.SelectedItems[0].Index;
                var item = listViewPlaylist.Items[currentIndex];
                if (currentIndex < listViewPlaylist.Items.Count - 1)
                {
                    listViewPlaylist.Items.RemoveAt(currentIndex);
                    listViewPlaylist.Items.Insert(currentIndex + 1, item);
                }
            }
        }

        private void buttonMiniatures_Click(object sender, EventArgs e)
        {
            if (buttonMiniatures.Text == "🖼")
            {
                buttonMiniatures.Text = "📋";
                listViewPlaylist.View = View.LargeIcon;
                ImageList miniatures = new ImageList
                {
                    ImageSize = new Size(256, 158),
                    ColorDepth = ColorDepth.Depth24Bit
                };
                for (int i = 0; i < listViewPlaylist.Items.Count; i++)
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                        ffMpeg.GetVideoThumbnail(listViewPlaylist.Items[i].SubItems[1].Text, ms, 5);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                        miniatures.Images.Add(image);
                    }
                    catch { }
                }
                listViewPlaylist.LargeImageList = miniatures;
                for (int i = 0; i < listViewPlaylist.Items.Count; i++)
                    listViewPlaylist.Items[i].ImageIndex = i;
            }
            else
            {
                buttonMiniatures.Text = "🖼";
                listViewPlaylist.View = View.Details;
            }
        }

        private void trackBarTime_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Start();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBarTime.Value;
            labelRemain.Left = 3;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonURL_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelURL.Visible = true;
        }

        private void buttonOFD_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;

            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                RestoreDirectory = true,
                Multiselect = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string[] fileNameAndPath = openFileDialog1.FileNames;
                            string[] filename = openFileDialog1.SafeFileNames;

                            for (int i = 0; i < openFileDialog1.SafeFileNames.Count(); i++)
                            {
                                string[] saLvwItem = new string[2];
                                saLvwItem[0] = filename[i];
                                saLvwItem[1] = fileNameAndPath[i];

                                ListViewItem lvi = new ListViewItem(saLvwItem);
                                listViewPlaylist.Items.Add(lvi);
                            }

                            trackBarTime.Enabled = true;
                            buttonDelete.Enabled = true;
                            buttonDown.Enabled = true;
                            buttonUp.Enabled = true;
                            buttonPlayPlaylist.Enabled = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Nie można wczytać pliku z dysku!");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String path = Application.StartupPath + @"\playlist.txt";
            if (File.Exists(path))
                File.Delete(path);

            using (StreamWriter textStream = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (ListViewItem item in listViewPlaylist.Items)
                    textStream.WriteLine("{0},{1},", item.Text, item.SubItems[1].Text);
                textStream.Close();
            }
            MessageBox.Show("Playlista pomyślnie zapisana!");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            List<string> data = File.ReadAllLines("playlist.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' },
                       StringSplitOptions.RemoveEmptyEntries);
                listViewPlaylist.Items.Add(new ListViewItem(items));
            }

            if(listViewPlaylist.Items.Count > 0)
            {
                trackBarTime.Enabled = true;
                buttonDelete.Enabled = true;
                buttonDown.Enabled = true;
                buttonUp.Enabled = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listViewPlaylist.Items.Clear();
            trackBarTime.Enabled = false;
            buttonDelete.Enabled = false;
            buttonDown.Enabled = false;
            buttonUp.Enabled = false;
            buttonPlayPlaylist.Enabled = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                try
                {
                    if (textBox1.Text != "")
                    {
                        string fileNameAndPath = textBox1.Text;
                        string filename = Path.GetFileName(fileNameAndPath);
                        string[] saLvwItem = new string[2];
                        saLvwItem[0] = filename;
                        saLvwItem[1] = fileNameAndPath;

                        ListViewItem lvi = new ListViewItem(saLvwItem);
                        listViewPlaylist.Items.Add(lvi);

                        trackBarTime.Enabled = true;
                        buttonDelete.Enabled = true;
                        buttonDown.Enabled = true;
                        buttonUp.Enabled = true;
                        buttonPlayPlaylist.Enabled = true;
                    }

                    panelURL.Visible = false;
                }
                catch { }
                textBox1.Text = null;
            }
        }

        private void buttonFull_Click(object sender, EventArgs e)
        {
            if (full)
            {
                axWindowsMediaPlayer1.Size = new Size(658, 324);
                full = false;
            }
            else
            {
                axWindowsMediaPlayer1.Size = new Size(658, 386);
                full = true;
            }
        }

        private void buttonLarge_Click(object sender, EventArgs e)
        {
            if (largeVideo)
            {
                axWindowsMediaPlayer1.Size = new Size(658, 324);
                largeVideo = false;
                panelVideo.Size = new Size(278, 218);
                panelVideo.Location = new Point(383, 167);
                buttonLarge.Location = new Point(620, 138);
                buttonFull.Visible = false;
            }
            else
            {
                largeVideo = true;
                panelVideo.Size = new Size(660, 388);
                panelVideo.Location = new Point(12, 26);
                buttonLarge.Location = new Point(630, 3);
                buttonFull.Visible = true;
            }
        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            string title = axWindowsMediaPlayer1.currentMedia.name;
            for(int i = 0; i < listViewPlaylist.Items.Count; i++)
            {
                if (listViewPlaylist.Items[i].Text.Contains(title))
                {
                    listViewPlaylist.Items[i].Selected = true;
                    listViewPlaylist.Items[i].Focused = true;
                }
            }
            textBoxParameters.Text = "";
            try
            {
                var tagFile = TagLib.File.Create(listViewPlaylist.SelectedItems[0].SubItems[1].Text);
                textBoxParameters.Text = "PARAMETRY FILMU\r\nTytuł: " + tagFile.Name + "\r\nCzas: " + tagFile.Properties.Duration.ToString(@"h\:m\:ss") +
                    "\r\nOpis: " + tagFile.Properties.Description + "\r\nKodeki: ";
                for(int j = 0; j < tagFile.Properties.Codecs.Count(); j++)
                    textBoxParameters.Text += "\r\n- " + tagFile.Properties.Codecs.ElementAt(j);
            }
            catch { }
            if(textBoxParameters.Text == "")
                textBoxParameters.Text = "Tytuł: " + axWindowsMediaPlayer1.currentMedia.name + "\r\nCzas: " + TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration).ToString(@"h\:m\:ss");
            if (textBoxParameters.Text == "")
                textBoxParameters.Text = "Brak danych";
            if (axWindowsMediaPlayer1.currentMedia.duration == 0)
                textBoxParameters.Text = "Błąd ładowania filmu!";
        }
    }
}

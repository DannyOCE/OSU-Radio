using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

namespace OSU__Radio
{
    public partial class mainWindow : Form
    {
        //Environment.GetEnvironmentVariable("LocalAppData") + @"\osu!\Songs\

        string baseLocation = "";

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public Random randomGenerator = new Random();

        public List<string> songNames = new List<string>();

        public mainWindow()
        {
            InitializeComponent();

            osuDirBox.Text = Properties.Settings.Default.osuDIR;

            baseLocation = osuDirBox.Text + @"\Songs\";

            loadSongs();

            wplayer.settings.volume = 10;

            //wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(PlayStateChange);
        }

        private void PlayStateChange(int NewState)
        {
            Console.WriteLine((WMPLib.WMPPlayState)NewState);
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                
            }
        }

        public void loadSongs()
        {
            try
            {
                if (Properties.Settings.Default.osuDIR == "")
                {
                    MessageBox.Show("You needa set your OSU! location boss man.");
                    return;
                }

                songNames = Directory.GetDirectories(baseLocation).Select(Path.GetFileName).ToList();

                string songPath = getSongPath(baseLocation + songNames[0]);
                wplayer.URL = songPath;

                wplayer.controls.stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        public string getSongPath(string path)
        {
            Console.WriteLine("getSongPath() == " + path);
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.mp3"); //Getting MP3 files
            return path + @"\" + Files[0].Name;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (curPlayingLabel.Text == "Nothing is playing.")
            {
                shuffleButton_Click(null, null);
                return;
            }

            wplayer.controls.play();
            updater.Start();
        }

        private void volumeController_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = (int)volumeController.Value;
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            updater.Start();

            int randSong = randomGenerator.Next(0, songNames.Count);

            string songPath = getSongPath(baseLocation + songNames[randSong]);
            wplayer.URL = songPath;

            string songSplit = songNames[randSong].Split(' ')[0];

            Console.WriteLine(songSplit);

            string songName = songNames[randSong].Replace(songSplit, "");

            curPlayingLabel.Text = "Currently Playing: " + songName;

            wplayer.controls.play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
            updater.Stop();
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            var songTimeSpan = new TimeSpan(0, 0, (int)wplayer.controls.currentPosition); //Or TimeSpan.FromSeconds(seconds); (see Jakob C´s answer)
            var formattedString = string.Format("{0}:{1:00}", (int)songTimeSpan.TotalMinutes, songTimeSpan.Seconds);

            songTime.Text = formattedString;

            var lengthTimeSpan = new TimeSpan(0, 0, (int)wplayer.controls.currentItem.duration);
            lengthLabel.Text = "Length: " + string.Format("{0}:{1:00}", (int)lengthTimeSpan.TotalMinutes, lengthTimeSpan.Seconds);

            if (lengthTimeSpan == songTimeSpan)
            {
                Console.WriteLine("Time spans are the same: Shuffling.");
                shuffleButton_Click(null, null);
            }

            curPlayingLabel.Location = new Point(curPlayingLabel.Location.X + 5, curPlayingLabel.Location.Y);
            if (curPlayingLabel.Location.X > this.Width)
            {
                curPlayingLabel.Location = new Point(0 - curPlayingLabel.Width, curPlayingLabel.Location.Y);
            }
        }

        private void pickOSUDIR_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.osuDIR = osuDirBox.Text;
            Properties.Settings.Default.Save();

            baseLocation = osuDirBox.Text + @"\Songs\";

            loadSongs();
        }

        private void songBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string search = songNames.FirstOrDefault(c => c.Contains(searchBar.Text));

            Console.WriteLine(search);

            searchLabel.Text = "Search: " + search;

            if (searchBar.Text == "")
            {
                searchLabel.Text = "Search: ";
            }
        }

        private void changeSearch_Click(object sender, EventArgs e)
        {
            updater.Start();

            string clean = searchLabel.Text.Replace("Search: ", "");

            string songSplit = clean.Split(' ')[0];

            string songName = clean.Replace(songSplit, "");

            curPlayingLabel.Text = "Currently Playing: " + songName;

            string songPath = getSongPath(baseLocation + clean);
            wplayer.URL = songPath;

            wplayer.controls.play();
        }
    }
}

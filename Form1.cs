using System.Diagnostics;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChurchPlan
{
    public partial class Form1 : Form
    {

        private Root data;
        private List<Song> selectedSongs = new List<Song>();
        private bool isInitialised;
        private bool isPaused;
        private List<Label> labelsSongNumber;
        private List<Label> labelsSongBook;
        private List<ComboBox> comboBoxSongNumbers;
        private List<TextBox> textBoxSongVerses;
        private List<Label> labelSongTitles;
        private List<Button> btnSongPlayButtons;
        private List<Button> btnPreviewButtons;
        private SongsApi songsApi;
        private SongApi selectedSong;
        private int selectedVerse = 0;

        private Form2 form2;

        private bool isPresentationOn;

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            int primaryScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int primaryScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(
                primaryScreenWidth / 2 - this.Size.Width / 2,
                primaryScreenHeight / 2 - this.Size.Height / 2
            );

            InitElementLists();

            LoadAndDisplayDate();

            isInitialised = true;
        }

        private void InitElementLists()
        {
            labelsSongNumber = new List<Label>()
            {
                labelSong1, labelSong2, labelSong3, labelSong4, labelSong5, labelSong6,
                labelSong7, labelSong8, labelSong9, labelSong10, labelSong11, labelSong12
            };

            labelsSongBook = new List<Label>()
            {
                labelSong1Book, labelSong2Book, labelSong3Book, labelSong4Book, labelSong5Book, labelSong6Book,
                labelSong7Book, labelSong8Book, labelSong9Book, labelSong10Book, labelSong11Book, labelSong12Book
            };

            comboBoxSongNumbers = new List<ComboBox>()
            {
                comboBoxSong1Number, comboBoxSong2Number, comboBoxSong3Number, comboBoxSong4Number, comboBoxSong5Number, comboBoxSong6Number,
                comboBoxSong7Number, comboBoxSong8Number, comboBoxSong9Number, comboBoxSong10Number, comboBoxSong11Number, comboBoxSong12Number
            };

            textBoxSongVerses = new List<TextBox>()
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6,
                textBox7, textBox8, textBox9, textBox10, textBox11, textBox12
            };

            labelSongTitles = new List<Label>()
            {
                labelSong1Title, labelSong2Title, labelSong3Title, labelSong4Title, labelSong5Title, labelSong6Title,
                labelSong7Title, labelSong8Title, labelSong9Title, labelSong10Title, labelSong11Title, labelSong12Title
            };

            btnSongPlayButtons = new List<Button>()
            {
                btnSong1Play, btnSong2Play, btnSong3Play, btnSong4Play, btnSong5Play, btnSong6Play,
                btnSong7Play, btnSong8Play, btnSong9Play, btnSong10Play, btnSong11Play, btnSong12Play
            };

            btnPreviewButtons = new List<Button>()
            {
                btnPreview1, btnPreview2, btnPreview3, btnPreview4, btnPreview5, btnPreview6,
                btnPreview7, btnPreview8, btnPreview9, btnPreview10, btnPreview11, btnPreview12
            };
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadAndDisplayDate();
        }

        private void LoadAndDisplayDate()
        {
            data = Root.GetJsonData();
            comboBox1.DataSource = data.ChurchPlans;
            comboBox1.DisplayMember = "Date";

            // Set Default date
            selectedSongs = data.ChurchPlans[0].Songs;

            DisplaySongData();
            textBoxPlainText.Text = Program.GetPlainText();
            textBoxJsonAsText.Text = Program.GetJsonAsText();
        }

        private void DisplaySongData()
        {
            int nrOfSongs = selectedSongs.Count;

            songsApi = SongsApi.GetJsonData();

            for (int i = 0; i < nrOfSongs; i++)
            {
                labelsSongNumber[i].Visible = true;

                labelsSongBook[i].Visible = true;
                labelsSongBook[i].Text = selectedSongs[i].Book;

                comboBoxSongNumbers[i].Visible = true;
                comboBoxSongNumbers[i].DataSource = songsApi.AllSongs;
                comboBoxSongNumbers[i].DisplayMember = "Number";
                comboBoxSongNumbers[i].SelectedIndex = selectedSongs[i].Number - 1;

                textBoxSongVerses[i].Visible = true;
                textBoxSongVerses[i].Text = selectedSongs[i].VersesToString;

                labelSongTitles[i].Visible = true;
                labelSongTitles[i].Text = selectedSongs[i].Title;

                btnSongPlayButtons[i].Visible = true;

                btnPreviewButtons[i].Visible = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitialised)
            {
                return;
            }

            //selectedSongs = data.ChurchPlans[comboBox1.SelectedIndex].Songs;

            DisplaySongData();
            //lbSong1.Text = selectedSongs[0].Book;
        }

        private SongApi? GetSong(Button clickedButton)
        {
            int buttonTag = Convert.ToInt32(clickedButton.Tag);

            int songNumber = Convert.ToInt32(comboBoxSongNumbers[buttonTag - 1].Text);

            selectedSong = songsApi.GetSong(songNumber);

            SetVerseToPreview();

            tabControlRight.SelectedIndex = 0;

            return selectedSong;
        }

        private void StartStopPresentation(object sender)
        {
            Button clickedButton = (Button)sender;

            if (!isPresentationOn)
            {
                selectedVerse = 0;
                selectedSong = GetSong(clickedButton);

                form2 = new Form2();
                form2.DisplayVerse(selectedSong.Verses[selectedVerse]);
                form2.Opacity = 0;

                Screen[] screens = Screen.AllScreens;

                if (screens.Length > 1)
                {
                    form2.Location = new Point(Screen.PrimaryScreen.Bounds.Width + 1, 0);
                    form2.WindowState = FormWindowState.Maximized;
                    form2.FormBorderStyle = FormBorderStyle.None;
                }

                form2.Show();

                BlendPresOn();

                ShowPreviewLabelCurrentState();

                clickedButton.Text = "⏹";

                foreach (Button button in btnSongPlayButtons)
                {
                    if (button != clickedButton)
                        button.Enabled = false;
                }

                isPresentationOn = true;
            }
            else
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnPause.Enabled = false;

                labelPreview.Text = "...";

                labelPreview.Location = new Point(
                    panel1.Width / 2 - labelPreview.Width / 2,
                    panel1.Height / 2 - labelPreview.Height / 2
                );

                selectedSong = null;
                selectedVerse = 0;

                HidePreviewLabelCurrentState();

                BlendPresOff();
                form2.Close();
                form2 = null;
                foreach (Button button in btnSongPlayButtons)
                {
                    clickedButton.Text = "▶";

                    if (button != clickedButton)
                        button.Enabled = true;
                }

                isPresentationOn = false;
            }
        }

        private void BtnSongPlay_Click(object sender, EventArgs e)
        {
            StartStopPresentation(sender);

            if (selectedSong != null && selectedSong.Verses.Count > 1)
            {
                form2.DisplayVerse(selectedSong.Verses[selectedVerse]);
                btnNext.Enabled = true;
                btnPause.Enabled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.C:
            //        selectedVerse = "left";
            //        MessageBox.Show("left");
            //        break;
            //    case Keys.Right:
            //        selectedVerse = "right";
            //        MessageBox.Show("right");
            //        break;
            //}
        }

        private void TextBoxJsonAsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            selectedSong = GetSong(clickedButton);
            selectedVerse = 0;

            SetVerseToPreview();

            ShowPreviewLabelCurrentState();

            if (selectedSong.Verses.Count > 1)
            {
                btnNext.Enabled = true;
            }
            btnPrev.Enabled = false;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (selectedVerse >= 0)
            {
                selectedVerse--;
                SetVerseToPreview();

                if (form2 != null)
                    form2.DisplayVerse(selectedSong.Verses[selectedVerse]);

                btnNext.Enabled = true;
            }

            if (selectedVerse == 0)
                btnPrev.Enabled = false;

            ShowPreviewLabelCurrentState();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (selectedVerse < selectedSong.Verses.Count)
            {
                selectedVerse++;
                SetVerseToPreview();
                
                if (form2 != null)
                    form2.DisplayVerse(selectedSong.Verses[selectedVerse]);

                btnPrev.Enabled = true;
            }

            if (selectedVerse == selectedSong.Verses.Count - 1)
                btnNext.Enabled = false;

            ShowPreviewLabelCurrentState();
        }

        private void SetVerseToPreview()
        {
            if (selectedVerse >= selectedSong.Verses.Count)
                selectedVerse = 0;

            labelPreview.Text = selectedSong.Verses[selectedVerse].Replace("\n", "\r\n");

            labelPreview.Location = new Point(
                panel1.Width / 2 - labelPreview.Width / 2,
                panel1.Height / 2 - labelPreview.Height / 2
            );
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                BlendPresOff();
                //form2.Opacity = 0;
                isPaused = true;
            }
            else
            {
                BlendPresOn();
                //form2.Opacity = 1;
                isPaused = false;
            }
        }

        private void BlendPresOn()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(1);
                form2.Opacity = form2.Opacity + 0.05;
            }
        }

        private void BlendPresOff()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(1);
                form2.Opacity = form2.Opacity - +0.05;
            }
        }

        private void ShowPreviewLabelCurrentState()
        {
            labelCurrentPreviewNumber.Visible = true;
            labelCurrentPreviewNumber.Text = $"{selectedVerse + 1}. von {selectedSong.Verses.Count} Strophe(n)";
        }

        private void HidePreviewLabelCurrentState()
        {
            labelCurrentPreviewNumber.Visible = false;
        }
    }
}
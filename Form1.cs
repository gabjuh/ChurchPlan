using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChurchPlan
{
    public partial class Form1 : Form
    {

        private Root data;
        private List<Song> selectedSongs = new List<Song>();
        private bool isInitialised;

        public Form1()
        {
            InitializeComponent();

            LoadAndDisplayDate();

            isInitialised = true;
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
        }

        private void DisplaySongData()
        {
            for (int i = 0; i < selectedSongs.Count; i++)
            {
                // Title label


                // Number label
                // Number
                // Verses
                // ...
            }
            //lbSong1.Text = selectedSongs[0].Book;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitialised)
            {
                return;
            }

            selectedSongs = data.ChurchPlans[comboBox1.SelectedIndex].Songs;
            //lbSong1.Text = selectedSongs[0].Book;
        }
    }
}
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ChurchPlan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void DisplayVerse(string verse)
        {
            label1.Text = verse.Replace("\n", "\r\n");
            //label1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            label1.MaximumSize = new System.Drawing.Size();

            Screen[] screens = Screen.AllScreens;

            if (screens.Length > 1)
            {
                Screen secondScreen = screens[1];
                int secondScreenWidth = secondScreen.Bounds.Width;
                int secondScreenHeight = secondScreen.Bounds.Height;

                label1.Location = new Point(
                    secondScreenWidth / 2 - label1.Width / 2,
                    secondScreenHeight / 2 - label1.Height / 2
                );
            }
            else
            {
                this.Width = 500;
                this.Height = 300;

                label1.Font = new Font(label1.Font.FontFamily, 16, label1.Font.Style);

                label1.Location = new Point(
                    this.Width / 2 - label1.Width / 2,
                    this.Height / 3 - label1.Height / 3
                );
            }
        }
    }
}

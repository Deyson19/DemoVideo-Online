using AxWMPLib;

namespace DemoVideo_Online
{
    public partial class Form1 : Form
    {
        private AxWindowsMediaPlayer _MediaPlayer;
        public Form1()
        {
            InitializeComponent();

            _MediaPlayer = new AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1.URL = "https://www.skidrowstudios.com/mp4/03-BLACK%20CHURCH%20TRAILER%20-.mp4";
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}

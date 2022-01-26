namespace ElroubyCardsCore
{
    public partial class Score : System.Windows.Forms.Label
    {
        readonly System.Media.SoundPlayer Tick = new System.Media.SoundPlayer(Properties.Resources.AddScore);
        public int Value 
        { 
            get { return int.Parse(Text); } 
            set 
            { 
                Text = value.ToString();
                if (value != 0)
                {
                    Tick.Play();
                }
            } 
        }
        public Score()
        {
            InitializeComponent();
        }
    }
}



namespace ElroubyCardsCore.CardItems
{
    public partial class Field : System.Windows.Forms.PictureBox
    {
        public Owner Owner { get; set; }
        public Field()
        {
            InitializeComponent();
        }
        public int X { get { return Location.X; } set { Location = new System.Drawing.Point(value, Location.Y); } }
        public int Y { get { return Location.Y; } set { Location = new System.Drawing.Point(Location.X, value); } }
        public Card Card
        {
            get { return _Card; }
            set
            {
                _Card = value;
                Controls.Clear();
                try { (_Card.Parent as Field).Card = null; } catch { }
                Controls.Add(_Card);
                if (_Card != null) 
                {
                    _Card.Parent = this;
                    _Card.Image = null;
                }
            }
        }
        Card _Card;
        public bool Putable = true;
    }
}
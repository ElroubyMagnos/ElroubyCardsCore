using System.Drawing;
using System.Windows.Forms;

namespace ElroubyCardsCore.CardItems
{
    public partial class Card : PictureBox
    {
        public bool InUse = false;
        public sbyte Number = 0;
        public sbyte Type;
        public Image Face;
        public bool Movable = false;
        public Owner Owner { get; set; }
        public int X { get { return Location.X; } set { Location = new Point(value, Location.Y); } }
        public int Y { get { return Location.Y; } set { Location = new Point(Location.X, value); } }
        public bool Swayable
        {
            get { return Sway.Visible; }
            set 
            {
                Sway.Visible = value;
            }
        }
        public Card()
        {
            InitializeComponent();
        }
        public Field BeforeSwayParent;
    }
}

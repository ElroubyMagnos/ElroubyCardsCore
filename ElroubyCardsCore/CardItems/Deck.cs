using ElroubyCardsCore.Properties;
using System;
using System.Threading;

namespace ElroubyCardsCore.CardItems
{
    public partial class Deck : Field
    {
        public new Owner Owner { get; set; }
        public ControlCollection Cards
        {
            get { return Controls; }
            set { Cards = value; }
        }
        public Deck()
        {
            InitializeComponent();
        }

        public Card Draw(bool Movable, bool Flipped, Owner Owner)
        {
            Thread.Sleep(154);
            if (Cards.Count > 0)
            {
                if (Cards[new Random().Next(Controls.Count - 1)] is Card Draw)
                {
                    Cards.Remove(Draw);
                    Draw.Movable = Movable;
                    Draw.Owner = Owner;
                    if (Flipped) Draw.BackgroundImage = Resources.back;
                    return Draw;
                }
            }
            return null;
        }
    }
}
using ElroubyCardsCore.CardItems;
using System.Linq;
using System.Windows.Forms;

namespace ElroubyCardsCore
{
    public partial class HandField : FlowLayoutPanel
    {
        public Owner Owner;
        public bool Putable = true;
        public HandField() => InitializeComponent();
        public ControlCollection Cards { get { return Controls; } }
        public System.Collections.Generic.List<Card> AllCards()
        {
            System.Collections.Generic.List<Card> AllCards = new System.Collections.Generic.List<Card>();
            foreach (Card Card in Cards) AllCards.Add(Card);
            return AllCards;
        }
    }
}

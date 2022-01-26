using ElroubyCardsCore.CardItems;
using System.Threading;

namespace ElroubyCardsCore
{
    public class Owner
    {
        public bool Turn = false;
        public Owner(string Name, HandField eHandField, Score eScoreContainer, Field[] eMidTableFields, Deck eScoreDeck, bool IsGuest, Owner eOpponent)
        {
            HandField = eHandField; 
            HandField.Owner = this;
            ScoreContainer = eScoreContainer;
            MidTableFields = eMidTableFields;
            MidTableFields[0].Owner = this;
            MidTableFields[1].Owner = this;
            ScoreDeck = eScoreDeck; 
            ScoreDeck.Owner = this;
            if (IsGuest) { HandField.Putable = false; MidTableFields.Putable(false); }
            else { HandField.Putable = true; MidTableFields.Putable(true); }
            Opponent = eOpponent;
            this.IsGuest = IsGuest;
            this.Name = Name;
        }
        public string Name;
        public bool IsGuest;
        public bool AI = false;
        public HandField HandField;
        public Deck ScoreDeck;
        public Score ScoreContainer;
        public Field[] MidTableFields;
        public Owner Opponent { get; set; }
        public void CalculateScore()
        {
            new Thread(
                new ThreadStart(() =>
                {
                    int Count = 0;
                    foreach (Card Card in ScoreDeck.Cards)
                        Count += Card.Number;
                    ScoreContainer.Value = Count;
                })).Start();
        }
    }
}

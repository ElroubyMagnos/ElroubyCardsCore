using ElroubyCardsCore.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ElroubyCardsCore.CardItems;

namespace ElroubyCardsCore
{
    public static class Extensions
    {
        public static List<Card> ToList(this Control.ControlCollection Cards)
        {
            List<Card> CardsList = new List<Card>();
            foreach (Card Card in Cards) CardsList.Add(Card);
            return CardsList;
        }

        public static void Stabilize(this Control.ControlCollection Cards)
        {
            foreach (Card Card in Cards.OfType<Card>()) 
                Card.Movable(false);
        }
        public static bool Contains(this Field[] Fields, Card Card)
        {
            foreach (Field Field in Fields) 
                if (Field.Card == Card) 
                    return true;
            return false;
        }
        public static bool Contains(this Field[] Fields, bool Movable, bool Swayable)
        {
            foreach (Field Field in Fields)
                if (Field.Card != null)
                if (Field.Card.Movable == Movable && Field.Card.Swayable == Swayable)
                    return true;
            return false;
        }
        public static Card Movable(this Field[] Fields)
        {
            foreach (Field Field in Fields) if (Field.Card.Movable) return Field.Card;
            return null;
        }
        public static bool Equal(this Field[] Fields, Field eField)
        {
            foreach (Field Field in Fields) if (Field == eField) return true;
            return false;
        }
        public static Field[] Flip(this Field[] Fields)
        {
            foreach (Field Field in Fields) Field.Card.Flip();
            return Fields;
        }
        public static Card Flip(this Card Card)
        {
            if (Card != null)
            {
                Card.BackgroundImage = Card.Face;
            }
            return Card;
        }
        public static Card Back(this Card Card)
        {
            if (Card != null) Card.BackgroundImage = Resources.back;
            return Card;
        }
        public static Card Owner(this Card Card, Owner Owner)
        {
            if (Card != null)
            {
                Card.Owner = Owner;
                return Card;
            }
            return null;
        }
        public static bool IsNull(this Field[] Fields)
        {
            int True = 0;
            foreach (Field Field in Fields) if (Field.Card == null) True++;
            if (True == Fields.Count()) return true;
            else return false;
        }
        public static void Putable(this Field[] Fields, bool Putable)
        {
            foreach (Field Field in Fields) Field.Putable = Putable;
        }
        public static void AddCard(this Control Container, Card Card)
        {
            if (Container is Field)
                (Container as Field).AddCard(Card);
            else if (Container is Deck)
                (Container as Deck).AddCard(Card);
            else if (Container is HandField)
                (Container as HandField).Add(Card);
        }
        public static void AddCard(this Field Container, Card Card)
        {
            try { (Card.Parent as Field).Card = null; } catch { }
            try { (Card.Parent as Deck).Cards.Remove(Card); } catch { }

            Card.Swayable(false);
            Card.Parent = Container;
            Card.Location = new Point();
            Card.Owner = Container.Owner;
        }
        public static void AddCards(this Deck Deck, List<Card> Cards)
        {
            foreach (Card Card in Cards) 
                Deck.AddCard(Card);
        }
        public static void Add(this HandField HandField, Card Card)
        {
            if (Card != null)
            {
                try { (Card.Parent as Field).Card = null; } catch { }
                try { (Card.Parent as Deck).Cards.Remove(Card); } catch { }
                HandField.Cards.Add(Card);
                Card.Swayable(false);
                Card.Parent = HandField;
                Card.Owner = HandField.Owner;
                Card.Movable = !Card.Owner.IsGuest;
                if (Card.Owner.IsGuest) Card.Back();
                else Card.Flip();
                Card.Image = null;
                Card.InUse = false;
            }
        }
        public static void Movable(this Field[] Fields, bool Movable)
        {
            foreach (Field Field in Fields) 
                if (Field.Card != null) 
                    Field.Card.Movable(Movable);
        }
        public static Card Playable(this Card Card)
        {
            Card.Movable = true;
            Card.Image = null;
            Card.Swayable = false;
            return Card;
        }
        public static Card Movable(this Card Card, bool Movable)
        {
            Card.Movable = Movable;
            return Card;
        }
        public static Card Swayable(this Card Card, bool Swayable)
        {
            if (Card != null) Card.Swayable = Swayable;
            return Card;
        }
        public static Field[] Swayable(this Field[] Fields)
        {
            Field[] Containers = Fields;
            foreach (Field Field in Containers) 
                Field.Card.Swayable = true;
            return Containers;
        }
        public static Card BeforeSwayParent(this Card Card)
        {
            if (Card != null && Card.BeforeSwayParent != null)
            {
                Card.Controls.Add(Card.Sway);
                Card.Parent = Card.BeforeSwayParent;
                Card.BeforeSwayParent.Card = Card;
                Card.BeforeSwayParent = null;
                return Card;
            }
            return null;
        }
        public static bool BiggerThan(this Card Card, Card Card2)
        {
            if (Card.Number < Card2.Number || (Card.Number == Card2.Number && Card.Type < Card2.Type)) 
                return false;
            return true;
        }
        public static Card BiggestCard(this Card[] Cards)
        {
            Card BiggestCard = new Card();
            foreach (Card Card in Cards) 
                if (!BiggestCard.BiggerThan(Card)) 
                    BiggestCard = Card;
            return BiggestCard;
        }
        public static Card[] Cards(this Field[] Fields)
        {
            List<Card> Cards = new List<Card>();
            foreach (Field Field in Fields) Cards.Add(Field.Card);
            return Cards.ToArray();
        }
        public static Field EmptyField(this Field[] Fields)
        {
            if (Fields.Contains(null) && !Fields.IsNull())
                foreach (Field Field in Fields)
                {
                    if (Field.Card == null)
                        return Field;
                }
            return null;
        }
        public static Card Card(this Field[] Fields)
        {
            if (Fields.Contains(null) && !Fields.IsNull()) foreach (Field Field in Fields) if (Field.Card != null) return Field.Card;
            return null;
        }
        public static List<Card> CardList(this Field[] Fields)
        {
            List<Card> Cards = new List<Card>();
            foreach (Field Field in Fields)
            {
                Cards.Add(Field.Card);
            }
            return Cards;
        }
    }
}

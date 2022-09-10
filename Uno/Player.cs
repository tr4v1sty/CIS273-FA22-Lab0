using System;


namespace Uno
{
	public class Player
	{
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public Player()
		{

            Name = "";
            Hand = new List<Card>();

        }


		public Card GetFirstPlayableCard(Card card)
		{
            return new Card( card.Type, card.Color, card.Number);
            
        }

		public bool HasPlayableCard(Card card)
		{
            return false;
        }
        public Color MostCommonColor()
        {
            return Color.Blue;
        }
    }
}


using System;
using System.Reflection;


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


		public Card? GetFirstPlayableCard(Card card)
		{
            int i = 0;
            int index = -1;
            while ((i < Hand.Count) && (index == -1))
            {
                if (Card.PlaysOn(Hand[i],card))
                {
                    index = i;
                }
                
                i++;


            }
            if (index != -1)
            {
                return Hand[index];
            }
            
            return null;
            
        }

		public bool HasPlayableCard(Card card)
		{
            int i = 0;
            bool index = false;
            while ((i < Hand.Count) && (!index))
            {
                if (Card.PlaysOn(Hand[i], card))
                {
                    index = true;
                }
                i++;


            }

            return index;
        }
        public Color MostCommonColor()
        {
            return Color.Blue;
        }
    }
}


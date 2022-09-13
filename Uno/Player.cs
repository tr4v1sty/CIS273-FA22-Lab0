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
            int redcount = 0;
            int bluecount = 0;
            int greencount = 0;
            int yellowcount =0;
            int wildcount = 0;

            foreach (var Card in Hand)
            {
                if (Card.Color == Color.Red)
                {
                    redcount = redcount + 1;
                }
                else if (Card.Color == Color.Blue)
                {
                    bluecount = bluecount + 1;
                }
                else if (Card.Color == Color.Green)
                {
                    greencount = greencount + 1;
                }
                else if (Card.Color == Color.Yellow)
                {
                    yellowcount = yellowcount + 1;
                }
                else
                {
                    wildcount = wildcount + 1;
                }
                
            }
            int[] colorArray = new int[5] { redcount, bluecount, greencount, yellowcount,wildcount};
            int x = colorArray.Max();
            if(x == colorArray[0])
            {
                return Color.Red;
            }
            else if(x == colorArray[1])
            {
                return Color.Blue;
            }
            else if(x == colorArray[2])
            {
                return Color.Green;
            }
            else if(x == colorArray[3])
            {
                return Color.Yellow;
            }
            else
            {
                return Color.Wild;
            }

            

        }
    }
}


using System;
namespace Uno
{
	public class Player
	{
		public Player()
		{
			
			

        }
		public string Name { get; set; }

		public object Hand { get; set; }

		public Card GetFirstPlayableCard(Card card)
		{
			throw new NotImplementedException();
		}

		public bool HasPlayableCard(Card card)
		{
			throw new NotImplementedException();
		}
	}
}


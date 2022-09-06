using System;
namespace Vector
{
	public struct Vector
	{
		public double X {get;set;}
		public double Y {get;set;}

		public double Magnitude
		{
			get
			{
				return Math.Sqrt(X*X + Y*Y);
			}
		}
	}
}


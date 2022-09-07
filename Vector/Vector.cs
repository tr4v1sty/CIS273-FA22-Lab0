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
		public double Direction
		{
			get
			{
				return Math.Atan2(Y, X) * 180/Math.PI;
			}
		}
		public double Add
		{
			get { return Math.Sqrt(X*X + Y*Y); }
		}
		public double Subtract
		{
			get => Math.Sqrt(X*X + Y*Y);
		}
		public double Dot
		{
			get { return Math.Sqrt(X*X + Y*Y); }
		}
		public double AngleBetween { get; set; }

		
	}
	
}
// use the vector dot  and angle between etc stuff from the google doc and just add public
//instance methods


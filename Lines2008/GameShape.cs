/*******************************************/
/* Subject: component-oriented programming */
/* Author: Group 5                         */
/* Class: KTPM1-K5                         */
/*          Haui - [Dec, 2013]             */
/*                                         */
/*******************************************/

using System;
using System.Collections.Generic;
using System.Text;
using Rules;

namespace Lines98
{
	[Serializable()]
	public class GameShape
	{
		public int[,] matrix;
		public int scores;
		public int hours, minutes, seconds;

		public GameShape(int[,] matrix, int scores, int hours, int minutes, int seconds)
		{
			this.matrix = matrix;
			this.scores = scores;
			this.hours = hours;
			this.minutes = minutes;
			this.seconds = seconds;
		}

		public static GameShape getDefault()
		{
			return new GameShape(Algorithms.createNewMatrix(), 0, 0, 0, 0);
		}
	}
}

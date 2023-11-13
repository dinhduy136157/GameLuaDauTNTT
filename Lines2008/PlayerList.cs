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

namespace Lines98
{
	[Serializable()]
	class PlayerList
	{
		public Player[] list;

		public PlayerList(Player[] list)
		{
			this.list = list;
		}
	}
}

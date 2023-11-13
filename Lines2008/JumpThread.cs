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
using System.Windows.Forms;
using Themes;

namespace Lines98
{
	class JumpThread
	{
		Piece piece;

		Timer timer;
		int frame, len;

		public JumpThread(Piece piece)
		{
			this.piece = piece;

			frame = 0;
			len = SkinConstants.BallSelected.Length;

			timer = new Timer();
			timer.Interval = SkinConstants.DelayJump;
			timer.Tick += new EventHandler(timer_Tick);
			timer.Start();
		}

		public void timer_Tick(object Sender, EventArgs e)
		{
			piece.setJumpAt(frame++);
			if (frame == len) frame = 0;
		}

		public void Stop()
		{
			timer.Stop();
			if (piece.color > 0) piece.setNormal();
		}
	}
}

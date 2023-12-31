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
using System.Drawing;
using Themes;

namespace Lines98
{
	class Piece : PictureBox
	{
		public int col, row;
		public int color;

		public Piece(int i, int j)
		{
			this.col = i;
			this.row = j;
			this.Location = SkinConstants.getLocationOfPiece(i, j);
			this.Size = new Size(
				SkinConstants.BallSize.Width, SkinConstants.BallSize.Height);
		}

		public void setNormal()
		{
			this.Image = ClippingImage.bitmapPiece[0, color - 1];
		}

		public void setHint()
		{
			this.Image = ClippingImage.bitmapPiece[SkinConstants.BallHint, -color - 1];
		}

		public void setJumpAt(int frame)
		{
			this.Image = ClippingImage.bitmapPiece[SkinConstants.BallSelected[frame] - 1, color - 1];
		}

		public void setAppearenceAt(int frame)
		{
			this.Image = ClippingImage.bitmapPiece[SkinConstants.BallAppearence[frame] - 1, -color - 1];
		}

		public void setDestructionAt(int frame)
		{
			this.Image = ClippingImage.bitmapPiece[SkinConstants.BallDestruction[frame] - 1, color - 1];
		}
	}
}

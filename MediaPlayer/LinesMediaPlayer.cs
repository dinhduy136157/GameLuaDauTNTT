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
using System.Media;

namespace MediaPlayer
{
	public class LinesMediaPlayer
	{
        public static SoundPlayer moveSound = new SoundPlayer("Resources/move.wav");
        public static SoundPlayer destroySound = new SoundPlayer("Resources/destroy.wav");
        public static SoundPlayer cantmoveSound = new SoundPlayer("Resources/cantmove.wav");
	}
}

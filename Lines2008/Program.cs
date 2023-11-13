/*******************************************/
/* Subject: component-oriented programming */
/* Author: Group 5                         */
/* Class: KTPM1-K5                         */
/*          Haui - [Dec, 2013]             */
/*                                         */
/*******************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lines98
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
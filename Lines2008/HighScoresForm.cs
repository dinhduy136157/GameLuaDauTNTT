/*******************************************/
/* Subject: component-oriented programming */
/* Author: Group 5                         */
/* Class: KTPM1-K5                         */
/*          Haui - [Dec, 2013]             */
/*                                         */
/*******************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lines98
{
	public partial class HighScoresForm : Form
	{
		public HighScoresForm()
		{
			InitializeComponent();

			PlayerList pl = HighScoresFunctions.readHighScores();
			ListViewItem[] listViewItems = new ListViewItem[10];
			for (int i = 0; i < 10; i++)
			{
				listViewItems[i] = new ListViewItem(pl.list[i].convert(i + 1), -1);
			}
			this.listView1.Items.AddRange(listViewItems);
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
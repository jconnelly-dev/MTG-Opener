using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenerApplication
{
	public partial class MTG_Opener : Form
	{
		Random _random = new Random(20190814);

		public MTG_Opener()
		{
			InitializeComponent();
		}

		private void Decklist_Click(object sender, EventArgs e)
		{

		}

		private void NewHand_Click(object sender, EventArgs e)
		{
			List<System.Windows.Forms.PictureBox> hand = new List<PictureBox>()
			{
				pictureBox1,
				pictureBox2,
				pictureBox3,
				pictureBox4,
				pictureBox5,
				pictureBox6,
				pictureBox7
			};

			List<string> keys = new List<string>();
			foreach (string key in openingHand.Images.Keys)
			{
				keys.Add(key);
			}

			int minIdx = 0;
			int maxIdx = keys.Count - 1;
			Dictionary<int, bool> selected = new Dictionary<int,bool>();
			foreach (System.Windows.Forms.PictureBox picture in hand)
			{
				picture.Size = new Size(100, 150); // width, height.
				picture.SizeMode = PictureBoxSizeMode.CenterImage;
				picture.BorderStyle = BorderStyle.Fixed3D;

				int randomSelection;
				bool findingCard = true;
				do
				{
					randomSelection = _random.Next(minIdx, maxIdx);
					if (!selected.ContainsKey(randomSelection))
					{
						selected.Add(randomSelection, true);
						findingCard = false;
					}
				}
				while (findingCard);

				string imageKey = keys.ElementAt(randomSelection);
				picture.Image = openingHand.Images[imageKey];
			}
		}

		private void Draw_Click(object sender, EventArgs e)
		{

		}

		private void Mully_Click(object sender, EventArgs e)
		{

		}

		private void Opener_Load(object sender, EventArgs e)
		{

		}
	}
}

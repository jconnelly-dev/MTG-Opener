namespace OpenerApplication
{
	partial class MTG_Opener
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTG_Opener));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.openingHand = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.75824F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.24176F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel1.Controls.Add(this.button1, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.button2, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.button4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 42);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(697, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Mully";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Mully_Click);
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button2.Location = new System.Drawing.Point(603, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(73, 33);
			this.button2.TabIndex = 1;
			this.button2.Text = "Draw";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Draw_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(3, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(74, 33);
			this.button4.TabIndex = 3;
			this.button4.Text = "Decklist";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Decklist_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(500, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 33);
			this.button3.TabIndex = 2;
			this.button3.Text = "New Hand";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.NewHand_Click);
			// 
			// openingHand
			// 
			this.openingHand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("openingHand.ImageStream")));
			this.openingHand.TransparentColor = System.Drawing.Color.Transparent;
			this.openingHand.Images.SetKeyName(0, "Allosaurus Rider.png");
			this.openingHand.Images.SetKeyName(1, "Autochthon Wurm.png");
			this.openingHand.Images.SetKeyName(2, "Botanical Sanctum.png");
			this.openingHand.Images.SetKeyName(3, "Breeding Pool.png");
			this.openingHand.Images.SetKeyName(4, "Chancellor of the Tangle.png");
			this.openingHand.Images.SetKeyName(5, "Edge of Autumn.png");
			this.openingHand.Images.SetKeyName(6, "Eldritch Evolution.png");
			this.openingHand.Images.SetKeyName(7, "Gemstone Mine.png");
			this.openingHand.Images.SetKeyName(8, "Griselbrand.png");
			this.openingHand.Images.SetKeyName(9, "Island.png");
			this.openingHand.Images.SetKeyName(10, "Laboratory Maniac.png");
			this.openingHand.Images.SetKeyName(11, "Life Goes On.png");
			this.openingHand.Images.SetKeyName(12, "Manamorphose.png");
			this.openingHand.Images.SetKeyName(13, "Neoform.png");
			this.openingHand.Images.SetKeyName(14, "Nourishing Shoal.png");
			this.openingHand.Images.SetKeyName(15, "Noxious Revival.png");
			this.openingHand.Images.SetKeyName(16, "Wild Cantor.png");
			this.openingHand.Images.SetKeyName(17, "Waterlogged Grove.png");
			this.openingHand.Images.SetKeyName(18, "Summoner\'s Pact.png");
			this.openingHand.Images.SetKeyName(19, "Simian Spirit Guide.png");
			this.openingHand.Images.SetKeyName(20, "Serum Visions.png");
			this.openingHand.Images.SetKeyName(21, "Safewright Quest.png");
			this.openingHand.Images.SetKeyName(22, "Pact of Negation.png");
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(20, 89);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 150);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(133, 89);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 150);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(246, 89);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 150);
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(359, 89);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 150);
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(472, 89);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 150);
			this.pictureBox5.TabIndex = 7;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Location = new System.Drawing.Point(585, 89);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(100, 150);
			this.pictureBox6.TabIndex = 8;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Location = new System.Drawing.Point(698, 89);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(100, 150);
			this.pictureBox7.TabIndex = 9;
			this.pictureBox7.TabStop = false;
			// 
			// MTG_Opener
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 261);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MTG_Opener";
			this.Text = "MTG Opener";
			this.Load += new System.EventHandler(this.Opener_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ImageList openingHand;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;

	}
}


namespace ADayAtTheRaces
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.laneUpDown = new System.Windows.Forms.NumericUpDown();
            this.bets = new System.Windows.Forms.Label();
            this.varNameLabel = new System.Windows.Forms.Label();
            this.joesInfo = new System.Windows.Forms.Label();
            this.bobsInfo = new System.Windows.Forms.Label();
            this.betAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.alsInfo = new System.Windows.Forms.Label();
            this.poundsOnDogNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AlsOutcomeLabel = new System.Windows.Forms.Label();
            this.bobsOutcomeLabel = new System.Windows.Forms.Label();
            this.joesOutcomeLabel = new System.Windows.Forms.Label();
            this.joesRB = new System.Windows.Forms.RadioButton();
            this.bobsRB = new System.Windows.Forms.RadioButton();
            this.alsRB = new System.Windows.Forms.RadioButton();
            this.laneNumber1 = new System.Windows.Forms.Label();
            this.laneNumber2 = new System.Windows.Forms.Label();
            this.laneNumber3 = new System.Windows.Forms.Label();
            this.laneNumber4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laneUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(0, -1);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(601, 217);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 20);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 23);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 20);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(469, 271);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(101, 81);
            this.raceButton.TabIndex = 5;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinimumBetLabel);
            this.groupBox1.Controls.Add(this.laneUpDown);
            this.groupBox1.Controls.Add(this.bets);
            this.groupBox1.Controls.Add(this.varNameLabel);
            this.groupBox1.Controls.Add(this.joesInfo);
            this.groupBox1.Controls.Add(this.bobsInfo);
            this.groupBox1.Controls.Add(this.betAmountUpDown);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.alsInfo);
            this.groupBox1.Controls.Add(this.poundsOnDogNumber);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBetLabel.Location = new System.Drawing.Point(8, 15);
            this.MinimumBetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(105, 13);
            this.MinimumBetLabel.TabIndex = 3;
            this.MinimumBetLabel.Text = "MinimumBetLabel";
            // 
            // laneUpDown
            // 
            this.laneUpDown.Location = new System.Drawing.Point(340, 123);
            this.laneUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.laneUpDown.Name = "laneUpDown";
            this.laneUpDown.Size = new System.Drawing.Size(47, 20);
            this.laneUpDown.TabIndex = 18;
            this.laneUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bets
            // 
            this.bets.AutoSize = true;
            this.bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.bets.Location = new System.Drawing.Point(245, 16);
            this.bets.Name = "bets";
            this.bets.Size = new System.Drawing.Size(40, 17);
            this.bets.TabIndex = 15;
            this.bets.Text = "Bets";
            // 
            // varNameLabel
            // 
            this.varNameLabel.AutoSize = true;
            this.varNameLabel.Location = new System.Drawing.Point(6, 124);
            this.varNameLabel.Name = "varNameLabel";
            this.varNameLabel.Size = new System.Drawing.Size(0, 13);
            this.varNameLabel.TabIndex = 14;
            // 
            // joesInfo
            // 
            this.joesInfo.AutoSize = true;
            this.joesInfo.Location = new System.Drawing.Point(245, 34);
            this.joesInfo.Name = "joesInfo";
            this.joesInfo.Size = new System.Drawing.Size(0, 13);
            this.joesInfo.TabIndex = 10;
            // 
            // bobsInfo
            // 
            this.bobsInfo.AutoSize = true;
            this.bobsInfo.Location = new System.Drawing.Point(245, 56);
            this.bobsInfo.Name = "bobsInfo";
            this.bobsInfo.Size = new System.Drawing.Size(35, 13);
            this.bobsInfo.TabIndex = 11;
            this.bobsInfo.Text = "label2";
            // 
            // betAmountUpDown
            // 
            this.betAmountUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmountUpDown.Location = new System.Drawing.Point(158, 122);
            this.betAmountUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmountUpDown.Name = "betAmountUpDown";
            this.betAmountUpDown.Size = new System.Drawing.Size(47, 20);
            this.betAmountUpDown.TabIndex = 8;
            this.betAmountUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(64, 119);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 23);
            this.betsButton.TabIndex = 9;
            this.betsButton.Text = "bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // alsInfo
            // 
            this.alsInfo.AutoSize = true;
            this.alsInfo.Location = new System.Drawing.Point(245, 78);
            this.alsInfo.Name = "alsInfo";
            this.alsInfo.Size = new System.Drawing.Size(35, 13);
            this.alsInfo.TabIndex = 12;
            this.alsInfo.Text = "label3";
            // 
            // poundsOnDogNumber
            // 
            this.poundsOnDogNumber.AutoSize = true;
            this.poundsOnDogNumber.Location = new System.Drawing.Point(223, 124);
            this.poundsOnDogNumber.Name = "poundsOnDogNumber";
            this.poundsOnDogNumber.Size = new System.Drawing.Size(116, 13);
            this.poundsOnDogNumber.TabIndex = 13;
            this.poundsOnDogNumber.Text = "pounds on dog number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AlsOutcomeLabel);
            this.groupBox2.Controls.Add(this.bobsOutcomeLabel);
            this.groupBox2.Controls.Add(this.joesOutcomeLabel);
            this.groupBox2.Controls.Add(this.joesRB);
            this.groupBox2.Controls.Add(this.bobsRB);
            this.groupBox2.Controls.Add(this.alsRB);
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // AlsOutcomeLabel
            // 
            this.AlsOutcomeLabel.AutoSize = true;
            this.AlsOutcomeLabel.Location = new System.Drawing.Point(122, 62);
            this.AlsOutcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlsOutcomeLabel.Name = "AlsOutcomeLabel";
            this.AlsOutcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.AlsOutcomeLabel.TabIndex = 5;
            // 
            // bobsOutcomeLabel
            // 
            this.bobsOutcomeLabel.AutoSize = true;
            this.bobsOutcomeLabel.Location = new System.Drawing.Point(122, 37);
            this.bobsOutcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bobsOutcomeLabel.Name = "bobsOutcomeLabel";
            this.bobsOutcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.bobsOutcomeLabel.TabIndex = 4;
            this.bobsOutcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // joesOutcomeLabel
            // 
            this.joesOutcomeLabel.AutoSize = true;
            this.joesOutcomeLabel.Location = new System.Drawing.Point(122, 16);
            this.joesOutcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.joesOutcomeLabel.Name = "joesOutcomeLabel";
            this.joesOutcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.joesOutcomeLabel.TabIndex = 3;
            // 
            // joesRB
            // 
            this.joesRB.AutoSize = true;
            this.joesRB.Location = new System.Drawing.Point(8, 16);
            this.joesRB.Name = "joesRB";
            this.joesRB.Size = new System.Drawing.Size(14, 13);
            this.joesRB.TabIndex = 0;
            this.joesRB.TabStop = true;
            this.joesRB.UseVisualStyleBackColor = true;
            this.joesRB.CheckedChanged += new System.EventHandler(this.joesRB_CheckedChanged);
            // 
            // bobsRB
            // 
            this.bobsRB.AutoSize = true;
            this.bobsRB.Location = new System.Drawing.Point(8, 37);
            this.bobsRB.Name = "bobsRB";
            this.bobsRB.Size = new System.Drawing.Size(14, 13);
            this.bobsRB.TabIndex = 1;
            this.bobsRB.TabStop = true;
            this.bobsRB.UseVisualStyleBackColor = true;
            this.bobsRB.CheckedChanged += new System.EventHandler(this.bobsRB_CheckedChanged);
            // 
            // alsRB
            // 
            this.alsRB.AutoSize = true;
            this.alsRB.Location = new System.Drawing.Point(8, 60);
            this.alsRB.Name = "alsRB";
            this.alsRB.Size = new System.Drawing.Size(14, 13);
            this.alsRB.TabIndex = 2;
            this.alsRB.TabStop = true;
            this.alsRB.UseVisualStyleBackColor = true;
            this.alsRB.CheckedChanged += new System.EventHandler(this.alsRB_CheckedChanged);
            // 
            // laneNumber1
            // 
            this.laneNumber1.AutoSize = true;
            this.laneNumber1.Location = new System.Drawing.Point(6, 15);
            this.laneNumber1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laneNumber1.Name = "laneNumber1";
            this.laneNumber1.Size = new System.Drawing.Size(13, 13);
            this.laneNumber1.TabIndex = 7;
            this.laneNumber1.Text = "1";
            // 
            // laneNumber2
            // 
            this.laneNumber2.AutoSize = true;
            this.laneNumber2.Location = new System.Drawing.Point(6, 63);
            this.laneNumber2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laneNumber2.Name = "laneNumber2";
            this.laneNumber2.Size = new System.Drawing.Size(13, 13);
            this.laneNumber2.TabIndex = 8;
            this.laneNumber2.Text = "2";
            // 
            // laneNumber3
            // 
            this.laneNumber3.AutoSize = true;
            this.laneNumber3.Location = new System.Drawing.Point(6, 120);
            this.laneNumber3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laneNumber3.Name = "laneNumber3";
            this.laneNumber3.Size = new System.Drawing.Size(13, 13);
            this.laneNumber3.TabIndex = 9;
            this.laneNumber3.Text = "3";
            // 
            // laneNumber4
            // 
            this.laneNumber4.AutoSize = true;
            this.laneNumber4.Location = new System.Drawing.Point(6, 185);
            this.laneNumber4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laneNumber4.Name = "laneNumber4";
            this.laneNumber4.Size = new System.Drawing.Size(13, 13);
            this.laneNumber4.TabIndex = 10;
            this.laneNumber4.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 388);
            this.Controls.Add(this.laneNumber4);
            this.Controls.Add(this.laneNumber3);
            this.Controls.Add(this.laneNumber2);
            this.Controls.Add(this.laneNumber1);
            this.Controls.Add(this.raceButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.raceTrack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laneUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bobsInfo;
        private System.Windows.Forms.NumericUpDown betAmountUpDown;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label alsInfo;
        private System.Windows.Forms.Label poundsOnDogNumber;
        private System.Windows.Forms.RadioButton alsRB;
        private System.Windows.Forms.RadioButton bobsRB;
        private System.Windows.Forms.RadioButton joesRB;
        private System.Windows.Forms.Label joesInfo;
        private System.Windows.Forms.Label bets;
        private System.Windows.Forms.Label varNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label laneNumber1;
        private System.Windows.Forms.Label laneNumber2;
        private System.Windows.Forms.Label laneNumber3;
        private System.Windows.Forms.Label laneNumber4;
        private System.Windows.Forms.NumericUpDown laneUpDown;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.Label bobsOutcomeLabel;
        private System.Windows.Forms.Label joesOutcomeLabel;
        private System.Windows.Forms.Label AlsOutcomeLabel;
    }
}


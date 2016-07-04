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
            this.label6 = new System.Windows.Forms.Label();
            this.varNameLabel = new System.Windows.Forms.Label();
            this.joesInfo = new System.Windows.Forms.Label();
            this.bobsInfo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.betAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.alsInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alsRB = new System.Windows.Forms.RadioButton();
            this.bobsRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.joesRB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmountUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(0, -1);
            this.raceTrack.Margin = new System.Windows.Forms.Padding(4);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(801, 267);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            this.raceTrack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 137);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 28);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 220);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 25);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(625, 334);
            this.raceButton.Margin = new System.Windows.Forms.Padding(4);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(135, 100);
            this.raceButton.TabIndex = 5;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.varNameLabel);
            this.groupBox1.Controls.Add(this.joesInfo);
            this.groupBox1.Controls.Add(this.bobsInfo);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.betAmountUpDown);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.alsInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(785, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(327, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bets";
            // 
            // varNameLabel
            // 
            this.varNameLabel.AutoSize = true;
            this.varNameLabel.Location = new System.Drawing.Point(8, 153);
            this.varNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.varNameLabel.Name = "varNameLabel";
            this.varNameLabel.Size = new System.Drawing.Size(43, 17);
            this.varNameLabel.TabIndex = 14;
            this.varNameLabel.Text = "name";
            // 
            // joesInfo
            // 
            this.joesInfo.AutoSize = true;
            this.joesInfo.Location = new System.Drawing.Point(327, 42);
            this.joesInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.joesInfo.Name = "joesInfo";
            this.joesInfo.Size = new System.Drawing.Size(152, 17);
            this.joesInfo.TabIndex = 10;
            this.joesInfo.Text = "Joe hasn\'t made a bet.";
            this.joesInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // bobsInfo
            // 
            this.bobsInfo.AutoSize = true;
            this.bobsInfo.Location = new System.Drawing.Point(327, 69);
            this.bobsInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bobsInfo.Name = "bobsInfo";
            this.bobsInfo.Size = new System.Drawing.Size(46, 17);
            this.bobsInfo.TabIndex = 11;
            this.bobsInfo.Text = "label2";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(454, 150);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // betAmountUpDown
            // 
            this.betAmountUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmountUpDown.Location = new System.Drawing.Point(211, 150);
            this.betAmountUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.betAmountUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmountUpDown.Name = "betAmountUpDown";
            this.betAmountUpDown.Size = new System.Drawing.Size(63, 22);
            this.betAmountUpDown.TabIndex = 8;
            this.betAmountUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmountUpDown.ValueChanged += new System.EventHandler(this.betAmountUpDown_ValueChanged);
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(85, 146);
            this.betsButton.Margin = new System.Windows.Forms.Padding(4);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(100, 28);
            this.betsButton.TabIndex = 9;
            this.betsButton.Text = "bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // alsInfo
            // 
            this.alsInfo.AutoSize = true;
            this.alsInfo.Location = new System.Drawing.Point(327, 96);
            this.alsInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alsInfo.Name = "alsInfo";
            this.alsInfo.Size = new System.Drawing.Size(46, 17);
            this.alsInfo.TabIndex = 12;
            this.alsInfo.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "pounds on dog in lane";
            // 
            // alsRB
            // 
            this.alsRB.AutoSize = true;
            this.alsRB.Location = new System.Drawing.Point(10, 74);
            this.alsRB.Margin = new System.Windows.Forms.Padding(4);
            this.alsRB.Name = "alsRB";
            this.alsRB.Size = new System.Drawing.Size(92, 21);
            this.alsRB.TabIndex = 2;
            this.alsRB.TabStop = true;
            this.alsRB.Text = "Als button";
            this.alsRB.UseVisualStyleBackColor = true;
            this.alsRB.CheckedChanged += new System.EventHandler(this.alsRB_CheckedChanged);
            // 
            // bobsRB
            // 
            this.bobsRB.AutoSize = true;
            this.bobsRB.Location = new System.Drawing.Point(10, 45);
            this.bobsRB.Margin = new System.Windows.Forms.Padding(4);
            this.bobsRB.Name = "bobsRB";
            this.bobsRB.Size = new System.Drawing.Size(105, 21);
            this.bobsRB.TabIndex = 1;
            this.bobsRB.TabStop = true;
            this.bobsRB.Text = "Bobs button";
            this.bobsRB.UseVisualStyleBackColor = true;
            this.bobsRB.CheckedChanged += new System.EventHandler(this.bobsRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.joesRB);
            this.groupBox2.Controls.Add(this.bobsRB);
            this.groupBox2.Controls.Add(this.alsRB);
            this.groupBox2.Location = new System.Drawing.Point(4, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // joesRB
            // 
            this.joesRB.AutoSize = true;
            this.joesRB.Location = new System.Drawing.Point(10, 20);
            this.joesRB.Margin = new System.Windows.Forms.Padding(4);
            this.joesRB.Name = "joesRB";
            this.joesRB.Size = new System.Drawing.Size(74, 21);
            this.joesRB.TabIndex = 0;
            this.joesRB.TabStop = true;
            this.joesRB.Text = "joesRB";
            this.joesRB.UseVisualStyleBackColor = true;
            this.joesRB.CheckedChanged += new System.EventHandler(this.joesRB_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 478);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.raceButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.raceTrack);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown betAmountUpDown;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label alsInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton alsRB;
        private System.Windows.Forms.RadioButton bobsRB;
        private System.Windows.Forms.RadioButton joesRB;
        private System.Windows.Forms.Label joesInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label varNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


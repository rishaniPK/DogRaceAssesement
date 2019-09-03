namespace DogRace
{
    partial class RaceBet
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
            this.PbRace = new System.Windows.Forms.PictureBox();
            this.pb_dog1 = new System.Windows.Forms.PictureBox();
            this.pb_dog2 = new System.Windows.Forms.PictureBox();
            this.pb_dog3 = new System.Windows.Forms.PictureBox();
            this.pb_dog4 = new System.Windows.Forms.PictureBox();
            this.gbBettingDetails = new System.Windows.Forms.GroupBox();
            this.lbl_miniMoney = new System.Windows.Forms.Label();
            this.btn_startRace = new System.Windows.Forms.Button();
            this.nud_NoOfDog = new System.Windows.Forms.NumericUpDown();
            this.lbl_betOnDog = new System.Windows.Forms.Label();
            this.nud_money = new System.Windows.Forms.NumericUpDown();
            this.btn_bet = new System.Windows.Forms.Button();
            this.lbl_PersonName = new System.Windows.Forms.Label();
            this.lbl_person3 = new System.Windows.Forms.Label();
            this.lbl_person2 = new System.Windows.Forms.Label();
            this.lbl_person1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_person2 = new System.Windows.Forms.RadioButton();
            this.rb_person3 = new System.Windows.Forms.RadioButton();
            this.rb_person1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PbRace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog4)).BeginInit();
            this.gbBettingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NoOfDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_money)).BeginInit();
            this.SuspendLayout();
            // 
            // PbRace
            // 
            this.PbRace.BackgroundImage = global::DogRace.Resource1.bg;
            this.PbRace.Location = new System.Drawing.Point(10, 2);
            this.PbRace.Name = "PbRace";
            this.PbRace.Size = new System.Drawing.Size(534, 262);
            this.PbRace.TabIndex = 0;
            this.PbRace.TabStop = false;
            // 
            // pb_dog1
            // 
            this.pb_dog1.BackgroundImage = global::DogRace.Resource1.Capture;
            this.pb_dog1.ErrorImage = null;
            this.pb_dog1.Location = new System.Drawing.Point(29, 2);
            this.pb_dog1.Name = "pb_dog1";
            this.pb_dog1.Size = new System.Drawing.Size(59, 52);
            this.pb_dog1.TabIndex = 1;
            this.pb_dog1.TabStop = false;
            this.pb_dog1.Click += new System.EventHandler(this.Pb_dog1_Click);
            // 
            // pb_dog2
            // 
            this.pb_dog2.BackgroundImage = global::DogRace.Resource1.Capture;
            this.pb_dog2.Location = new System.Drawing.Point(28, 76);
            this.pb_dog2.Name = "pb_dog2";
            this.pb_dog2.Size = new System.Drawing.Size(59, 49);
            this.pb_dog2.TabIndex = 2;
            this.pb_dog2.TabStop = false;
            // 
            // pb_dog3
            // 
            this.pb_dog3.BackgroundImage = global::DogRace.Resource1.Capture;
            this.pb_dog3.Location = new System.Drawing.Point(28, 142);
            this.pb_dog3.Name = "pb_dog3";
            this.pb_dog3.Size = new System.Drawing.Size(59, 49);
            this.pb_dog3.TabIndex = 3;
            this.pb_dog3.TabStop = false;
            // 
            // pb_dog4
            // 
            this.pb_dog4.BackgroundImage = global::DogRace.Resource1.Capture;
            this.pb_dog4.Location = new System.Drawing.Point(28, 207);
            this.pb_dog4.Name = "pb_dog4";
            this.pb_dog4.Size = new System.Drawing.Size(59, 46);
            this.pb_dog4.TabIndex = 4;
            this.pb_dog4.TabStop = false;
            // 
            // gbBettingDetails
            // 
            this.gbBettingDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbBettingDetails.Controls.Add(this.lbl_miniMoney);
            this.gbBettingDetails.Controls.Add(this.btn_startRace);
            this.gbBettingDetails.Controls.Add(this.nud_NoOfDog);
            this.gbBettingDetails.Controls.Add(this.lbl_betOnDog);
            this.gbBettingDetails.Controls.Add(this.nud_money);
            this.gbBettingDetails.Controls.Add(this.btn_bet);
            this.gbBettingDetails.Controls.Add(this.lbl_PersonName);
            this.gbBettingDetails.Controls.Add(this.lbl_person3);
            this.gbBettingDetails.Controls.Add(this.lbl_person2);
            this.gbBettingDetails.Controls.Add(this.lbl_person1);
            this.gbBettingDetails.Controls.Add(this.label1);
            this.gbBettingDetails.Controls.Add(this.rb_person2);
            this.gbBettingDetails.Controls.Add(this.rb_person3);
            this.gbBettingDetails.Controls.Add(this.rb_person1);
            this.gbBettingDetails.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBettingDetails.ForeColor = System.Drawing.Color.AliceBlue;
            this.gbBettingDetails.Location = new System.Drawing.Point(10, 270);
            this.gbBettingDetails.Name = "gbBettingDetails";
            this.gbBettingDetails.Size = new System.Drawing.Size(534, 247);
            this.gbBettingDetails.TabIndex = 5;
            this.gbBettingDetails.TabStop = false;
            this.gbBettingDetails.Text = "Betting Details";
            this.gbBettingDetails.Enter += new System.EventHandler(this.GbBettingDetails_Enter);
            // 
            // lbl_miniMoney
            // 
            this.lbl_miniMoney.AutoSize = true;
            this.lbl_miniMoney.Location = new System.Drawing.Point(16, 21);
            this.lbl_miniMoney.Name = "lbl_miniMoney";
            this.lbl_miniMoney.Size = new System.Drawing.Size(160, 17);
            this.lbl_miniMoney.TabIndex = 13;
            this.lbl_miniMoney.Text = "the minim amout to bet";
            this.lbl_miniMoney.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btn_startRace
            // 
            this.btn_startRace.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startRace.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_startRace.Location = new System.Drawing.Point(222, 198);
            this.btn_startRace.Name = "btn_startRace";
            this.btn_startRace.Size = new System.Drawing.Size(104, 34);
            this.btn_startRace.TabIndex = 12;
            this.btn_startRace.Text = "Start Race..!";
            this.btn_startRace.UseVisualStyleBackColor = true;
            this.btn_startRace.Click += new System.EventHandler(this.Btn_startRace_Click);
            // 
            // nud_NoOfDog
            // 
            this.nud_NoOfDog.Location = new System.Drawing.Point(469, 154);
            this.nud_NoOfDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_NoOfDog.Name = "nud_NoOfDog";
            this.nud_NoOfDog.Size = new System.Drawing.Size(50, 24);
            this.nud_NoOfDog.TabIndex = 11;
            this.nud_NoOfDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_betOnDog
            // 
            this.lbl_betOnDog.AutoSize = true;
            this.lbl_betOnDog.Location = new System.Drawing.Point(299, 159);
            this.lbl_betOnDog.Name = "lbl_betOnDog";
            this.lbl_betOnDog.Size = new System.Drawing.Size(164, 17);
            this.lbl_betOnDog.TabIndex = 10;
            this.lbl_betOnDog.Text = "Amount On Dog Number";
            // 
            // nud_money
            // 
            this.nud_money.Location = new System.Drawing.Point(222, 152);
            this.nud_money.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_money.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_money.Name = "nud_money";
            this.nud_money.Size = new System.Drawing.Size(62, 24);
            this.nud_money.TabIndex = 9;
            this.nud_money.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_money.ValueChanged += new System.EventHandler(this.Nud_money_ValueChanged);
            // 
            // btn_bet
            // 
            this.btn_bet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bet.AutoEllipsis = true;
            this.btn_bet.BackColor = System.Drawing.Color.Silver;
            this.btn_bet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bet.ForeColor = System.Drawing.Color.Navy;
            this.btn_bet.Location = new System.Drawing.Point(134, 153);
            this.btn_bet.Name = "btn_bet";
            this.btn_bet.Size = new System.Drawing.Size(38, 25);
            this.btn_bet.TabIndex = 8;
            this.btn_bet.Text = "Bet";
            this.btn_bet.UseVisualStyleBackColor = false;
            this.btn_bet.Click += new System.EventHandler(this.Btn_bet_Click);
            // 
            // lbl_PersonName
            // 
            this.lbl_PersonName.AutoSize = true;
            this.lbl_PersonName.Location = new System.Drawing.Point(18, 153);
            this.lbl_PersonName.Name = "lbl_PersonName";
            this.lbl_PersonName.Size = new System.Drawing.Size(110, 17);
            this.lbl_PersonName.TabIndex = 7;
            this.lbl_PersonName.Text = "Pick the person";
            this.lbl_PersonName.Click += new System.EventHandler(this.Lbl_PersonName_Click);
            // 
            // lbl_person3
            // 
            this.lbl_person3.AutoSize = true;
            this.lbl_person3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_person3.Location = new System.Drawing.Point(299, 108);
            this.lbl_person3.Name = "lbl_person3";
            this.lbl_person3.Size = new System.Drawing.Size(187, 19);
            this.lbl_person3.TabIndex = 6;
            this.lbl_person3.Text = "Abira hasn\'t placed any bet";
            // 
            // lbl_person2
            // 
            this.lbl_person2.AutoSize = true;
            this.lbl_person2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_person2.Location = new System.Drawing.Point(299, 81);
            this.lbl_person2.Name = "lbl_person2";
            this.lbl_person2.Size = new System.Drawing.Size(193, 19);
            this.lbl_person2.TabIndex = 5;
            this.lbl_person2.Text = "Ravan hasn\'t placed any bet";
            // 
            // lbl_person1
            // 
            this.lbl_person1.AutoSize = true;
            this.lbl_person1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_person1.Location = new System.Drawing.Point(299, 54);
            this.lbl_person1.Name = "lbl_person1";
            this.lbl_person1.Size = new System.Drawing.Size(194, 19);
            this.lbl_person1.TabIndex = 4;
            this.lbl_person1.Text = "Shaan hasn\'t placed any bet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bets";
            // 
            // rb_person2
            // 
            this.rb_person2.AutoSize = true;
            this.rb_person2.Location = new System.Drawing.Point(18, 81);
            this.rb_person2.Name = "rb_person2";
            this.rb_person2.Size = new System.Drawing.Size(121, 21);
            this.rb_person2.TabIndex = 2;
            this.rb_person2.TabStop = true;
            this.rb_person2.Text = "Ravan has $50";
            this.rb_person2.UseVisualStyleBackColor = true;
            this.rb_person2.CheckedChanged += new System.EventHandler(this.Rb_person2_CheckedChanged);
            // 
            // rb_person3
            // 
            this.rb_person3.AutoSize = true;
            this.rb_person3.Location = new System.Drawing.Point(18, 108);
            this.rb_person3.Name = "rb_person3";
            this.rb_person3.Size = new System.Drawing.Size(115, 21);
            this.rb_person3.TabIndex = 1;
            this.rb_person3.TabStop = true;
            this.rb_person3.Text = "Abira has $50";
            this.rb_person3.UseVisualStyleBackColor = true;
            this.rb_person3.CheckedChanged += new System.EventHandler(this.Rb_person3_CheckedChanged);
            // 
            // rb_person1
            // 
            this.rb_person1.AutoSize = true;
            this.rb_person1.Location = new System.Drawing.Point(18, 54);
            this.rb_person1.Name = "rb_person1";
            this.rb_person1.Size = new System.Drawing.Size(122, 21);
            this.rb_person1.TabIndex = 0;
            this.rb_person1.TabStop = true;
            this.rb_person1.Text = "Shaan has $50";
            this.rb_person1.UseVisualStyleBackColor = true;
            this.rb_person1.CheckedChanged += new System.EventHandler(this.Rb_person1_CheckedChanged);
            // 
            // RaceBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DogRace.Resource1.brownfluidwallpaper;
            this.ClientSize = new System.Drawing.Size(650, 512);
            this.Controls.Add(this.gbBettingDetails);
            this.Controls.Add(this.pb_dog4);
            this.Controls.Add(this.pb_dog3);
            this.Controls.Add(this.pb_dog2);
            this.Controls.Add(this.pb_dog1);
            this.Controls.Add(this.PbRace);
            this.Name = "RaceBet";
            this.Text = "Dog On Race";
            this.Load += new System.EventHandler(this.RaceBet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbRace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog4)).EndInit();
            this.gbBettingDetails.ResumeLayout(false);
            this.gbBettingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NoOfDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_money)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbRace;
        private System.Windows.Forms.PictureBox pb_dog1;
        private System.Windows.Forms.PictureBox pb_dog2;
        private System.Windows.Forms.PictureBox pb_dog3;
        private System.Windows.Forms.PictureBox pb_dog4;
        private System.Windows.Forms.GroupBox gbBettingDetails;
        private System.Windows.Forms.Label lbl_betOnDog;
        private System.Windows.Forms.NumericUpDown nud_money;
        private System.Windows.Forms.Button btn_bet;
        private System.Windows.Forms.Label lbl_PersonName;
        private System.Windows.Forms.Label lbl_person3;
        private System.Windows.Forms.Label lbl_person2;
        private System.Windows.Forms.Label lbl_person1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_person2;
        private System.Windows.Forms.RadioButton rb_person3;
        private System.Windows.Forms.RadioButton rb_person1;
        private System.Windows.Forms.Button btn_startRace;
        private System.Windows.Forms.NumericUpDown nud_NoOfDog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_miniMoney;
    }
}


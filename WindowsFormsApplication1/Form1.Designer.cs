namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jobGroupBox = new System.Windows.Forms.GroupBox();
            this.jobListBox = new System.Windows.Forms.ListBox();
            this.weightsGroupBox = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.ssWTextBox = new System.Windows.Forms.TextBox();
            this.detWTextBox = new System.Windows.Forms.TextBox();
            this.critWTextBox = new System.Windows.Forms.TextBox();
            this.wdWTextBox = new System.Windows.Forms.TextBox();
            this.mWTextBox = new System.Windows.Forms.TextBox();
            this.vitWTextBox = new System.Windows.Forms.TextBox();
            this.speedWeightLabel = new System.Windows.Forms.Label();
            this.detWeightLabel = new System.Windows.Forms.Label();
            this.critWeightLabel = new System.Windows.Forms.Label();
            this.wdWeightLabel = new System.Windows.Forms.Label();
            this.mainWeightLabel = new System.Windows.Forms.Label();
            this.vitWeightLabel = new System.Windows.Forms.Label();
            this.gearStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.ssTextBox = new System.Windows.Forms.TextBox();
            this.detTextBox = new System.Windows.Forms.TextBox();
            this.critTextBox = new System.Windows.Forms.TextBox();
            this.wdTextBox = new System.Windows.Forms.TextBox();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.vitTextBox = new System.Windows.Forms.TextBox();
            this.ssLabel = new System.Windows.Forms.Label();
            this.detLabel = new System.Windows.Forms.Label();
            this.critLabel = new System.Windows.Forms.Label();
            this.wdLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.VitLabel = new System.Windows.Forms.Label();
            this.weightTotalLabel = new System.Windows.Forms.Label();
            this.calculateGroupBox = new System.Windows.Forms.GroupBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.historyGroupBox = new System.Windows.Forms.GroupBox();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.jobGroupBox.SuspendLayout();
            this.weightsGroupBox.SuspendLayout();
            this.gearStatsGroupBox.SuspendLayout();
            this.calculateGroupBox.SuspendLayout();
            this.historyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobGroupBox
            // 
            this.jobGroupBox.Controls.Add(this.jobListBox);
            this.jobGroupBox.Location = new System.Drawing.Point(25, 25);
            this.jobGroupBox.Name = "jobGroupBox";
            this.jobGroupBox.Size = new System.Drawing.Size(228, 273);
            this.jobGroupBox.TabIndex = 0;
            this.jobGroupBox.TabStop = false;
            this.jobGroupBox.Text = "Select a Job";
            // 
            // jobListBox
            // 
            this.jobListBox.FormattingEnabled = true;
            this.jobListBox.Items.AddRange(new object[] {
            "Paladin (Sword Oath)",
            "Paladin (Shield Oath)",
            "Warrior",
            "Dark Knight",
            "White Mage",
            "Scholar",
            "Astrologian",
            "Dragoon",
            "Monk",
            "Ninja",
            "Bard",
            "Machinist",
            "Black Mage",
            "Summoner"});
            this.jobListBox.Location = new System.Drawing.Point(22, 25);
            this.jobListBox.Name = "jobListBox";
            this.jobListBox.Size = new System.Drawing.Size(185, 225);
            this.jobListBox.TabIndex = 0;
            this.jobListBox.SelectedIndexChanged += new System.EventHandler(this.jobListBox_SelectedIndexChanged);
            // 
            // weightsGroupBox
            // 
            this.weightsGroupBox.Controls.Add(this.ssWTextBox);
            this.weightsGroupBox.Controls.Add(this.detWTextBox);
            this.weightsGroupBox.Controls.Add(this.critWTextBox);
            this.weightsGroupBox.Controls.Add(this.wdWTextBox);
            this.weightsGroupBox.Controls.Add(this.mWTextBox);
            this.weightsGroupBox.Controls.Add(this.vitWTextBox);
            this.weightsGroupBox.Controls.Add(this.speedWeightLabel);
            this.weightsGroupBox.Controls.Add(this.detWeightLabel);
            this.weightsGroupBox.Controls.Add(this.critWeightLabel);
            this.weightsGroupBox.Controls.Add(this.wdWeightLabel);
            this.weightsGroupBox.Controls.Add(this.mainWeightLabel);
            this.weightsGroupBox.Controls.Add(this.vitWeightLabel);
            this.weightsGroupBox.Controls.Add(this.editButton);
            this.weightsGroupBox.Location = new System.Drawing.Point(268, 25);
            this.weightsGroupBox.Name = "weightsGroupBox";
            this.weightsGroupBox.Size = new System.Drawing.Size(200, 273);
            this.weightsGroupBox.TabIndex = 1;
            this.weightsGroupBox.TabStop = false;
            this.weightsGroupBox.Text = "Stat Weights";
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(116, 222);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(65, 23);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ssWTextBox
            // 
            this.ssWTextBox.Location = new System.Drawing.Point(116, 164);
            this.ssWTextBox.Name = "ssWTextBox";
            this.ssWTextBox.ReadOnly = true;
            this.ssWTextBox.Size = new System.Drawing.Size(65, 20);
            this.ssWTextBox.TabIndex = 12;
            // 
            // detWTextBox
            // 
            this.detWTextBox.Location = new System.Drawing.Point(116, 138);
            this.detWTextBox.Name = "detWTextBox";
            this.detWTextBox.ReadOnly = true;
            this.detWTextBox.Size = new System.Drawing.Size(65, 20);
            this.detWTextBox.TabIndex = 11;
            // 
            // critWTextBox
            // 
            this.critWTextBox.Location = new System.Drawing.Point(116, 112);
            this.critWTextBox.Name = "critWTextBox";
            this.critWTextBox.ReadOnly = true;
            this.critWTextBox.Size = new System.Drawing.Size(65, 20);
            this.critWTextBox.TabIndex = 10;
            // 
            // wdWTextBox
            // 
            this.wdWTextBox.Location = new System.Drawing.Point(117, 86);
            this.wdWTextBox.Name = "wdWTextBox";
            this.wdWTextBox.ReadOnly = true;
            this.wdWTextBox.Size = new System.Drawing.Size(65, 20);
            this.wdWTextBox.TabIndex = 9;
            // 
            // mWTextBox
            // 
            this.mWTextBox.Location = new System.Drawing.Point(117, 60);
            this.mWTextBox.Name = "mWTextBox";
            this.mWTextBox.ReadOnly = true;
            this.mWTextBox.Size = new System.Drawing.Size(65, 20);
            this.mWTextBox.TabIndex = 8;
            // 
            // vitWTextBox
            // 
            this.vitWTextBox.Location = new System.Drawing.Point(117, 36);
            this.vitWTextBox.Name = "vitWTextBox";
            this.vitWTextBox.ReadOnly = true;
            this.vitWTextBox.Size = new System.Drawing.Size(65, 20);
            this.vitWTextBox.TabIndex = 7;
            // 
            // speedWeightLabel
            // 
            this.speedWeightLabel.Location = new System.Drawing.Point(20, 167);
            this.speedWeightLabel.Name = "speedWeightLabel";
            this.speedWeightLabel.Size = new System.Drawing.Size(91, 13);
            this.speedWeightLabel.TabIndex = 5;
            this.speedWeightLabel.Text = "Speed:";
            this.speedWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detWeightLabel
            // 
            this.detWeightLabel.AutoSize = true;
            this.detWeightLabel.Location = new System.Drawing.Point(36, 141);
            this.detWeightLabel.Name = "detWeightLabel";
            this.detWeightLabel.Size = new System.Drawing.Size(75, 13);
            this.detWeightLabel.TabIndex = 4;
            this.detWeightLabel.Text = "Determination:";
            // 
            // critWeightLabel
            // 
            this.critWeightLabel.AutoSize = true;
            this.critWeightLabel.Location = new System.Drawing.Point(44, 115);
            this.critWeightLabel.Name = "critWeightLabel";
            this.critWeightLabel.Size = new System.Drawing.Size(67, 13);
            this.critWeightLabel.TabIndex = 3;
            this.critWeightLabel.Text = "Critical Rate:";
            // 
            // wdWeightLabel
            // 
            this.wdWeightLabel.AutoSize = true;
            this.wdWeightLabel.Location = new System.Drawing.Point(17, 89);
            this.wdWeightLabel.Name = "wdWeightLabel";
            this.wdWeightLabel.Size = new System.Drawing.Size(94, 13);
            this.wdWeightLabel.TabIndex = 2;
            this.wdWeightLabel.Text = "Weapon Damage:";
            // 
            // mainWeightLabel
            // 
            this.mainWeightLabel.Location = new System.Drawing.Point(20, 63);
            this.mainWeightLabel.Name = "mainWeightLabel";
            this.mainWeightLabel.Size = new System.Drawing.Size(91, 13);
            this.mainWeightLabel.TabIndex = 1;
            this.mainWeightLabel.Text = "[Main Stat]:";
            this.mainWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vitWeightLabel
            // 
            this.vitWeightLabel.AutoSize = true;
            this.vitWeightLabel.Location = new System.Drawing.Point(71, 39);
            this.vitWeightLabel.Name = "vitWeightLabel";
            this.vitWeightLabel.Size = new System.Drawing.Size(40, 13);
            this.vitWeightLabel.TabIndex = 0;
            this.vitWeightLabel.Text = "Vitality:";
            // 
            // gearStatsGroupBox
            // 
            this.gearStatsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.gearStatsGroupBox.Controls.Add(this.ssTextBox);
            this.gearStatsGroupBox.Controls.Add(this.detTextBox);
            this.gearStatsGroupBox.Controls.Add(this.critTextBox);
            this.gearStatsGroupBox.Controls.Add(this.wdTextBox);
            this.gearStatsGroupBox.Controls.Add(this.mTextBox);
            this.gearStatsGroupBox.Controls.Add(this.vitTextBox);
            this.gearStatsGroupBox.Controls.Add(this.ssLabel);
            this.gearStatsGroupBox.Controls.Add(this.detLabel);
            this.gearStatsGroupBox.Controls.Add(this.critLabel);
            this.gearStatsGroupBox.Controls.Add(this.wdLabel);
            this.gearStatsGroupBox.Controls.Add(this.mainLabel);
            this.gearStatsGroupBox.Controls.Add(this.VitLabel);
            this.gearStatsGroupBox.Location = new System.Drawing.Point(483, 25);
            this.gearStatsGroupBox.Name = "gearStatsGroupBox";
            this.gearStatsGroupBox.Size = new System.Drawing.Size(200, 273);
            this.gearStatsGroupBox.TabIndex = 2;
            this.gearStatsGroupBox.TabStop = false;
            this.gearStatsGroupBox.Text = "Gear Stats";
            // 
            // ssTextBox
            // 
            this.ssTextBox.Location = new System.Drawing.Point(117, 163);
            this.ssTextBox.Name = "ssTextBox";
            this.ssTextBox.ReadOnly = true;
            this.ssTextBox.Size = new System.Drawing.Size(65, 20);
            this.ssTextBox.TabIndex = 24;
            // 
            // detTextBox
            // 
            this.detTextBox.Location = new System.Drawing.Point(117, 137);
            this.detTextBox.Name = "detTextBox";
            this.detTextBox.ReadOnly = true;
            this.detTextBox.Size = new System.Drawing.Size(65, 20);
            this.detTextBox.TabIndex = 23;
            // 
            // critTextBox
            // 
            this.critTextBox.Location = new System.Drawing.Point(117, 111);
            this.critTextBox.Name = "critTextBox";
            this.critTextBox.ReadOnly = true;
            this.critTextBox.Size = new System.Drawing.Size(65, 20);
            this.critTextBox.TabIndex = 22;
            // 
            // wdTextBox
            // 
            this.wdTextBox.Location = new System.Drawing.Point(118, 85);
            this.wdTextBox.Name = "wdTextBox";
            this.wdTextBox.ReadOnly = true;
            this.wdTextBox.Size = new System.Drawing.Size(65, 20);
            this.wdTextBox.TabIndex = 21;
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(118, 59);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.ReadOnly = true;
            this.mTextBox.Size = new System.Drawing.Size(65, 20);
            this.mTextBox.TabIndex = 20;
            // 
            // vitTextBox
            // 
            this.vitTextBox.Location = new System.Drawing.Point(118, 35);
            this.vitTextBox.Name = "vitTextBox";
            this.vitTextBox.ReadOnly = true;
            this.vitTextBox.Size = new System.Drawing.Size(65, 20);
            this.vitTextBox.TabIndex = 19;
            // 
            // ssLabel
            // 
            this.ssLabel.Location = new System.Drawing.Point(21, 166);
            this.ssLabel.Name = "ssLabel";
            this.ssLabel.Size = new System.Drawing.Size(91, 13);
            this.ssLabel.TabIndex = 18;
            this.ssLabel.Text = "Speed:";
            this.ssLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detLabel
            // 
            this.detLabel.AutoSize = true;
            this.detLabel.Location = new System.Drawing.Point(37, 140);
            this.detLabel.Name = "detLabel";
            this.detLabel.Size = new System.Drawing.Size(75, 13);
            this.detLabel.TabIndex = 17;
            this.detLabel.Text = "Determination:";
            // 
            // critLabel
            // 
            this.critLabel.AutoSize = true;
            this.critLabel.Location = new System.Drawing.Point(45, 114);
            this.critLabel.Name = "critLabel";
            this.critLabel.Size = new System.Drawing.Size(67, 13);
            this.critLabel.TabIndex = 16;
            this.critLabel.Text = "Critical Rate:";
            // 
            // wdLabel
            // 
            this.wdLabel.AutoSize = true;
            this.wdLabel.Location = new System.Drawing.Point(18, 88);
            this.wdLabel.Name = "wdLabel";
            this.wdLabel.Size = new System.Drawing.Size(94, 13);
            this.wdLabel.TabIndex = 15;
            this.wdLabel.Text = "Weapon Damage:";
            // 
            // mainLabel
            // 
            this.mainLabel.Location = new System.Drawing.Point(21, 62);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(91, 13);
            this.mainLabel.TabIndex = 14;
            this.mainLabel.Text = "[Main Stat]:";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VitLabel
            // 
            this.VitLabel.AutoSize = true;
            this.VitLabel.Location = new System.Drawing.Point(72, 38);
            this.VitLabel.Name = "VitLabel";
            this.VitLabel.Size = new System.Drawing.Size(40, 13);
            this.VitLabel.TabIndex = 13;
            this.VitLabel.Text = "Vitality:";
            // 
            // weightTotalLabel
            // 
            this.weightTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTotalLabel.Location = new System.Drawing.Point(19, 145);
            this.weightTotalLabel.Name = "weightTotalLabel";
            this.weightTotalLabel.Size = new System.Drawing.Size(160, 50);
            this.weightTotalLabel.TabIndex = 4;
            this.weightTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateGroupBox
            // 
            this.calculateGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.calculateGroupBox.Controls.Add(this.commentsTextBox);
            this.calculateGroupBox.Controls.Add(this.calculateButton);
            this.calculateGroupBox.Controls.Add(this.weightTotalLabel);
            this.calculateGroupBox.Location = new System.Drawing.Point(698, 25);
            this.calculateGroupBox.Name = "calculateGroupBox";
            this.calculateGroupBox.Size = new System.Drawing.Size(198, 273);
            this.calculateGroupBox.TabIndex = 6;
            this.calculateGroupBox.TabStop = false;
            this.calculateGroupBox.Text = "Calculate";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(19, 25);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.commentsTextBox.Size = new System.Drawing.Size(160, 102);
            this.commentsTextBox.TabIndex = 25;
            this.commentsTextBox.Text = "Leave history comments here...";
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(19, 222);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(160, 31);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Weight";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // historyGroupBox
            // 
            this.historyGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.historyGroupBox.Controls.Add(this.clearHistoryButton);
            this.historyGroupBox.Controls.Add(this.historyListBox);
            this.historyGroupBox.Location = new System.Drawing.Point(25, 304);
            this.historyGroupBox.Name = "historyGroupBox";
            this.historyGroupBox.Size = new System.Drawing.Size(871, 193);
            this.historyGroupBox.TabIndex = 7;
            this.historyGroupBox.TabStop = false;
            this.historyGroupBox.Text = "History";
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Location = new System.Drawing.Point(22, 160);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(153, 23);
            this.clearHistoryButton.TabIndex = 6;
            this.clearHistoryButton.Text = "Clear History";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(22, 33);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(830, 121);
            this.historyListBox.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Paladin_concept_art.jpg");
            this.imageList1.Images.SetKeyName(1, "Paladin_concept_art.jpg");
            this.imageList1.Images.SetKeyName(2, "Warrior_concept_art.jpg");
            this.imageList1.Images.SetKeyName(3, "White_mage_concept_art.jpg");
            this.imageList1.Images.SetKeyName(4, "300px-Scholar_concept_art.jpg");
            this.imageList1.Images.SetKeyName(5, "Dragoon_concept_art.jpg");
            this.imageList1.Images.SetKeyName(6, "Monk_concept_art.jpg");
            this.imageList1.Images.SetKeyName(7, "300px-Ninja_concept.png");
            this.imageList1.Images.SetKeyName(8, "Bard_concept_art.jpg");
            this.imageList1.Images.SetKeyName(9, "Black_mage_concept_art.jpg");
            this.imageList1.Images.SetKeyName(10, "Summoner_concept1.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 546);
            this.Controls.Add(this.historyGroupBox);
            this.Controls.Add(this.weightsGroupBox);
            this.Controls.Add(this.jobGroupBox);
            this.Controls.Add(this.gearStatsGroupBox);
            this.Controls.Add(this.calculateGroupBox);
            this.Name = "Form1";
            this.Text = "Stat Weights";
            this.jobGroupBox.ResumeLayout(false);
            this.weightsGroupBox.ResumeLayout(false);
            this.weightsGroupBox.PerformLayout();
            this.gearStatsGroupBox.ResumeLayout(false);
            this.gearStatsGroupBox.PerformLayout();
            this.calculateGroupBox.ResumeLayout(false);
            this.calculateGroupBox.PerformLayout();
            this.historyGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox jobGroupBox;
        private System.Windows.Forms.ListBox jobListBox;
        private System.Windows.Forms.GroupBox weightsGroupBox;
        private System.Windows.Forms.TextBox ssWTextBox;
        private System.Windows.Forms.TextBox detWTextBox;
        private System.Windows.Forms.TextBox critWTextBox;
        private System.Windows.Forms.TextBox wdWTextBox;
        private System.Windows.Forms.TextBox mWTextBox;
        private System.Windows.Forms.TextBox vitWTextBox;
        private System.Windows.Forms.Label speedWeightLabel;
        private System.Windows.Forms.Label detWeightLabel;
        private System.Windows.Forms.Label critWeightLabel;
        private System.Windows.Forms.Label wdWeightLabel;
        private System.Windows.Forms.Label mainWeightLabel;
        private System.Windows.Forms.Label vitWeightLabel;
        private System.Windows.Forms.GroupBox gearStatsGroupBox;
        private System.Windows.Forms.TextBox ssTextBox;
        private System.Windows.Forms.TextBox detTextBox;
        private System.Windows.Forms.TextBox critTextBox;
        private System.Windows.Forms.TextBox wdTextBox;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox vitTextBox;
        private System.Windows.Forms.Label ssLabel;
        private System.Windows.Forms.Label detLabel;
        private System.Windows.Forms.Label critLabel;
        private System.Windows.Forms.Label wdLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label VitLabel;
        private System.Windows.Forms.Label weightTotalLabel;
        private System.Windows.Forms.GroupBox calculateGroupBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox historyGroupBox;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}


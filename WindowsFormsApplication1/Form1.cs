//      Here, I created a program that allows the user to select a job,
//      then enter their gear stats accordingly. When they hit Calculate,
//      the program gives them the dps (damage per second) weight
//      based on the data they input. Additionally, there is a history
//      listbox to help the user compare different sets of stats and
//      weights in order to come up with the best build! This is
//      my first attempt at working with structures.
//
//      These jobs are based off of Final Fantasy XIV, and the stat
//      weights come from sources (such as Dervy) who have done the
//      testing. Unfortunately, I cannot find Astrologian stat weights..
//      For now, AST values will be 0.000.
//
//      Holly Franks
//      2-15-2017
// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{

    struct JobWeights
    {
        public string name;
        public double vitW;
        public double mW;
        public double wdW;
        public double critW;
        public double detW;
        public double ssW;
        public string statName;
        public string speedName;
        public int background;
    }

    public partial class Form1 : Form
    {
        JobWeights[] weights;
        double vitW, mW, wdW, critW, detW, ssW;
        double vit, m, wd, crit, det, ss;

        double weightTotal;

        public Form1()
        {
            InitializeComponent();
            PopulateJobWeights();
        }

        private void PopulateJobWeights()
        {
            const int NUM_JOBS = 14;
            weights = new JobWeights[NUM_JOBS];

            weights[0].name = "Paladin (Sword Oath)";
            weights[0].vitW = 1.000;
            weights[0].mW = 1.000;
            weights[0].wdW = 26.523;
            weights[0].critW = 0.541;
            weights[0].detW = 0.396;
            weights[0].ssW = 0.274;
            weights[0].statName = "Strength:";
            weights[0].speedName = "Skill Speed:";
            weights[0].background = 0;

            weights[1].name = "Paladin (Shield Oath)";
            weights[1].vitW = 1.000;
            weights[1].mW = 1.000;
            weights[1].wdW = 26.523;
            weights[1].critW = 0.541;
            weights[1].detW = 0.396;
            weights[1].ssW = 0.330;
            weights[1].statName = "Strength:";
            weights[1].speedName = "Skill Speed:";

            weights[2].name = "Warrior";
            weights[2].vitW = 1.000;
            weights[2].mW = 1.000;
            weights[2].wdW = 27.095;
            weights[2].critW = 0.546;
            weights[2].detW = 0.387;
            weights[2].ssW = 0.350;
            weights[2].statName = "Strength:";
            weights[2].speedName = "Skill Speed:";

            weights[3].name = "Dark Knight";
            weights[3].vitW = 1.000;
            weights[3].mW = 1.000;
            weights[3].wdW = 26.547;
            weights[3].critW = 0.530;
            weights[3].detW = 0.380;
            weights[3].ssW = 0.315;
            weights[3].statName = "Strength:";
            weights[3].speedName = "Skill Speed:";

            weights[4].name = "White Mage";
            weights[4].vitW = 0.000;
            weights[4].mW = 1.000;
            weights[4].wdW = 9.128;
            weights[4].critW = 0.182;
            weights[4].detW = 0.159;
            weights[4].ssW = 0.135;
            weights[4].statName = "Mind (Cleric):";
            weights[4].speedName = "Spell Speed:";

            weights[5].name = "Scholar";
            weights[5].vitW = 0.000;
            weights[5].mW = 1.000;
            weights[5].wdW = 9.128;
            weights[5].critW = 0.266;
            weights[5].detW = 0.190;
            weights[5].ssW = 0.316;
            weights[5].statName = "Mind (Cleric):";
            weights[5].speedName = "Spell Speed:";

            weights[6].name = "Astrologian";
            weights[6].vitW = 0.000;
            weights[6].mW = 0.000;
            weights[6].wdW = 0.000;
            weights[6].critW = 0.000;
            weights[6].detW = 0.000;
            weights[6].ssW = 0.000;
            weights[6].statName = "Mind (Cleric):";
            weights[6].speedName = "Spell Speed:";

            weights[7].name = "Dragoon";
            weights[7].vitW = 0.000;
            weights[7].mW = 1.000;
            weights[7].wdW = 14.956;
            weights[7].critW = 0.279;
            weights[7].detW = 0.207;
            weights[7].ssW = 0.170;
            weights[7].statName = "Strength:";
            weights[7].speedName = "Skill Speed:";

            weights[8].name = "Monk";
            weights[8].vitW = 0.000;
            weights[8].mW = 1.000;
            weights[8].wdW = 15.459;
            weights[8].critW = 0.297;
            weights[8].detW = 0.212;
            weights[8].ssW = 0.173;
            weights[8].statName = "Strength:";
            weights[8].speedName = "Skill Speed:";

            weights[9].name = "Ninja";
            weights[9].vitW = 0.000;
            weights[9].mW = 1.000;
            weights[9].wdW = 15.195;
            weights[9].critW = 0.282;
            weights[9].detW = 0.210;
            weights[9].ssW = 0.141;
            weights[9].statName = "Strength:";
            weights[9].speedName = "Skill Speed:";

            weights[10].name = "Bard";
            weights[10].vitW = 0.000;
            weights[10].mW = 1.000;
            weights[10].wdW = 16.824;
            weights[10].critW = 0.366;
            weights[10].detW = 0.215;
            weights[10].ssW = 0.233;
            weights[10].statName = "Strength:";
            weights[10].speedName = "Skill Speed:";

            weights[11].name = "Machinist";
            weights[11].vitW = 0.000;
            weights[11].mW = 0.000;
            weights[11].wdW = 11.000;
            weights[11].critW = 0.273;
            weights[11].detW = 0.226;
            weights[11].ssW = 0.138;
            weights[11].statName = "Strength:";
            weights[11].speedName = "Skill Speed:";

            weights[12].name = "Black Mage";
            weights[12].vitW = 0.000;
            weights[12].mW = 1.000;
            weights[12].wdW = 11.884;
            weights[12].critW = 0.256;
            weights[12].detW = 0.206;
            weights[12].ssW = 0.283;
            weights[12].statName = "Intelligence:";
            weights[12].speedName = "Spell Speed:";

            weights[13].name = "Summoner";
            weights[13].vitW = 0.000;
            weights[13].mW = 1.000;
            weights[13].wdW = 11.835;
            weights[13].critW = 0.287;
            weights[13].detW = 0.192;
            weights[13].ssW = 0.195;
            weights[13].statName = "Intelligence:";
            weights[13].speedName = "Spell Speed:";

        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            vitWTextBox.ReadOnly = true;
            mWTextBox.ReadOnly = true;
            wdWTextBox.ReadOnly = true;
            critWTextBox.ReadOnly = true;
            detWTextBox.ReadOnly = true;
            ssWTextBox.ReadOnly = true;

            try
            {
                vitW = double.Parse(vitWTextBox.Text);
                mW = double.Parse(mWTextBox.Text);
                wdW = double.Parse(wdWTextBox.Text);
                critW = double.Parse(critWTextBox.Text);
                detW = double.Parse(detWTextBox.Text);
                ssW = double.Parse(ssWTextBox.Text);

                vit = double.Parse(vitTextBox.Text);
                m = double.Parse(mTextBox.Text);
                wd = double.Parse(wdTextBox.Text);
                crit = double.Parse(critTextBox.Text);
                det = double.Parse(detTextBox.Text);
                ss = double.Parse(ssTextBox.Text);

                weightTotal = (vitW * vitW) + (mW * m) + (wdW * wd) + (critW * crit) + (detW * det) + (ssW * ss);
                weightTotalLabel.Text = weightTotal.ToString("n3");
                string job = jobListBox.SelectedItem.ToString();
                historyListBox.Items.Add(job + "\t\t" + weightTotal + "\t\t" + commentsTextBox.Text);
  }

            catch (Exception)
            { MessageBox.Show("Please enter valid numbers."); }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            vitWTextBox.ReadOnly = false;
            mWTextBox.ReadOnly = false;
            wdWTextBox.ReadOnly = false;
            critWTextBox.ReadOnly = false;
            detWTextBox.ReadOnly = false;
            ssWTextBox.ReadOnly = false;
        }

        private void jobListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitWTextBox.ReadOnly = true;
            mWTextBox.ReadOnly = true;
            wdWTextBox.ReadOnly = true;
            critWTextBox.ReadOnly = true;
            detWTextBox.ReadOnly = true;
            ssWTextBox.ReadOnly = true;

            if (jobListBox.SelectedIndex != 1)
            {
                string job = jobListBox.SelectedItem.ToString();
                int index = jobListBox.SelectedIndex;

                vitWTextBox.Text = weights[index].vitW.ToString("n3");
                mWTextBox.Text = weights[index].mW.ToString("n3");
                wdWTextBox.Text = weights[index].wdW.ToString("n3");
                critWTextBox.Text = weights[index].critW.ToString("n3");
                detWTextBox.Text = weights[index].detW.ToString("n3");
                ssWTextBox.Text = weights[index].ssW.ToString("n3");
                mainWeightLabel.Text = weights[index].statName;
                mainLabel.Text = weights[index].statName;
                speedWeightLabel.Text = weights[index].speedName;
                ssLabel.Text = weights[index].speedName;

                vitTextBox.ReadOnly = false;
                mTextBox.ReadOnly = false;
                wdTextBox.ReadOnly = false;
                critTextBox.ReadOnly = false;
                detTextBox.ReadOnly = false;
                ssTextBox.ReadOnly = false;
                commentsTextBox.ReadOnly = false;
                editButton.Enabled = true;
                calculateButton.Enabled = true;



            }
            else { }
        }
    }

}

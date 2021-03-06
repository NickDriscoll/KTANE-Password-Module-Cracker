﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombPasswordCracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] possibleWords = { "about", "after", "again", "below", "could", "every", "first", "found", "great", 
                                   "house", "large", "learn", "never", "other", "place", "plant", "point", "right", 
                                   "small", "sound", "spell", "still", "study", "their", "there", "these", "thing", 
                                   "think", "three", "water", "where", "which", "world", "would", "write" };

        private void button1_Click(object sender, EventArgs e)
        {
            string row1 = firstRow.Text;
            string row2 = secondRow.Text;
            string row3 = thirdRow.Text;
            string row4 = fourthRow.Text;
            string row5 = fifthRow.Text;

            string finalWord = "";

            try
            {
                foreach (string word in possibleWords)
                {
                    //Loop for row1
                    for (int i = 0; i < 6; i++)
                    {
                        if (row1[i] == word[0])
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (row2[j] == word[1])
                                {
                                    for (int k = 0; k < 6; k++)
                                    {
                                        if (row3[k] == word[2])
                                        {
                                            for (int l = 0; l < 6; l++)
                                            {
                                                if (row4[l] == word[3])
                                                {
                                                    for (int m = 0; m < 6; m++)
                                                    {
                                                        finalWord = word;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (finalWord == "")
                {
                    label1.Text = "The letters you provided didn't match any passwords.";
                }
                else
                {
                    label1.Text = "The password is: " + finalWord.ToUpper();
                }

            }
            catch
            {
                label1.Text = "One or more of your columns contain less than six letters.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstRow.Text = "";
            secondRow.Text = "";
            thirdRow.Text = "";
            fourthRow.Text = "";
            fifthRow.Text = "";
        }
    }
}

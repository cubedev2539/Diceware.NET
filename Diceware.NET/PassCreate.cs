using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Diceware.NET
{
    public partial class PassCreate : Form
    {
        public Dictionary<int, string> FormattedDiceware = new Dictionary<int, string>();
        public RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
        public PassCreate(Dictionary<int,string> dicewareList)
        {
            FormattedDiceware = dicewareList;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Loops = (int)numericUpDown1.Value;
            List<string> WordList = new List<string>();
            int TempInt = 0;
            byte[] ByteOut = new byte[1];
            int[] Dice = new int[5];
            for (int l = 0; l < Loops; l++)
            {
                for (int i = 0; i < 5; i++)
                {
                    InvalidRoll:
                    rand.GetBytes(ByteOut);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(ByteOut);
                    TempInt = Convert.ToInt32(ByteOut[0]);
                    if (TempInt < 252)
                    {
                        switch (TempInt % 6)
                        {
                            case 0:
                                Dice[i] = 6;
                                break;
                            case 1:
                                Dice[i] = 1;
                                break;
                            case 2:
                                Dice[i] = 2;
                                break;
                            case 3:
                                Dice[i] = 3;
                                break;
                            case 4:
                                Dice[i] = 4;
                                break;
                            case 5:
                                Dice[i] = 5;
                                break;
                        }
                    }
                    else
                        goto InvalidRoll;
                }
                WordList.Add($"{FormattedDiceware[Convert.ToInt32($"{Dice[0]}{Dice[1]}{Dice[2]}{Dice[3]}{Dice[4]}")]}");
            }
            string SeparatorString = string.Empty;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    SeparatorString = string.Empty;
                    break;
                case 1:
                    SeparatorString = ".";
                    break;
                case 2:
                    SeparatorString = ",";
                    break;
                case 3:
                    SeparatorString = "+";
                    break;
                case 4:
                    SeparatorString = "-";
                    break;
                case 5:
                    SeparatorString = " ";
                    break;
                case 6:
                    SeparatorString = separatorContent.Text;
                    break;
                default:
                    SeparatorString = string.Empty;
                    break;
            }
            string PassString = WordList[0];
            WordList.RemoveAt(0);
            while(WordList.Count!=0)
            {
                PassString = PassString + SeparatorString + WordList[0];
                WordList.RemoveAt(0);
            }
            outputText.Text = PassString;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 6)
            {
                separatorContent.Enabled = false;
                separatorContent.Text = string.Empty;
            }
            else
                separatorContent.Enabled = true;
        }
    }
}

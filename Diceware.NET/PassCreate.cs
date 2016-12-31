using System;
using System.Collections;
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
        public string[] Diceware;
        public RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
        public PassCreate(string[] dicewareList)
        {
            Diceware = dicewareList;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputText.Text = string.Empty;
            int Loops = (int)numericUpDown1.Value;
            List<string> WordList = new List<string>();
            int TempInt = 0;
            byte[] ByteOut = new byte[1];
            BitArray Bits = new BitArray(13);
            int[] Number = new int[1];
            Refill:
            for (int l = 0; l < Loops; l++)
            {
                for (int i = 0; i < 13; i++)
                {
                    rand.GetNonZeroBytes(ByteOut);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(ByteOut);
                    TempInt = Convert.ToInt32(ByteOut[0]);
                    if (Enumerable.Range(0, 127).Contains(TempInt))
                        Bits[i] = false;
                    else
                        Bits[i] = true;
                }
                Bits.CopyTo(Number, 0);
                WordList.Add(Diceware[Number[0]]);
            }
            int DuplicateCount = 0;
            for (int a = 0; a < WordList.Count(); a++)
            {
                for (int b = 0; b < WordList.Count(); b++)
                {
                    if ((WordList[a] == WordList[b]) && (a != b))
                    {
                        WordList.RemoveAt(b);
                        DuplicateCount++;
                    }
                }
            }
            if (DuplicateCount != 0)
            {
                Loops = DuplicateCount;
                goto Refill;
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;

namespace Diceware.NET
{
    public partial class MainWindow : Form
    {
        public string[] Diceware;
        public bool RunRandomizer = false;
        public RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
        public MainWindow()
        {
            using (WebClient client = new WebClient())
                Diceware = client.DownloadString("http://world.std.com/~reinhold/diceware8k.txt").Split('\n');
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunRandomizer = true;
            int TempInt;
            byte[] ByteOut = new byte[1];
            BitArray Bits = new BitArray(13);
            int[] Number = new int[1];
            int Loops;
            try
            {
                Loops = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                Console.WriteLine("Invalid Number!");
                Loops = 1;
            }
            listBox1.Items.Clear();
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
                listBox1.Items.Add(Diceware[Number[0]]);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
                Clipboard.SetText(listBox1.SelectedItem.ToString().Split('-')[1].Remove(0,1));
            }
        }

        private void createPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassCreate passWin = new PassCreate(Diceware);
            passWin.Show();
        }

        private void aboutDicewareNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diceware.NET: A GUI to select random words from and create passwords using the Diceware word list\nVersion 1.2\nCreated by cubedev2539\n\nDiceware originally created by Arnold G. Reinhold (http://world.std.com/~reinhold/diceware.html)", "About Diceware.NET");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

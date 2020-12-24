using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {            
            if (textBoxNamaPanjang.Text == "")
            {
                MessageBox.Show("Tolong isi Textbox terlebih dahulu");
                textBoxNamaPanjang.Text = "";
            }
            else
            {
                labelhasil.Text = Proses(textBoxNamaPanjang.Text.ToUpper(), textBoxdari.Text.ToUpper(), textBoxmenjadi.Text.ToUpper());
            }
            //return labelhasil;
            textBoxNamaPanjang.CharacterCasing = CharacterCasing.Upper;
            char[] input = textBoxNamaPanjang.Text.ToCharArray();
            //string data = textBoxNamaPanjang.Text;
            //string A = textBoxdari.Text;
            //string B = textBoxmenjadi.Text;
            //int counter = 0;                        
            
        }

        private void textBoxdari_TextChanged(object sender, EventArgs e)
        {

        }
        public static char Code(char panda, int cucok)
        {
            char[] kumpulanabjad = new char[26];
            kumpulanabjad[0] = 'A';
            kumpulanabjad[1] = 'B';
            kumpulanabjad[2] = 'C';
            kumpulanabjad[3] = 'D';
            kumpulanabjad[4] = 'E';
            kumpulanabjad[5] = 'F';
            kumpulanabjad[6] = 'G';
            kumpulanabjad[7] = 'H';
            kumpulanabjad[8] = 'I';
            kumpulanabjad[9] = 'J';
            kumpulanabjad[10] = 'K';
            kumpulanabjad[11] = 'L';
            kumpulanabjad[12] = 'M';
            kumpulanabjad[13] = 'N';
            kumpulanabjad[14] = 'O';
            kumpulanabjad[15] = 'P';
            kumpulanabjad[16] = 'Q';
            kumpulanabjad[17] = 'R';
            kumpulanabjad[18] = 'S';
            kumpulanabjad[19] = 'T';
            kumpulanabjad[20] = 'U';
            kumpulanabjad[21] = 'V';
            kumpulanabjad[22] = 'W';
            kumpulanabjad[23] = 'X';
            kumpulanabjad[24] = 'Y';
            kumpulanabjad[25] = 'Z';

            if (!char.IsLetter(panda))
            {
                return panda;
            }
            char returns = kumpulanabjad[0];
            return (char)(((panda + cucok - returns) % 26) + returns);
        }

        public static string Proses(string NamaPanjang, string dari, string menjadi)
        {            
            int proses = (menjadi[0] < dari[0]) ? menjadi[0] - dari[0] + 26 : menjadi[0] - dari[0];
            string output = "";
            foreach (char panda in NamaPanjang)
            {
                output += Code(panda, proses);
            }
            return output;
        }
    }
}

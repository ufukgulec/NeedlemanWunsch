using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orhanufukgulec
{
    public partial class Form1 : Form
    {

        NeedlemanWunsch NeedlemanWunsch = new NeedlemanWunsch();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriCek();
        }

        private void veriCek()
        {
            try
            {
                string[] lines = File.ReadAllLines("../../seq1.txt");
                textBoxFirstArray.Text = lines[1].ToUpper();
                lines = File.ReadAllLines("../../seq2.txt");
                textBoxSecondArray.Text = lines[1].ToUpper();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Diziler bulunamadı");
            }
            textBoxMatch.Text = Convert.ToString(NeedlemanWunsch.Match);
            textBoxMis.Text = Convert.ToString(NeedlemanWunsch.MisMatch);
            textBoxGap.Text = Convert.ToString(NeedlemanWunsch.Gap);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            veriYaz();
            char[] list1 = textBoxFirstArray.Text.ToUpper().ToCharArray();
            char[] list2 = textBoxSecondArray.Text.ToUpper().ToCharArray();

            NeedlemanWunsch.Match = Convert.ToInt32(textBoxMatch.Text);
            NeedlemanWunsch.MisMatch = Convert.ToInt32(textBoxMis.Text);
            NeedlemanWunsch.Gap = Convert.ToInt32(textBoxGap.Text);

            int[,] matris = NeedlemanWunsch.MatrisDoldur(list1, list2);

            labelTime.Text = NeedlemanWunsch.GetRunTime();

            NeedlemanWunsch.dgwDoldur(dgw);

            labelPoint.Text = NeedlemanWunsch.score.ToString();
        }

        private void veriYaz()
        {
            try
            {
                File.WriteAllLines("../../seq1.txt", new string[] { textBoxFirstArray.Text.Length.ToString(), textBoxFirstArray.Text.ToUpper() });
                File.WriteAllLines("../../seq2.txt", new string[] { textBoxSecondArray.Text.Length.ToString(), textBoxSecondArray.Text.ToUpper() });
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Text bulunamadı");
            }

        }
    }
}

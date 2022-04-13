using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orhanufukgulec
{
    public class NeedlemanWunsch
    {
        public int Match;
        public int MisMatch;
        public int Gap;

        public int score = 0;
        public int[,] matris;

        private double Runtime;

        private char[] list1;
        private char[] list2;

        private DataGridView dataGridView;
        public NeedlemanWunsch(int match = 1, int misMatch = -1, int gap = -2)
        {
            Match = match;
            MisMatch = misMatch;
            Gap = gap;

        }
        /// <summary>
        /// Birinci ve ikinci dizinin eşleşme durumuna göre match, mismatch ve gap değerlerini kullarak matris oluşturur.
        /// </summary>
        /// <param name="list1">Birinci dizi</param>
        /// <param name="list2">İkinci dizi</param>
        /// <returns></returns>
        public int[,] MatrisDoldur(char[] list1, char[] list2)
        {
            this.list1 = list1;
            this.list2 = list2;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            matris = new int[list1.Length + 1, list2.Length + 1];

            matris[0, 0] = 0;//Başlangıç değeri

            //İlk sutun gap ile dolar
            for (int i = 1; i < list2.Length + 1; i++)
            {
                matris[0, i] = matris[0, i - 1] + Gap;
            }
            //İlk satır gap ile dolar
            for (int i = 1; i < list1.Length + 1; i++)
            {
                matris[i, 0] = matris[i - 1, 0] + Gap;
            }

            //Matris dolum
            for (int i = 1; i < list1.Length + 1; i++)
            {
                for (int j = 1; j < list2.Length + 1; j++)
                {
                    int deger;
                    if (list1[i - 1] == list2[j - 1])//Eşleşme durumu kontrolü
                    {
                        deger = Match;
                    }
                    else
                    {
                        deger = MisMatch;
                    }
                    matris[i, j] = EnBuyukDegeriAl(matris[i - 1, j - 1] + deger, matris[i - 1, j] + Gap, matris[i, j - 1] + Gap);
                }
            }
            watch.Stop();
            Runtime = watch.Elapsed.TotalMilliseconds;
            return matris;
        }
        /// <summary>
        /// Needleman Wunsch algoritmasında denklemde T(i,j)max'ı bulur.
        /// </summary>
        /// <param name="v1">(i-1,j-1) + Eşleşme (match veya mismatch) değeri</param>
        /// <param name="v2">(i-1,j) + Gap değeri</param>
        /// <param name="v3">(i,j-1) + Gap değeri</param>
        /// <returns></returns>
        private int EnBuyukDegeriAl(int v1, int v2, int v3)
        {
            return Math.Max(Math.Max(v1, v2), v3);
        }
        public string GetRunTime()
        {
            return Runtime + " ms";
        }
        /// <summary>
        /// Oluşturulan matrise göre verilen Datagridview'i doldurur.
        /// </summary>
        /// <param name="dataGridView">Formda değerler ile doldurulacak DataGridView</param>
        public void dgwDoldur(DataGridView dataGridView)
        {
            score = 0;

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            this.dataGridView = dataGridView;

            dataGridView.ColumnCount = list1.Length + 1;
            for (int i = 1; i < list1.Length + 1; i++) //1.Diziyi Sütun başlıklarına yazma
            {
                dataGridView.Columns[i].Name = list1[i - 1].ToString();
            }

            dataGridView.RowCount = list2.Length + 1;
            for (int i = 1; i < list2.Length + 1; i++)//2.Diziyi Satır başlıklarına yazma
            {
                dataGridView.Rows[i].HeaderCell.Value = list2[i - 1].ToString();
            }

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Convert.ToString(matris[j, i]);
                }
            }

            Dgwboya();
        }
        private void Dgwboya()
        {
            int X = list1.Length;
            int Y = list2.Length;

            dataGridView[0, 0].Style.BackColor = Color.Red;
            dataGridView[X, Y].Style.BackColor = Color.Red;

            while (X > 0 && Y > 0)
            {
                if (dataGridView.Columns[X].Name.Contains(dataGridView.Rows[Y].HeaderCell.Value.ToString())) //Eşleşme durumu
                {
                    dataGridView[X - 1, Y - 1].Style.BackColor = Color.Red;
                    X--;
                    Y--;
                    score += Match;
                }
                else
                {
                    int buyuk = EnBuyukDegeriAl(matris[X - 1, Y], matris[X - 1, Y - 1], matris[X, Y - 1]);

                    if (buyuk == Convert.ToInt32(dataGridView[X - 1, Y - 1].Value)) //En büyük değer sol üst
                    {
                        dataGridView[X - 1, Y - 1].Style.BackColor = Color.Red;
                        X--;
                        Y--;
                        score += MisMatch;
                    }
                    else if (buyuk == Convert.ToInt32(dataGridView[X - 1, Y].Value)) //En büyük değer sol
                    {
                        dataGridView[X - 1, Y].Style.BackColor = Color.Red;
                        X--;
                        score += Gap;
                    }
                    else //En büyük değer üst
                    {
                        dataGridView[X, Y - 1].Style.BackColor = Color.Red;
                        Y--;
                        score += Gap;
                    }
                }

            }
        }
    }
}

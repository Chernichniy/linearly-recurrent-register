using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace акр_3_кк
{
    public partial class svoya : Form
    {
        public svoya()
        {
            InitializeComponent();
        }

        private int[] sum(int[] Aint)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < Aint.Length / 2; i++)
            {
                if (Aint[i] == 0) count1++;
            }
            for (int i = Aint.Length / 2; i < Aint.Length; i++)
            {
                if (Aint[i] == 0) count2++;
            }

            int[] ch = new int[Aint.Length / 2];
            int p = 0;
            if (count1 > count2)
            {
                for (int i = 0; i < Aint.Length / 2; i++)
                {
                    ch[p] = Aint[i];
                    p++;
                }

            }
            else
            {
                for (int i = Aint.Length / 2; i < Aint.Length; i++)
                {
                    ch[p] = Aint[i];
                    p++;
                }
            }


            int[] koef = new int[ch.Length];
            koef[0] = ch[ch.Length - 1];
            int k = 1;
            for (int i = ch.Length - 1; i > 0; i--)
            {
                koef[k] = koef[k-1] + ch[i];
                if (koef[k] >=1||koef[k]==0) koef[k] = 1;
                else koef[k] = 0;

                k++;

            }
            int[] finall;

            int l = koef.Length;
            if (koef.Length == 4)
            {
                if (koef[0] == 1) label10.Text = "x^" + Convert.ToString(l - 3);
                if (koef[1] == 1) label9.Text = "x^" + Convert.ToString(l - 2);
                if (koef[2] == 1) label8.Text = "x^" + Convert.ToString(l - 1);
                if (koef[3] == 1) label7.Text = "x^" + Convert.ToString(l - 0);
            }
            if (koef.Length == 5)
            {
                if (koef[0] == 1) label10.Text = "x^" + Convert.ToString(l - 4);
                if (koef[1] == 1) label9.Text = "x^" + Convert.ToString(l - 3);
                if (koef[2] == 1) label8.Text = "x^" + Convert.ToString(l - 2);
                if (koef[3] == 1) label7.Text = "x^" + Convert.ToString(l - 1);
                if (koef[4] == 1) label6.Text = "x^" + Convert.ToString(l - 0);
            }
            if (koef.Length == 6)
            {
                if (koef[0] == 1) label10.Text = "x^" + Convert.ToString(l - 5);
                if (koef[1] == 1) label9.Text = "x^" + Convert.ToString(l - 4);
                if (koef[2] == 1) label8.Text = "x^" + Convert.ToString(l - 3);
                if (koef[3] == 1) label7.Text = "x^" + Convert.ToString(l - 2);
                if (koef[4] == 1) label6.Text = "x^" + Convert.ToString(l - 1);
                if (koef[5] == 1) label5.Text = "x^" + Convert.ToString(l - 0);
            }
            if (koef.Length == 7)
            {
                if (koef[0] == 1) label10.Text = "x^" + Convert.ToString(l - 6);
                if (koef[1] == 1) label9.Text = "x^" + Convert.ToString(l - 5);
                if (koef[2] == 1) label8.Text = "x^" + Convert.ToString(l - 4);
                if (koef[3] == 1) label7.Text = "x^" + Convert.ToString(l - 3);
                if (koef[4] == 1) label6.Text = "x^" + Convert.ToString(l - 2);
                if (koef[5] == 1) label5.Text = "x^" + Convert.ToString(l - 1);
                if (koef[6] == 1) label4.Text = "x^" + Convert.ToString(l - 0);
            }
            if (koef.Length == 8)
            {
                if (koef[0] == 1) label10.Text = "x^" + Convert.ToString(l - 7);
                if (koef[1] == 1) label9.Text = "x^" + Convert.ToString(l - 6);
                if (koef[2] == 1) label8.Text = "x^" + Convert.ToString(l - 5);
                if (koef[3] == 1) label7.Text = "x^" + Convert.ToString(l - 4);
                if (koef[5] == 1) label6.Text = "x^" + Convert.ToString(l - 3);
                if (koef[6] == 1) label5.Text = "x^" + Convert.ToString(l - 2);
                if (koef[7] == 1) label4.Text = "x^" + Convert.ToString(l - 1);
                if (koef[8] == 1) label3.Text = "x^" + Convert.ToString(l - 0);
            }
            if (koef.Length == 9)
            {
                if (koef[0] == 1) label10.Text = "x^" + Convert.ToString(l - 8);
                if (koef[1] == 1) label9.Text = "x^" + Convert.ToString(l - 7);
                if (koef[2] == 1) label8.Text = "x^" + Convert.ToString(l - 6);
                if (koef[3] == 1) label7.Text = "x^" + Convert.ToString(l - 5);
                if (koef[4] == 1) label6.Text = "x^" + Convert.ToString(l - 4);
                if (koef[5] == 1) label5.Text = "x^" + Convert.ToString(l - 3);
                if (koef[6] == 1) label4.Text = "x^" + Convert.ToString(l - 2);
                if (koef[7] == 1) label3.Text = "x^" + Convert.ToString(l - 1);
                if (koef[8] == 1) label2.Text = "x^" + Convert.ToString(l - 0);
            }
            if (koef.Length == 10)
            {
                if (koef[0] == 1) label10.Text = "x^" + Convert.ToString(l - 9);
                if (koef[1] == 1) label9.Text = "x^" + Convert.ToString(l - 8);
                if (koef[2] == 1) label8.Text = "x^" + Convert.ToString(l - 7);
                if (koef[3] == 1) label7.Text = "x^" + Convert.ToString(l - 6);
                if (koef[4] == 1) label6.Text = "x^" + Convert.ToString(l - 5);
                if (koef[5] == 1) label5.Text = "x^" + Convert.ToString(l - 4);
                if (koef[6] == 1) label4.Text = "x^" + Convert.ToString(l - 3);
                if (koef[7] == 1) label3.Text = "x^" + Convert.ToString(l - 2);
                if (koef[8] == 1) label2.Text = "x^" + Convert.ToString(l - 1);
                if (koef[9] == 1) label12.Text = "x^" + Convert.ToString(l - 0);
            }
            label11.Text = "+1";


            p = 0;
            if (count1 > count2)
            {
                for (int i = Aint.Length / 2; i < Aint.Length; i++)
                {
                    ch[p] = Aint[i];
                    p++;
                }

            }
            else
            {
                for (int i = 0; i < Aint.Length / 2; i++)
                {
                    ch[p] = Aint[i];
                    p++;
                }
            }

            finall = proofs(koef, ch);

            return finall;
        }


        private int[] proofs(int[] koef, int[] ch)
        {
            int[] finall = new int[ch.Length + 1];
            for (int i = 0; i < ch.Length; i++)
            {
                finall[i] = ch[i];
            }
            finall[finall.Length - 1] = koef[0];
            int l;
            int tmp;

            for (int j = 0; j < finall.Length - 1; j++)
            {
                tmp = finall[0];
                for (int i = 1; i < finall.Length - 1; i++)
                {
                    finall[0] = finall[i];
                    finall[i] = tmp;
                    tmp = finall[0];


                }
                finall[0] = koef[j];
                finall[finall.Length - 1] = koef[j];

            }
            int p = 0;
            for (int i = 0; i < koef.Length; i++)
            {
                if (koef[i] == 1) p++;
            }
            int pp = 0;
            //for (int j = 0; j < finall.Length - 1; j++)
            //{
            int jj = 0;
            for (int i = koef.Length - 1; i >= 0; i--)
            {

                if (koef[i] == finall[jj] && koef[i] == 1)
                {
                    //i--;
                    pp++;

                }
                jj++;
            }
            //}
            if (pp == p) label14.Text = "Последовательность совпадает";
            else label14.Text = "Последовательность не совпадает";
            return finall;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string posl = textBox1.Text;

            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            

            char[] xPosl = posl.ToCharArray();
            int[] Aint = xPosl.Select(w => w - '0').ToArray();
            label13.Text = "m= " + Aint.Length / 2;
            int[] res;
            res = sum(Aint);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();


        }
    }
}

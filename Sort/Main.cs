using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sort
{
    public partial class Main : Form
    {
        public int[] array;
        private Random rnd = new Random();
        public Main()
        {
            InitializeComponent();
        }
        // загрузка формы
        private void Work_Load(object sender, EventArgs e)
        {
            DialogResult authResult = new FormAuth().ShowDialog();

            if (authResult == DialogResult.Cancel)
            {
                this.Close();
            }
            Clear();
        }

        private void Clear()
        {
            listBox_Isxodny.Items.Clear();
            listBox_Itogovy.Items.Clear();
        }

        public void bGen_Click(object sender, EventArgs e)
        {
            Clear();
            array = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                array[i] = rnd.Next(0, 999);
                listBox_Isxodny.Items.Add(array[i]);
            }
        }

        public int[] Algorithm(bool isShow, out int count, int tocount = -1)
        {
            double gap = array.Length;
            var arr = (int[])array.Clone();
            bool swaps = true;
            count = 0;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < arr.Length)
                {
                    int igap = i + (int)gap;
                    if (arr[i] > arr[igap])
                    {
                        int swap = arr[i];
                        arr[i] = arr[igap];
                        arr[igap] = swap;
                        swaps = true;
                    }
                    i++;
                    count++;
                    if (tocount > 0 && count == tocount) return arr;
                }
            }
            if (isShow)
            {
                trackBar1.Maximum = count;
                iterations.Text = count.ToString();
                trackBar1_Scroll(null, null);
            }
            return arr;
        }


        private void bSort_Click(object sender, EventArgs e)
        {
            listBox_Itogovy.Items.Clear();
            var arr = Algorithm(true,out _);
            for (int i = 0; i < arr.Length; i++) listBox_Itogovy.Items.Add(arr[i]);
            trackBar1.Value = 1;
        }

        

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if(e.Index<0) return;
            e.Graphics.DrawString($"{e.Index})", e.Font, Brushes.DimGray, e.Bounds);
            e.Graphics.DrawString($"{((ListBox)sender).Items[e.Index]}", e.Font, new SolidBrush(e.ForeColor), e.Bounds.X+23,e.Bounds.Y);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var arr = Algorithm(false,out _,trackBar1.Value);
            Series s = new Series(){IsValueShownAsLabel = true};
            foreach (int i in arr)
            {
                s.Points.Add(i);
            }
            hysto.Series[0] = s;
        }
    }
}

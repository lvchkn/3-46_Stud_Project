using System;
using System.Windows.Forms;

namespace _1laba6variant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Simpson()
        {
            Solution S = new Solution();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double n = Convert.ToDouble(textBoxN.Text);

            labelSimpRes.Text = Convert.ToString(Math.Round(S.Simpson(a, b, n), 3));
        }

        private void SimpBtn_Click(object sender, EventArgs e)
        {
            Simpson();
        }
        private void Rectangle()
        {
            Solution R = new Solution();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double h = Convert.ToDouble(textBoxN.Text);

            labelRectRes.Text = Convert.ToString(Math.Round(R.Simpson(a, b, h), 3));
        }

        private void RectBtn_Click(object sender, EventArgs e)
        {
            Rectangle();
        }
    }
}

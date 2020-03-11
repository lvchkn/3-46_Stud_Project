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
            double n = Convert.ToDouble(textBoxN.Text);

            labelRectRes.Text = Convert.ToString(Math.Round(R.Rectangle(a, b, n), 3));
        }

        private void RectBtn_Click(object sender, EventArgs e)
        {
            Rectangle();
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            Features rtbS = new Features();
            rtbS.Name = "richTextBoxHintSimp1";
            rtbS.SetBounds(560, 180, 130, 100);
            rtbS.Text = "Условия применения метода Симпсона – N должно быть кратно 2. Алгебраический порядок точности метода - 4";
            this.Controls.Add(rtbS);

            Features rtbR = new Features();
            rtbR.Name = "richTextBoxHintRect1";
            rtbR.SetBounds(560, 290, 130, 100);
            rtbR.Text = "Алгебраический порядок точности метода средних прямоугольников - 1";
            this.Controls.Add(rtbR);

        }
    }
}

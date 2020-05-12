using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace _1laba6variant
{
    public partial class Form1 : Form
    {
        CancellationTokenSource _cts;
        public Form1()
        {
            InitializeComponent();

        }
        private async void Simpson()
        {
            Solution S = new Solution();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            int n = Convert.ToInt32(textBoxN.Text);

            pb.Value = 0;
            Stopwatch sw = new Stopwatch();
            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pb.Value = e; };

            double t = 0.0;
            sw.Start();

            try
            {
                t = await (S.Simpson(a, b, n, x =>
                     (322 * x) - Math.Log(11 * x) - 2, progress, _cts.Token));

                sw.Stop();

                labelSimpRes.Text = Convert.ToString(Math.Round(t, 3));                
            }
            catch (OperationCanceledException)
            {
                labelSimpRes.Text = "Отмена!";
            }                    
            
            lblSimpTime.Text = Convert.ToString(sw.Elapsed);
        }

        private void SimpBtn_Click(object sender, EventArgs e)
        {
            Simpson();
        }

        private async void Rectangle()
        {
            Solution R = new Solution();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            int n = Convert.ToInt32(textBoxN.Text);

            pb.Value = 0;
            Stopwatch sw = new Stopwatch();
            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pb.Value = e; };

            double t = 0.0;
            sw.Start();

            try
            {
                t = await (R.Rectangle(a, b, n, x =>
               (322 * x) - Math.Log(11 * x) - 2, progress, _cts.Token));

                sw.Stop();

                labelRectRes.Text = Convert.ToString(Math.Round(t, 3));
            }

            catch (OperationCanceledException)
            {
                labelRectRes.Text = "Отмена!";
            }

            lblRectTimeRes.Text = Convert.ToString(sw.Elapsed);
        }

        private void RectBtn_Click(object sender, EventArgs e)
        {
            Rectangle();
        }

        private async void ParSimpson()
        {
            Solution S = new Solution();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            int n = Convert.ToInt32(textBoxN.Text);

            Stopwatch sw = new Stopwatch();
            pb.Value = 0;
            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pb.Value = e; };

            double t = 0.0;
            sw.Start();

            try
            {
                t = await (S.ParallelSimpson(a, b, n, x =>
                   (322 * x) - Math.Log(11 * x) - 2, progress, _cts.Token));

                sw.Stop();

                lblParSimpRes.Text = Convert.ToString(Math.Round(t, 3));
            }

            catch (OperationCanceledException)
            {
                lblParSimpRes.Text = "Отмена!";
            }

            lblParSimpTime.Text = Convert.ToString(sw.Elapsed);
        }

        private void btnParSimp_Click(object sender, EventArgs e)
        {
            ParSimpson();
        }

        private async void ParRectangle()
        {
            Solution S = new Solution();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            int n = Convert.ToInt32(textBoxN.Text);

            Stopwatch sw = new Stopwatch();
            pb.Value = 0;
            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (sender, e) => { pb.Value = e; };

            double t = 0.0;
            sw.Start();

            try
            {
                t = await (S.ParallelRectangle(a, b, n, x =>
                 (322 * x) - Math.Log(11 * x) - 2, progress, _cts.Token));

                sw.Stop();

                lblParRectRes.Text = Convert.ToString(Math.Round(t, 3));
            }

            catch (OperationCanceledException)
            {
                lblParRectRes.Text = "Отмена!";
            }

            lblParRectTimeRes.Text = Convert.ToString(sw.Elapsed);
        }

        private void btnParRect_Click(object sender, EventArgs e)
        {
            ParRectangle();
        }

        private void Cancellation()
        {
            if (_cts != null)
            {
                _cts.Cancel();
            }
        }

        private void CancelSimp_Click(object sender, EventArgs e)
        {
            Cancellation();
        }

        private void CancelParSimp_Click(object sender, EventArgs e)
        {
            Cancellation();
        }

        private void CancelRect_Click(object sender, EventArgs e)
        {
            Cancellation();
        }

        private void CancelParRect_Click(object sender, EventArgs e)
        {
            Cancellation();
        }
    }
}

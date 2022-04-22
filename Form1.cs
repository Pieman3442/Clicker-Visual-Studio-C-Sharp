using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class frmClicker : Form
    {

        public frmClicker()
        {
            InitializeComponent();
        }

        public static class Form
        {
            public static bool open = true;
        }

        private void frmClicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.open = false;
        }

        public long counter;

        public class Clickers
        {
            private int clicksPerSecond;
            public int ClicksPerSecond { get; set; }

            private int cost;
            public int Cost { get; set; }

            private int quantity;
            public int Quantity { get; set; }

            public Clickers(int cps, int cost)
            {
                this.ClicksPerSecond = cps;
                this.Cost = cost;
                this.Quantity = 0;
            }
        }

        Clickers c1 = new Clickers(1, 50),
                 c2 = new Clickers(5, 500),
                 c3 = new Clickers(10, 1250),
                 c4 = new Clickers(25, 3000),
                 c5 = new Clickers(50, 7500);

        private void frmClicker_Load(object sender, EventArgs e)
        {
            if (bgwCombine.IsBusy != true)
                bgwCombine.RunWorkerAsync();
        }

        private void bgwCombine_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (Form.open)
            {
                worker.ReportProgress(Convert.ToInt32(counter));
                Thread.Sleep(10);
            }
        }

        private void bgwCombine_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblCounter.Text = counter.ToString("N0");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            counter++;
        }

        private void ActivateClicker(Clickers clicker, Label label, BackgroundWorker bgw )
        {
            if (counter >= clicker.Cost)
            {
                counter -= clicker.Cost;

                clicker.Quantity += 1;

                label.Text = "Owned: " + clicker.Quantity.ToString("N0");
                label.Visible = true;

                if (bgw.IsBusy != true)
                    bgw.RunWorkerAsync();
            }
        }

        private void BGWWork(object sender, Clickers clicker)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (Form.open)
            {
                Thread.Sleep(1000 / clicker.ClicksPerSecond);
                counter += 1 * clicker.Quantity;
                worker.ReportProgress(Convert.ToInt32(counter));
            }
        }

        private void btnClicker1_Click(object sender, EventArgs e)
        {
            this.ActivateClicker(c1, lblOwned1, bgwClicker1);
        }

        private void bgwClicker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BGWWork(sender, c1);
        }

        private void btnClicker2_Click(object sender, EventArgs e)
        {
            this.ActivateClicker(c2, lblOwned2, bgwClicker2);
        }

        private void bgwClicker2_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BGWWork(sender, c2);
        }

        private void btnClicker3_Click(object sender, EventArgs e)
        {
            this.ActivateClicker(c3, lblOwned3, bgwClicker3);
        }

        private void bgwClicker3_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BGWWork(sender, c3);
        }

        private void btnClicker4_Click(object sender, EventArgs e)
        {
            this.ActivateClicker(c4, lblOwned4, bgwClicker4);
        }

        private void bgwClicker4_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BGWWork(sender, c4);
        }

        private void btnClicker5_Click(object sender, EventArgs e)
        {
            this.ActivateClicker(c5, lblOwned5, bgwClicker5);
        }

        private void bgwClicker5_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BGWWork(sender, c5);
        }
    }
}

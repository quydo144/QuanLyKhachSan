using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Home
{
    public partial class frmFlashScreen : DevExpress.XtraEditors.XtraForm
    {
        public frmFlashScreen()
        {
            InitializeComponent();
        }

        private void frmFlashScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
            }         
            timer.Interval = 1000;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOC_FabricInvoicing.ApplicationForms
{
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
            Timer_Clock.Start();

            pb_Loading.Minimum = 0;
            pb_Loading.Maximum = 5000;

            for (int i = 0; i <= 5000; i++)
            {
                pb_Loading.Value = i;
                pb_Loading.PerformStep();
            }
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            Frm_InvoiceCreate form = new Frm_InvoiceCreate();
            form.Show();
            this.Hide();
            Timer_Clock.Stop();
        }
    }
}

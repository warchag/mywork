using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TelerikWinFormsApp5
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            RadForm2 objForm =  new RadForm2();
            objForm.TopLevel = false;
            radPanel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void RadForm1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = "Start = " + e.Start.ToShortDateString();
            Console.WriteLine(e.Start.Month);
            Console.WriteLine(e.Start.DayOfWeek);
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text =  "End = " + e.End.ToShortDateString();
        }
    }
}

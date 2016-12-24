using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiYABiS.Study.インタフェースの扱い.CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _compute(new ComputeAddition());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _compute(new ComputeSubtraction());
        }

        private void _compute(ICompute obj)
        {
            try
            {
                txtAns.Text = obj.Execute(long.Parse(txtValue1.Text), long.Parse(txtValue2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

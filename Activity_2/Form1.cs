using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            double earthWeight;
            double marsWeight;

            try
            {
                earthWeight = double.Parse(EarchWeigthTxb.Text);
                if (earthWeight < 0)
                {
                    MessageBox.Show("The weight needs to be positive");
                }
                else
                {
                    //Mars weight = 1/3 of the person’s Weight on Earth
                    marsWeight = earthWeight / 3;
                    MarsWeightTxb.Text = string.Format("{0:#,0.000}", marsWeight);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
          
        }
    }
}

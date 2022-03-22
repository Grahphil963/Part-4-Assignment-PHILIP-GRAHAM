using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4_Assignment_PHILIP_GRAHAM
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        
        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void RandomNumbers_Load(object sender, EventArgs e)
        {
           
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int minNumber = Convert.ToInt32(txtMin.Text); 
            int maxNumber = Convert.ToInt32(txtMax.Text);
            lblOutput.Text = generator.Next(minNumber , maxNumber) + "";
        }

        private void btnDbl_Click(object sender, EventArgs e)
        {
            int minNumber = Convert.ToInt32(txtMin.Text);
            int maxNumber = Convert.ToInt32(txtMax.Text);
            lblOutput.Text = (generator.Next(minNumber, maxNumber)) + (generator.NextDouble()) + "";

            

        }
    }
}

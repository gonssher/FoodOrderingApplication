using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFoodOrderingApplication
{
    public partial class FoodCategory : Form
    {
        public FoodCategory()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            VegeanIndian VeganIndiann = new VegeanIndian();
            VeganIndiann.ShowDialog();
        }

     

        private void Button2_Click_1(object sender, EventArgs e)
        {
            IndianRestaurant IndianRestaurentt = new IndianRestaurant();
            IndianRestaurentt.ShowDialog();

        }
    }
}

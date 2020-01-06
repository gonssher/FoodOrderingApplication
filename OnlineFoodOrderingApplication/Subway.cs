using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//////////////////////////////////////////////////////////
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlineFoodOrderingApplication
{
    public partial class Subway : Form
    {
        public Subway()
        {
            InitializeComponent();
            chickenPrice.Text = rest.fillLabelChickenSandwhich();
            beefPrice.Text = rest.fillLabelBeefSandwhich();
            vegPrice.Text = rest.fillLabelVeggieSandwhich();
            multiPrice.Text = rest.fillLabelComboSandwhich();
        
        }
        Restaurant rest = new Restaurant();

        
    



        private void ItalianBread_Click(object sender, EventArgs e)
        {
            CustomizedForm customizeForm = new CustomizedForm();
            customizeForm.Show();
        }

        private void MultiBread_Click(object sender, EventArgs e)
        {
            CustomizedForm customizeForm = new CustomizedForm();
            customizeForm.Show();
        }

        private void CiabBread_Click(object sender, EventArgs e)
        {
            CustomizedForm customizeForm = new CustomizedForm();
            customizeForm.Show();
        }

        private void FlatBrea_Click(object sender, EventArgs e)
        {
            CustomizedForm customizeForm = new CustomizedForm();
            customizeForm.Show();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            Ghst checkk = new Ghst();
            checkk.ShowDialog();
        }
    }
}

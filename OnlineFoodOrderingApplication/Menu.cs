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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LodListBox();
        }
        Restaurant rest = new Restaurant();
        public void LodListBox()
        {
            System.Collections.ArrayList list = rest.CreateCollectionOfItems();
            foreach (string item in list)
            {
                this.restaurantList.Items.Add(item);
            }  
        }
        private void Menuuuuu_Load(object sender, EventArgs e)
        {

        }

        private void RestaurantList_Click(object sender, EventArgs e)
        {
            string restaurants = restaurantList.SelectedItem.ToString();
            int index = restaurantList.FindString(restaurants);
            if (index == 0)
            {
                ThaiMenu thia = new ThaiMenu();
                thia.ShowDialog();
            }
            else if (index == 1)
            {
                Subway subways = new Subway();
                subways.ShowDialog();


            }
            else if (index == 2)
            {
                FoodCategory indianPlaces = new FoodCategory();
                indianPlaces.ShowDialog();

            }

        }

        private void RestaurantList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

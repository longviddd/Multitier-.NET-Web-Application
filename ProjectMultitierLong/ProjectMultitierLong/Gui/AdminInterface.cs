using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMultitierLong.Gui
{
    public partial class AdminInterface : Form
    {
        MidtermDatabaseEntities2 db = new MidtermDatabaseEntities2();
        public AdminInterface()
        {
            InitializeComponent();
        }



        private void AdminInterface_Load(object sender, EventArgs e)
        {
            using (MidtermDatabaseEntities2 db = new MidtermDatabaseEntities2())
            {
                comboBoxRegion.DataSource = db.Regions.ToList();
                comboBoxRegion.DisplayMember = "Regions";

            }
            comboBoxCity.SelectedIndex = 0;
            comboBoxFireplace.SelectedIndex = 0;
            comboBoxGarage.SelectedIndex = 0;
            comboBoxPool.SelectedIndex = 0;
            comboBoxRegion.SelectedIndex = 0;
            comboBoxSearchOption.SelectedIndex = 0;
            PopulateList();

        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MidtermDatabaseEntities2 db = new MidtermDatabaseEntities2())
            {


                int chosen = comboBoxRegion.SelectedIndex;
                switch (chosen)
                {
                    case 0:
                        comboBoxCity.DataSource = db.NovaScotias.ToList();
                        comboBoxCity.DisplayMember = "Cities";
                        break;
                    case 1:
                        comboBoxCity.DataSource = db.Ontarios.ToList();
                        comboBoxCity.DisplayMember = "Cities";
                        break;
                    case 2:
                        comboBoxCity.DataSource = db.Quebecs.ToList();
                        comboBoxCity.DisplayMember = "Cities";
                        break;
                }
            }
        }

        private void comboBoxSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chosen = comboBoxSearchOption.SelectedIndex;
            if (chosen == 0)
            {
                textBoxPriceMin.Enabled = false;
                textBoxPriceMax.Enabled = false;
                textBoxCitySearch.Enabled = true;
            }
            else if (chosen == 1)
            {
                textBoxCitySearch.Enabled = false;
                textBoxPriceMin.Enabled = true;
                textBoxPriceMax.Enabled = true;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            House newHouse = new House();
            int HouseId = Convert.ToInt32(textBoxHouseId.Text);
            House house = db.Houses.Find(HouseId);
            if (house != null)
            {
                MessageBox.Show("Enter a different ID");
            }
            else
            {
                if (int.TryParse(textBoxPrice.Text, out int num))
                {

                    if (int.TryParse(textBoxNumberRoom.Text, out int num1))
                    {

                        if (int.TryParse(textBoxNumberBathroom.Text, out int num2))
                        {
                            House newhouse = new House();
                            newhouse.HouseId = Convert.ToInt32(textBoxHouseId.Text);
                            newhouse.Region = comboBoxRegion.Text;
                            newhouse.City = comboBoxCity.Text;
                            newhouse.Price = Convert.ToInt32(textBoxPrice.Text);
                            newhouse.NumberOfRoom = Convert.ToInt32(textBoxNumberRoom.Text);
                            newhouse.NumberOfBathroom = Convert.ToInt32(textBoxNumberBathroom.Text);
                            newhouse.Garage = comboBoxGarage.Text;
                            newhouse.Pool = comboBoxPool.Text;
                            newhouse.Fireplace = comboBoxFireplace.Text;
                            db.Houses.Add(newhouse);
                            db.SaveChanges();
                            MessageBox.Show("House saved successfully");
                        }
                        else
                        {
                            MessageBox.Show("Number of bathroom has to be a number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of room has to be a number");
                    }
                }
                else
                {
                    MessageBox.Show("Price has to be a number");
                }
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int houseid = Convert.ToInt32(textBoxHouseId.Text);
            House updatedhouse = db.Houses.Find(houseid);
            if (updatedhouse != null)
            {
                updatedhouse.HouseId = Convert.ToInt32(textBoxHouseId.Text);
                updatedhouse.Region = comboBoxRegion.Text;
                updatedhouse.City = comboBoxCity.Text;
                updatedhouse.Price = Convert.ToInt32(textBoxPrice.Text);
                updatedhouse.NumberOfRoom = Convert.ToInt32(textBoxNumberRoom.Text);
                updatedhouse.NumberOfBathroom = Convert.ToInt32(textBoxNumberBathroom.Text);
                updatedhouse.Garage = comboBoxGarage.Text;
                updatedhouse.Pool = comboBoxPool.Text;
                updatedhouse.Fireplace = comboBoxFireplace.Text;
                db.Houses.Add(updatedhouse);
                db.SaveChanges();

            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            PopulateList();
        }
        private void PopulateList()
        {
            var houseList = from House in db.Houses select House;
            listView1.Items.Clear();
            foreach(var House in houseList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(House.HouseId));
                item.SubItems.Add(House.Region);
                item.SubItems.Add(House.City);
                item.SubItems.Add(Convert.ToString(House.Price));
                item.SubItems.Add(Convert.ToString(House.NumberOfRoom));
                item.SubItems.Add(Convert.ToString(House.NumberOfBathroom));
                item.SubItems.Add(House.Garage);
                item.SubItems.Add(House.Pool);
                item.SubItems.Add(House.Fireplace);
                listView1.Items.Add(item);

            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            textBoxHouseId.Text = item.SubItems[0].Text;
            comboBoxRegion.Text = item.SubItems[1].Text;
            comboBoxCity.Text = item.SubItems[2].Text;
            textBoxPrice.Text = item.SubItems[3].Text;
            textBoxNumberRoom.Text = item.SubItems[4].Text;
            textBoxNumberBathroom.Text = item.SubItems[5].Text;
            comboBoxGarage.Text = item.SubItems[6].Text;
            comboBoxPool.Text = item.SubItems[7].Text;
            comboBoxFireplace.Text = item.SubItems[8].Text;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int selectedOption = comboBoxSearchOption.SelectedIndex;
            switch (selectedOption)
            {
                case 0:
                    var listHouse = db.Houses.Where(ct => ct.City == textBoxCitySearch.Text).ToList();
                    if (listHouse.Count != 0)
                    {
                        foreach (var item in listHouse)
                        {
                            MessageBox.Show(item.HouseId + "--" + item.Region + "--" + item.City + "--" + item.Price);
                        }
                    }
                    else
                    {
                        MessageBox.Show("House doesn't exist");
                    }
                    break;
                case 1:
                    int lowerlimit = Convert.ToInt32(textBoxPriceMin.Text);
                    int upperlimit = Convert.ToInt32(textBoxPriceMax.Text);
                    var listHouse1 = db.Houses.Where(pr => pr.Price >= lowerlimit || pr.Price <= upperlimit).ToList();
                    if(listHouse1.Count != 0)
                    {
                        foreach (var item in listHouse1)
                        {
                            MessageBox.Show(item.HouseId + "--" + item.Region + "--"+item.City +"--" +item.Price);

                        }

                    }
                    else
                    {
                        MessageBox.Show("House Not Found");
                    }
                    break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int houseid = Convert.ToInt32(textBoxHouseId.Text);
            House house = db.Houses.Find(houseid);
            if (house != null)
            {
                db.Houses.Remove(house);
                db.SaveChanges();
                PopulateList();
                MessageBox.Show("Deleted");

            }
            else
            {
                MessageBox.Show("House not found ");
            }
        }
    }
}

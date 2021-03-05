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
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }
        MidtermDatabaseEntities2 db = new MidtermDatabaseEntities2();

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int selectedSearch = comboBoxSearchCondition.SelectedIndex;
            switch (selectedSearch)
            {
                case 0:
                    var listHouse0 = db.Houses.Where(ct => ct.City == comboBoxCity.Text).ToList<House>();
                    if(listHouse0.Count != 0)
                    {
                        foreach (var item in listHouse0)
                        {
                            MessageBox.Show(item.HouseId + "--" + item.Region + "--" + item.City + "--" + item.Price);
                        }
                    }
                    else
                    {
                        MessageBox.Show("House not found");
                    }
                    break;
                case 1:
                    var listHouse1 = db.Houses.Where(pr => pr.Price <= Convert.ToInt32(textBoxMaxPrice.Text) || pr.Price >= Convert.ToInt32(textBoxMinPrice.Text)).ToList<House>();
                    if (listHouse1.Count != 0)
                    {
                        foreach (var item in listHouse1)
                        {
                            MessageBox.Show(item.HouseId + "--" + item.Region + "--" + item.City + "--" + item.Price);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("House not found");
                    }
                    break;
                case 2:
                    string garage = "Yes";
                    if (radioFireplaceNo.Checked)
                    {
                        garage = "No";
                    }
                    else if (radioFireplaceYes.Checked)
                    {
                        garage = "Yes";
                    }
                    var listHouse2 = db.Houses.Where(gr => gr.Garage == garage).ToList<House>();
                    if (listHouse2.Count != 0)
                    {
                        foreach (var item in listHouse2)
                        {
                            MessageBox.Show(item.HouseId + "--" + item.Region + "--" + item.City + "--" + item.Price);
                        }

                    }
                    else
                    {
                        MessageBox.Show("House not found");
                    }
                    break;
                case 3:
                    string pool = "Yes";
                    if (radioPoolNo.Checked)
                    {
                        pool = "No";
                    }
                    else if (radioPoolYes.Checked)
                    {
                        pool = "Yes";
                    }
                    var listHouse3 = db.Houses.Where(po => po.Pool == pool).ToList<House>();
                    if (listHouse3.Count != 0)
                    {
                        foreach (var item in listHouse3)
                        {
                            MessageBox.Show(item.HouseId + "--" + item.Region + "--" + item.City + "--" + item.Price);
                        }

                    }
                    else
                    {
                        MessageBox.Show("House not found");
                    }
                    break;
                case 4:
                    string fireplace = "Yes";
                    if (radioFireplaceNo.Checked)
                    {
                        fireplace = "No";
                    }
                    else if (radioFireplaceYes.Checked)
                    {
                        fireplace = "Yes";
                    }
                    var listHouse4 = db.Houses.Where(fi => fi.Fireplace == fireplace).ToList<House>();
                    if (listHouse4.Count != 0)
                    {
                        foreach (var item in listHouse4)
                        {
                            MessageBox.Show(item.HouseId + "--" + item.Region + "--" + item.City + "--" + item.Price);
                        }

                    }
                    else
                    {
                        MessageBox.Show("House not found");
                    }
                    break;
            }
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            using (MidtermDatabaseEntities2 db = new MidtermDatabaseEntities2())
            {
                comboBoxRegion.DataSource = db.Regions.ToList();
                comboBoxRegion.DisplayMember = "Regions";
            }
        }

        private void comboBoxSearchCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}

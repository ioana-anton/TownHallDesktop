using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TownHallD.Controllers;
using TownHallD.DTO;

namespace TownHallD.Views
{
    public partial class UserHomepageForm : Form
    {
        private readonly UserController _userController;
        private readonly DocumentController _documentController;
        private readonly RequestController _requestController;
        private readonly HouseController _houseController;

        public UserHomepageForm(UserController userController,
            DocumentController documentController, RequestController requestController,
            HouseController houseController)
        {
            InitializeComponent();
            _userController = userController;
            _documentController = documentController;
            _requestController = requestController;
            _houseController = houseController;

            refresh();
        }

        void refresh()
        {
            HousesPanel.Hide();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(_userController, _documentController, _requestController);

            this.Hide();
            adminForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditHousesButton_Click(object sender, EventArgs e)
        {
            refresh();
            HousesPanel.Show();
            showHouses();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public async void showHouses()
        {
            try
            {

                List<DisplayHouseDTO> houses = await _houseController.ShowHouse();

                if (houses != null)
                {
                    dataGridView1.DataSource = houses;
                    dataGridView1.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddHouseButton_Click(object sender, EventArgs e)
        {
            try
            {

                var house = new CreateHouseDTO(AddressBox.Text, HouseTypeComboBox.SelectedItem.ToString());

                _houseController.AddHouse(house, IdUserLabel.Text);
                showHouses();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

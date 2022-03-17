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
            RequestPanel.Hide();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(_userController, _documentController, _requestController, _houseController);

            this.Hide();

            // Program.MyAppCxt.MainForm = adminForm;
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

        async void initRequestPanel()
        {

            List<DisplayHouseDTO> houses = await _houseController.ShowHouse(IdUserLabel.Text);
            List<String> addresses = new List<String>();
            addresses.Add("Choose House");
            foreach (DisplayHouseDTO house in houses)
            {
                addresses.Add(house.Address);
            }
            HouseComboBox.DataSource = addresses;

            List<DocumentDTO> docs = await _documentController.ShowDocument();
            List<String> type = new List<string>();
            type.Add("Choose Doc");
            foreach (DocumentDTO doc in docs)
            {
                type.Add(doc.Type);
            }
            comboBox2.DataSource = type;

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

                List<DisplayHouseDTO> houses = await _houseController.ShowHouse(IdUserLabel.Text);

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

        private async void showRequests(int opt = 0)
        {
            try
            {
                List<RequestDTO> reqs = new List<RequestDTO>();
                if (opt == 0)
                    reqs = await _requestController.ShowRequests();
                if (opt == 1)
                    reqs = await _requestController.ShowSortedRequestsByDate();

                Console.WriteLine("Numarul de requesturi totale: " + reqs.Count);

                if (reqs != null)
                {

                    //Console.WriteLine(reqs.ElementAt(0).User.Id);
                    List<DisplayRequestDTO> displayRequests = new List<DisplayRequestDTO>();
                    // if (reqs.Count >= 1)
                    for (int i = 0; i < reqs.Count; i++)
                    {
                        var req = reqs.ElementAt(i);
                        if (req.User != null)
                        {
                            if (AdminLabel.Text.Equals("False"))

                                if (req.User.Id.Equals(IdUserLabel.Text))
                                    //house si user dau null
                                    displayRequests.Add(new DisplayRequestDTO(req.Id, req.State, req.House.Address, req.User.Id, req.Document.Type, req.Date));


                            if (AdminLabel.Text.Equals("True"))
                                displayRequests.Add(new DisplayRequestDTO(req.Id, req.State, req.House.Address, req.User.Id, req.Document.Type, req.Date));
                        }

                    }

                    Console.WriteLine(displayRequests.Count);
                    dataGridView2.DataSource = displayRequests;

                    foreach (DataGridViewColumn col in dataGridView2.Columns)
                    {
                        if (AdminLabel.Text.Equals("False"))
                            if (col.HeaderText.Equals("State") || col.HeaderText.Equals("Id") || col.HeaderText.Equals("User"))
                                col.ReadOnly = true;
                        if (AdminLabel.Text.Equals("True"))
                            if (col.HeaderText.Equals("House") || col.HeaderText.Equals("Id") || col.HeaderText.Equals("User") || col.HeaderText.Equals("Document"))
                                col.ReadOnly = true;
                    }

                    dataGridView2.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void AddHouseButton_Click(object sender, EventArgs e)
        {
            try
            {

                var house = new CreateHouseDTO(AddressBox.Text, HouseTypeComboBox.SelectedItem.ToString());
                if (house.Type != null)
                {
                    await _houseController.AddHouse(house, IdUserLabel.Text);
                    showHouses();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RemoveHouseButton_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row != null)
                    {
                        DisplayHouseDTO house = row.DataBoundItem as DisplayHouseDTO;

                        HouseDTO housey = new HouseDTO();
                        housey.Id = house.Id;
                        if (housey != null)
                        {
                            await _houseController.RemoveHouse(housey);
                        }

                    }
                }

                showHouses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditRequestsButton_Click(object sender, EventArgs e)
        {
            refresh();
            initRequestPanel();
            showRequests();
            RequestPanel.Show();
            if (AdminLabel.Equals("False")) StateButton.Hide();
        }

        private async void AddRequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                var house = HouseComboBox.SelectedItem.ToString();
                var document = comboBox2.SelectedItem.ToString();
                await _requestController.AddRequest(IdUserLabel.Text, house, document);
                showRequests();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RemoveRequestButton_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (row != null)
                    {
                        DisplayRequestDTO request = row.DataBoundItem as DisplayRequestDTO;

                        RequestDTO requesty = new RequestDTO();
                        requesty.Id = request.Id;
                        if (requesty != null)
                        {
                            await _requestController.RemoveRequest(requesty);
                        }
                    }
                }

                showRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpdateRequestButton_Click(object sender, EventArgs e)
        {
            try
            {

                List<RequestDTO> reqs = await _requestController.ShowRequests();
                // List<DisplayRequestDTO> r = dataGridView2.ToList();


                if (reqs != null)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    for (int i = 0; i < reqs.Count - 1; i++)
                    {
                        row = dataGridView2.Rows[i];
                        var req = reqs.ElementAt(i);
                        var newHouse = row.Cells[2].Value.ToString();
                        var newDocument = row.Cells[4].Value.ToString();
                        // Console.WriteLine(newHouse);
                        await _requestController.UpdateRequest(req, newHouse, newDocument);
                    }
                }

                showRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void StateButton_Click(object sender, EventArgs e)
        {
            try
            {

                List<RequestDTO> reqs = await _requestController.ShowRequests();
                // List<DisplayRequestDTO> r = dataGridView2.ToList();


                if (reqs != null)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    for (int i = 0; i < reqs.Count - 1; i++)
                    {
                        row = dataGridView2.Rows[i];
                        var req = reqs.ElementAt(i);
                        var newState = row.Cells[1].Value.ToString();
                        Console.WriteLine(newState);
                        await _requestController.UpdateRequestAdmin(req, newState);
                    }
                }

                showRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5) showRequests(1);
        }

        private async void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            List<RequestDTO> r = new List<RequestDTO>();
            if (filterTextBox.Text != String.Empty)
            {
                r = await _requestController.ShowRealTimeFilter(filterTextBox.Text);
                dataGridView2.DataSource = r;
            }
            else
                showRequests();

        }
    }
}

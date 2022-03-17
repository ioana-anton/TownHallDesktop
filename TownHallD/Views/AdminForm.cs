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
using TownHallD.Entities;
using TownHallD.Utils.Constants;

namespace TownHallD.Views
{
    public partial class AdminForm : Form
    {
        private UserController _userController;
        private DocumentController _documentController;
        private RequestController _requestController;
        private HouseController _houseController;

        void refresh()
        {
            hideSelectUserGrid();
            hideEditDocument();
            RequestPanel.Hide();
        }

        public AdminForm(UserController userController, DocumentController documentController, RequestController requestController, HouseController houseController)
        {
            InitializeComponent();
            refresh();
            _userController = userController;
            _documentController = documentController;
            _requestController = requestController;
            _houseController = houseController;
        }

        private async void ShowUsersButton_Click(object sender, EventArgs e)
        {

            try
            {
                refresh();

                List<UserDTO> users = await _userController.ShowUsers();

                if (users != null)
                {
                    setSelectUserGrid(users);
                    showSelectUserGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(TownHallD.Utils.Constants.ErrorMessages.NO_USERS_ERROR_MESSAGE);
            }
        }


        private void EditDocumentButton_Click(object sender, EventArgs e)
        {
            refresh();
            showEditDocument();
            showDocuments();
        }

        private async void showDocuments()
        {
            try
            {
                var docs = await _documentController.ShowDocument();
                setDocumentGrid(docs);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void AddDocumentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var type = DocumentTypeBox.Text;
                var doc = new CreateDocumentDTO(type);
                // Console.WriteLine(doc.Type);
                await _documentController.AddDocument(doc);
                showDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RemoveDocumentButton_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (row != null)
                    {
                        var doc = row.DataBoundItem as DocumentDTO;
                        await _documentController.RemoveDocument(doc);
                    }
                }

                showDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditRequestsButton_Click(object sender, EventArgs e)
        {
            refresh();
            RequestPanel.Show();
            showRequests();
        }

        private async void showRequests()
        {
            try
            {
                var reqs = await _requestController.ShowRequests();
                RequestGridView.DataSource = reqs;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back2HomeButton_Click(object sender, EventArgs e)
        {
            //UserHomepageForm form = new UserHomepageForm(_userController, _documentController, _requestController, _houseController);
            this.Close();
            Program.MyAppCxt.MainForm.Show();
            // form.Show();
        }
    }

}

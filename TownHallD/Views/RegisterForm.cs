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
    public partial class RegisterForm : Form
    {
        private readonly UserController _userController;
        private readonly DocumentController _documentController;
        private readonly RequestController _requestController;
        private readonly HouseController _houseController;

        public RegisterForm(UserController userController, DocumentController documentController,
            RequestController requestController, HouseController houseController)
        {
            InitializeComponent();
            _userController = userController;
            _documentController = documentController;
            _requestController = requestController;
            _houseController = houseController;
        }

        public void RegisterButton_Click(object sender, EventArgs e)
        {
            var name = getNameBoxText();
            var email = getEmailBoxText();
            var password = getPasswordBoxText();

            try
            {
                var res = _userController.CreateUser(new CreateUserDTO(name, email, password));

                Console.WriteLine("Created account: " + res.ToString());

                LoginForm loginForm = new LoginForm(_userController, _documentController, _requestController, _houseController);

                Program.MyAppCxt.MainForm = loginForm;

                this.Close();
                loginForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

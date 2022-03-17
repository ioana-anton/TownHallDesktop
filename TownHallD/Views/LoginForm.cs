using TownHallD.Controllers;
using TownHallD.Utils.Constants;
using TownHallD.Views;

namespace TownHallD
{
    public partial class LoginForm : Form
    {
        private readonly UserController _userController;
        private readonly DocumentController _documentController;
        private readonly RequestController _requestController;
        private readonly HouseController _houseController;

        public LoginForm(UserController userController, DocumentController documentController,
            RequestController requestController, HouseController houseController)
        {
            InitializeComponent();
            _userController = userController;
            _documentController = documentController;
            _requestController = requestController;
            _houseController = houseController;
        }
        public void showLogin()
        {
            this.Show();
        }

        /*
        public CurrentUser GetCurrentUser()
        {
            return _currentUser;
        }*/

        public void hideLogin()
        {
            this.Hide();
        }


        private async void LoginButton_Click(object sender, EventArgs e)
        {

            var username = getUsernameBoxText();
            var password = getPasswordBoxText();

            try
            {
                var res = await _userController.LoginUser(new DTO.LoginUserDTO(username, password));
                Console.WriteLine("Logged in : " + res);
                if (res != null)
                {
                    this.Hide();

                    UserHomepageForm homepageForm = new UserHomepageForm(_userController, _documentController, _requestController, _houseController);

                    Program.MyAppCxt.MainForm = homepageForm;

                    this.Hide();

                    homepageForm.setTestLabel(res.Name);
                    homepageForm.setIdUserLabel(res.Id);
                    homepageForm.setAdminLabel(res.IsAdmin.ToString());
                    if (res.IsAdmin == false) homepageForm.hideAdminButton();
                    homepageForm.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RegisterForm registerForm = new RegisterForm(_userController, _documentController, _requestController, _houseController);

            Program.MyAppCxt.MainForm = registerForm;

            this.Close();
            registerForm.Show();

        }
    }
}
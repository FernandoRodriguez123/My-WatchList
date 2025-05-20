using MyWatchList.Data.Controller;

namespace MyWatchList
{
    public partial class SignInForm : Form
    {
        private bool _signing = true;
        private readonly MyWatchListQueryService _service;

        public SignInForm(MyWatchListQueryService service)
        {
            InitializeComponent();
            _service = service;

            passwordTxb.KeyDown += PasswordTxb_KeyDown;
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
        }

        private void ChangeSigningLbl_Click(object sender, EventArgs e)
        {
            if (_signing)
            {
                titleLbl.Text = "Crear Cuenta";
                submitBtn.Text = "Crear";
                changeSigningLbl.Text = "¿Ya tienes cuenta?";
            }
            else
            {
                titleLbl.Text = "Iniciar Sesión";
                submitBtn.Text = "Entrar";
                changeSigningLbl.Text = "¿Todavía no tienes cuenta?";
            }

            _signing = !_signing;

            HidePasswordError();
            HideUserNameError();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            var name = userNameTxb.Text.Trim();
            var password = passwordTxb.Text.Trim();

            if (_signing)
            {
                var user = _service.GetUserByName(name);

                if (user != null && _service.VerifyUserPassword(user.Id, password))
                {
                    OpenMainForm(user.Id);
                }
                else
                {
                    ShowUserNameError("*Usuario o contraseña incorrecto*");
                }
            }
            else
            {
                if (!ValidateInput(name, password)) return;

                if (_service.GetUserByName(name) != null)
                {
                    ShowUserNameError("*Ese nombre ya existe*");
                    return;
                }

                var user = _service.AddUser(name, password);
                OpenMainForm(user.Id);
            }
        }

        private void PasswordTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitBtn_Click(sender, e);
            }
        }

        private bool ValidateInput(string name, string password)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(name) || name.Length < 8 || name.Length > 20)
            {
                ShowUserNameError("*El nombre debe tener entre 8 y 20 caracteres*");
                valid = false;
            }
            else
            {
                HideUserNameError();
            }

            if (string.IsNullOrEmpty(password) || password.Length < 8 || password.Length > 20)
            {
                ShowPasswordError("*La contraseña debe tener entre 8 y 20 caracteres*");
                valid = false;
            }
            else
            {
                HidePasswordError();
            }

            return valid;
        }

        private void ShowUserNameError(string message)
        {
            userNameErrorLbl.Text = message;
            userNameErrorLbl.Visible = true;
        }

        private void HideUserNameError()
        {
            userNameErrorLbl.Text = "";
            userNameErrorLbl.Visible = false;
        }

        private void ShowPasswordError(string message)
        {
            passwordErrorLbl.Text = message;
            passwordErrorLbl.Visible = true;
        }

        private void HidePasswordError()
        {
            passwordErrorLbl.Text = "";
            passwordErrorLbl.Visible = false;
        }

        private void OpenMainForm(int userId)
        {
            var mainForm = new FilmLibraryForm(_service, userId);
            mainForm.Show();
            this.Hide();
        }
    }
}

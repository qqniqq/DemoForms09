using System;
using System.Windows.Forms;

using DemoLib.Services;
using DemoLib.Helpers;

namespace DemoForms.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService authService;

        public LoginForm()
        {
            InitializeComponent();

            authService =
                new AuthService();

            pictureLogo.Image =
                Properties.Resources.logo;
        }

        private void btnLogin_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtLogin.Text))
            {
                MessageBox.Show(
                    "Введите логин");

                return;
            }

            if (string.IsNullOrWhiteSpace(
                txtPassword.Text))
            {
                MessageBox.Show(
                    "Введите пароль");

                return;
            }

            bool result =
                authService.Login(
                    txtLogin.Text.Trim(),
                    txtPassword.Text.Trim());

            if (!result)
            {
                MessageBox.Show(
                    "Неверный логин или пароль");

                return;
            }

            Hide();

            MainProductsForm form =
                new MainProductsForm();

            form.ShowDialog();

            Show();
        }

        private void btnGuest_Click(
            object sender,
            EventArgs e)
        {
            SessionManager.Logout();

            Hide();

            MainProductsForm form =
                new MainProductsForm();

            form.ShowDialog();

            Show();
        }

        private void btnExit_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Windows.Forms;

namespace WinFormsApp9_variant_2
{
    public partial class MainForm : Form
    {
        private UserModel userModel;

        public MainForm()
        {
            InitializeComponent();

            // создаём пользователя
            userModel = new UserModel();

            // отображаем данные на форме
            UpdateProfileDisplay();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(userModel);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                UpdateProfileDisplay(); // обновляем после редактирования
            }
        }

        private void UpdateProfileDisplay()
        {
            lblName.Text = $"Имя: {userModel.Name}";
            lblEmail.Text = $"Email: {userModel.Email}";
        }
    }
}


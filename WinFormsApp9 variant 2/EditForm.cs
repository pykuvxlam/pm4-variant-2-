using System;
using System.Windows.Forms;

namespace WinFormsApp9_variant_2
{
    public partial class EditForm : Form
    {
        private UserModel userModel;

        public EditForm(UserModel user)
        {
            InitializeComponent();
            userModel = user;

            txtName.Text = userModel.Name;
            txtEmail.Text = userModel.Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userModel.Name = txtName.Text;
            userModel.Email = txtEmail.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}





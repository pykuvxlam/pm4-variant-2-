namespace WinFormsApp9_variant_2
{
    partial class EditForm
    {
        private System.ComponentModel.IContainer components = null;

        public Label lblNameLabel;
        public Label lblEmailLabel;
        public TextBox txtName;
        public TextBox txtEmail;
        public Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        protected new void InitializeComponent()
        {
            this.lblNameLabel = new Label();
            this.txtName = new TextBox();
            this.lblEmailLabel = new Label();
            this.txtEmail = new TextBox();
            this.btnSave = new Button();
            this.SuspendLayout();

            // lblNameLabel
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Location = new System.Drawing.Point(30, 30);
            this.lblNameLabel.Text = "Имя:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(100, 30);
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.Text = "";

            // lblEmailLabel
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Location = new System.Drawing.Point(30, 70);
            this.lblEmailLabel.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(100, 70);
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            this.txtEmail.Text = "";

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(100, 110);
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // EditForm
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.lblNameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSave);
            this.Text = "Редактирование профиля";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


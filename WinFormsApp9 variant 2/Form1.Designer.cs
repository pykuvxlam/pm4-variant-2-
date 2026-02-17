namespace WinFormsApp9_variant_2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        public Label lblName;
        public Label lblEmail;
        public Button btnEdit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        protected void InitializeComponent()
        {
            this.lblName = new Label();
            this.lblEmail = new Label();
            this.btnEdit = new Button();
            this.SuspendLayout();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Text = ""; // пусто, текст подставляется из кода

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 70);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Text = "";

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(30, 110);
            this.btnEdit.Size = new System.Drawing.Size(120, 30);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnEdit);
            this.Text = "Профиль пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

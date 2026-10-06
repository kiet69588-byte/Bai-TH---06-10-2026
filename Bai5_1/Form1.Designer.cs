namespace Bai5_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.GroupBox grpAdditional;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;

        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;

        private System.Windows.Forms.CheckBox chkTerms;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.ErrorProvider epCheck;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.grpAdditional = new System.Windows.Forms.GroupBox();

            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();

            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();

            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();

            this.lblGender = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();

            this.chkTerms = new System.Windows.Forms.CheckBox();

            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpPersonal.SuspendLayout();
            this.grpAdditional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();


            this.grpPersonal.Controls.Add(this.txtConfirmPassword);
            this.grpPersonal.Controls.Add(this.txtPassword);
            this.grpPersonal.Controls.Add(this.txtUsername);
            this.grpPersonal.Controls.Add(this.lblConfirmPassword);
            this.grpPersonal.Controls.Add(this.lblPassword);
            this.grpPersonal.Controls.Add(this.lblUsername);
            this.grpPersonal.Location = new System.Drawing.Point(30, 30);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(540, 180);
            this.grpPersonal.TabIndex = 0;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Thông tin tài khoản";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(25, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên đăng nhập:";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(170, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 23);
            this.txtUsername.TabIndex = 1;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu:";

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;

            // lblConfirmPassword
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(25, 125);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(118, 15);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu:";

            // txtConfirmPassword
            this.txtConfirmPassword.Location = new System.Drawing.Point(170, 122);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 23);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            // grpAdditional
            this.grpAdditional.Controls.Add(this.chkTerms);
            this.grpAdditional.Controls.Add(this.rdoFemale);
            this.grpAdditional.Controls.Add(this.rdoMale);
            this.grpAdditional.Controls.Add(this.lblGender);
            this.grpAdditional.Controls.Add(this.dtpBirthDate);
            this.grpAdditional.Controls.Add(this.lblBirthDate);
            this.grpAdditional.Location = new System.Drawing.Point(30, 225);
            this.grpAdditional.Name = "grpAdditional";
            this.grpAdditional.Size = new System.Drawing.Size(540, 175);
            this.grpAdditional.TabIndex = 1;
            this.grpAdditional.TabStop = false;
            this.grpAdditional.Text = "Thông tin bổ sung";

            // lblBirthDate
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(25, 35);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(62, 15);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "Ngày sinh:";

            // dtpBirthDate
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(170, 30);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(180, 23);
            this.dtpBirthDate.TabIndex = 1;
            this.dtpBirthDate.MaxDate = System.DateTime.Today;

            // lblGender
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(25, 75);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 15);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Giới tính:";

            // rdoMale
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(170, 73);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(50, 19);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;

            // rdoFemale 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(250, 73);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(41, 19);
            this.rdoFemale.TabIndex = 4;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;

            // chkTerms
            this.chkTerms.AutoSize = true;
            this.chkTerms.Location = new System.Drawing.Point(170, 112);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(250, 19);
            this.chkTerms.TabIndex = 5;
            this.chkTerms.Text = "Tôi đồng ý với điều khoản dịch vụ";
            this.chkTerms.UseVisualStyleBackColor = true;

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(160, 425);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 40);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(310, 425);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // epCheck
            this.epCheck.ContainerControl = this;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);

            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpAdditional);
            this.Controls.Add(this.grpPersonal);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";

            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();

            this.grpAdditional.ResumeLayout(false);
            this.grpAdditional.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();

            this.ResumeLayout(false);
        }
    }
}

namespace Registration_autotransport
{
    partial class RegistrationFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPasswordReg = new System.Windows.Forms.TextBox();
            this.txtLoginReg = new System.Windows.Forms.TextBox();
            this.lblPasswordReg = new System.Windows.Forms.Label();
            this.lblLoginReg = new System.Windows.Forms.Label();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.btnRegOk = new System.Windows.Forms.Button();
            this.lblRegWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInvalidLogin = new System.Windows.Forms.Label();
            this.lblInvalidPass = new System.Windows.Forms.Label();
            this.datePickerReg = new System.Windows.Forms.DateTimePicker();
            this.lblInsertSuccess = new System.Windows.Forms.Label();
            this.btnCloseRegForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordReg.Location = new System.Drawing.Point(248, 144);
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.Size = new System.Drawing.Size(153, 29);
            this.txtPasswordReg.TabIndex = 18;
            this.txtPasswordReg.UseSystemPasswordChar = true;
            this.txtPasswordReg.TextChanged += new System.EventHandler(this.TxtPasswordReg_TextChanged);
            // 
            // txtLoginReg
            // 
            this.txtLoginReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoginReg.Location = new System.Drawing.Point(248, 85);
            this.txtLoginReg.Name = "txtLoginReg";
            this.txtLoginReg.Size = new System.Drawing.Size(153, 29);
            this.txtLoginReg.TabIndex = 17;
            this.txtLoginReg.TextChanged += new System.EventHandler(this.TxtLoginReg_TextChanged);
            // 
            // lblPasswordReg
            // 
            this.lblPasswordReg.AutoSize = true;
            this.lblPasswordReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordReg.Location = new System.Drawing.Point(143, 144);
            this.lblPasswordReg.Name = "lblPasswordReg";
            this.lblPasswordReg.Size = new System.Drawing.Size(63, 21);
            this.lblPasswordReg.TabIndex = 16;
            this.lblPasswordReg.Text = "Пароль";
            // 
            // lblLoginReg
            // 
            this.lblLoginReg.AutoSize = true;
            this.lblLoginReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginReg.Location = new System.Drawing.Point(152, 88);
            this.lblLoginReg.Name = "lblLoginReg";
            this.lblLoginReg.Size = new System.Drawing.Size(54, 21);
            this.lblLoginReg.TabIndex = 15;
            this.lblLoginReg.Text = "Логин";
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegCancel.Location = new System.Drawing.Point(113, 264);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(93, 33);
            this.btnRegCancel.TabIndex = 14;
            this.btnRegCancel.Text = "Отмена";
            this.btnRegCancel.UseVisualStyleBackColor = true;
            this.btnRegCancel.Click += new System.EventHandler(this.BtnRegCancel_Click);
            // 
            // btnRegOk
            // 
            this.btnRegOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegOk.Location = new System.Drawing.Point(257, 264);
            this.btnRegOk.Name = "btnRegOk";
            this.btnRegOk.Size = new System.Drawing.Size(123, 33);
            this.btnRegOk.TabIndex = 13;
            this.btnRegOk.Text = "Подтвердить";
            this.btnRegOk.UseVisualStyleBackColor = true;
            this.btnRegOk.Click += new System.EventHandler(this.BtnRegOk_Click);
            // 
            // lblRegWelcome
            // 
            this.lblRegWelcome.AutoSize = true;
            this.lblRegWelcome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegWelcome.Location = new System.Drawing.Point(46, 25);
            this.lblRegWelcome.Name = "lblRegWelcome";
            this.lblRegWelcome.Size = new System.Drawing.Size(401, 25);
            this.lblRegWelcome.TabIndex = 19;
            this.lblRegWelcome.Text = "Пожалуйста, пройдите процедуру регистрации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Дата рождения";
            // 
            // lblInvalidLogin
            // 
            this.lblInvalidLogin.AutoSize = true;
            this.lblInvalidLogin.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidLogin.Location = new System.Drawing.Point(248, 121);
            this.lblInvalidLogin.Name = "lblInvalidLogin";
            this.lblInvalidLogin.Size = new System.Drawing.Size(0, 15);
            this.lblInvalidLogin.TabIndex = 22;
            // 
            // lblInvalidPass
            // 
            this.lblInvalidPass.AutoSize = true;
            this.lblInvalidPass.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPass.Location = new System.Drawing.Point(248, 176);
            this.lblInvalidPass.Name = "lblInvalidPass";
            this.lblInvalidPass.Size = new System.Drawing.Size(0, 15);
            this.lblInvalidPass.TabIndex = 23;
            // 
            // datePickerReg
            // 
            this.datePickerReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerReg.Location = new System.Drawing.Point(248, 200);
            this.datePickerReg.Name = "datePickerReg";
            this.datePickerReg.Size = new System.Drawing.Size(153, 29);
            this.datePickerReg.TabIndex = 19;
            // 
            // lblInsertSuccess
            // 
            this.lblInsertSuccess.AutoSize = true;
            this.lblInsertSuccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInsertSuccess.Location = new System.Drawing.Point(143, 240);
            this.lblInsertSuccess.Name = "lblInsertSuccess";
            this.lblInsertSuccess.Size = new System.Drawing.Size(0, 21);
            this.lblInsertSuccess.TabIndex = 24;
            // 
            // btnCloseRegForm
            // 
            this.btnCloseRegForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseRegForm.Location = new System.Drawing.Point(185, 312);
            this.btnCloseRegForm.Name = "btnCloseRegForm";
            this.btnCloseRegForm.Size = new System.Drawing.Size(88, 38);
            this.btnCloseRegForm.TabIndex = 25;
            this.btnCloseRegForm.Text = "Закрыть";
            this.btnCloseRegForm.UseVisualStyleBackColor = true;
            this.btnCloseRegForm.Visible = false;
            this.btnCloseRegForm.Click += new System.EventHandler(this.BtnCloseRegForm_Click);
            // 
            // RegistrationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.btnCloseRegForm);
            this.Controls.Add(this.lblInsertSuccess);
            this.Controls.Add(this.datePickerReg);
            this.Controls.Add(this.lblInvalidPass);
            this.Controls.Add(this.lblInvalidLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegWelcome);
            this.Controls.Add(this.txtPasswordReg);
            this.Controls.Add(this.txtLoginReg);
            this.Controls.Add(this.lblPasswordReg);
            this.Controls.Add(this.lblLoginReg);
            this.Controls.Add(this.btnRegCancel);
            this.Controls.Add(this.btnRegOk);
            this.Name = "RegistrationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма регистрации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordReg;
        private System.Windows.Forms.TextBox txtLoginReg;
        private System.Windows.Forms.Label lblPasswordReg;
        private System.Windows.Forms.Label lblLoginReg;
        private System.Windows.Forms.Button btnRegCancel;
        private System.Windows.Forms.Button btnRegOk;
        private System.Windows.Forms.Label lblRegWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvalidLogin;
        private System.Windows.Forms.Label lblInvalidPass;
        private System.Windows.Forms.DateTimePicker datePickerReg;
        private System.Windows.Forms.Label lblInsertSuccess;
        private System.Windows.Forms.Button btnCloseRegForm;
    }
}
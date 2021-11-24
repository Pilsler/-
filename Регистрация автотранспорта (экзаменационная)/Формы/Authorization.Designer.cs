
namespace Registration_autotransport
{
    partial class AuthorizationFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationFrm));
            this.btnAuthOk = new System.Windows.Forms.Button();
            this.btnAuthCancel = new System.Windows.Forms.Button();
            this.btnAuthReg = new System.Windows.Forms.Button();
            this.txtLoginAuth = new System.Windows.Forms.TextBox();
            this.txtPasswordAuth = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblInvalidLoginAuth = new System.Windows.Forms.Label();
            this.lblInvalidPasswordAuth = new System.Windows.Forms.Label();
            this.lblLoginAuth = new System.Windows.Forms.Label();
            this.picBackAuth = new System.Windows.Forms.PictureBox();
            this.lblPasswordAuth = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblErrorAuth = new System.Windows.Forms.Label();
            this.btnAboutProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuthOk
            // 
            this.btnAuthOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAuthOk.Location = new System.Drawing.Point(491, 502);
            this.btnAuthOk.Name = "btnAuthOk";
            this.btnAuthOk.Size = new System.Drawing.Size(121, 36);
            this.btnAuthOk.TabIndex = 0;
            this.btnAuthOk.Text = "Подтвердить";
            this.btnAuthOk.UseVisualStyleBackColor = true;
            this.btnAuthOk.Click += new System.EventHandler(this.BtnAuthOk_Click);
            // 
            // btnAuthCancel
            // 
            this.btnAuthCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAuthCancel.Location = new System.Drawing.Point(360, 502);
            this.btnAuthCancel.Name = "btnAuthCancel";
            this.btnAuthCancel.Size = new System.Drawing.Size(101, 36);
            this.btnAuthCancel.TabIndex = 1;
            this.btnAuthCancel.Text = "Отмена";
            this.btnAuthCancel.UseVisualStyleBackColor = true;
            this.btnAuthCancel.Click += new System.EventHandler(this.BtnAuthCancel_Click);
            // 
            // btnAuthReg
            // 
            this.btnAuthReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAuthReg.Location = new System.Drawing.Point(194, 503);
            this.btnAuthReg.Name = "btnAuthReg";
            this.btnAuthReg.Size = new System.Drawing.Size(131, 35);
            this.btnAuthReg.TabIndex = 2;
            this.btnAuthReg.Text = "Регистрация";
            this.btnAuthReg.UseVisualStyleBackColor = true;
            this.btnAuthReg.Click += new System.EventHandler(this.BtnAuthReg_Click);
            // 
            // txtLoginAuth
            // 
            this.txtLoginAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoginAuth.Location = new System.Drawing.Point(207, 427);
            this.txtLoginAuth.Name = "txtLoginAuth";
            this.txtLoginAuth.Size = new System.Drawing.Size(153, 29);
            this.txtLoginAuth.TabIndex = 5;
            this.txtLoginAuth.TextChanged += new System.EventHandler(this.TxtLoginAuth_TextChanged_1);
            // 
            // txtPasswordAuth
            // 
            this.txtPasswordAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordAuth.Location = new System.Drawing.Point(416, 427);
            this.txtPasswordAuth.Name = "txtPasswordAuth";
            this.txtPasswordAuth.Size = new System.Drawing.Size(153, 29);
            this.txtPasswordAuth.TabIndex = 6;
            this.txtPasswordAuth.UseSystemPasswordChar = true;
            this.txtPasswordAuth.TextChanged += new System.EventHandler(this.TxtPasswordAuth_TextChanged_1);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(643, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 36);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblInvalidLoginAuth
            // 
            this.lblInvalidLoginAuth.AutoSize = true;
            this.lblInvalidLoginAuth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvalidLoginAuth.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidLoginAuth.Location = new System.Drawing.Point(207, 469);
            this.lblInvalidLoginAuth.Name = "lblInvalidLoginAuth";
            this.lblInvalidLoginAuth.Size = new System.Drawing.Size(0, 15);
            this.lblInvalidLoginAuth.TabIndex = 28;
            // 
            // lblInvalidPasswordAuth
            // 
            this.lblInvalidPasswordAuth.AutoSize = true;
            this.lblInvalidPasswordAuth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvalidPasswordAuth.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPasswordAuth.Location = new System.Drawing.Point(418, 469);
            this.lblInvalidPasswordAuth.Name = "lblInvalidPasswordAuth";
            this.lblInvalidPasswordAuth.Size = new System.Drawing.Size(0, 15);
            this.lblInvalidPasswordAuth.TabIndex = 29;
            // 
            // lblLoginAuth
            // 
            this.lblLoginAuth.AutoSize = true;
            this.lblLoginAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginAuth.Location = new System.Drawing.Point(253, 403);
            this.lblLoginAuth.Name = "lblLoginAuth";
            this.lblLoginAuth.Size = new System.Drawing.Size(54, 21);
            this.lblLoginAuth.TabIndex = 3;
            this.lblLoginAuth.Text = "Логин";
            // 
            // picBackAuth
            // 
            this.picBackAuth.Image = ((System.Drawing.Image)(resources.GetObject("picBackAuth.Image")));
            this.picBackAuth.Location = new System.Drawing.Point(0, -1);
            this.picBackAuth.Name = "picBackAuth";
            this.picBackAuth.Size = new System.Drawing.Size(786, 347);
            this.picBackAuth.TabIndex = 7;
            this.picBackAuth.TabStop = false;
            // 
            // lblPasswordAuth
            // 
            this.lblPasswordAuth.AutoSize = true;
            this.lblPasswordAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordAuth.Location = new System.Drawing.Point(455, 403);
            this.lblPasswordAuth.Name = "lblPasswordAuth";
            this.lblPasswordAuth.Size = new System.Drawing.Size(63, 21);
            this.lblPasswordAuth.TabIndex = 4;
            this.lblPasswordAuth.Text = "Пароль";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(138, 365);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(528, 25);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Добро пожаловать в программу \"Регистрация транспорта\"";
            // 
            // lblErrorAuth
            // 
            this.lblErrorAuth.AutoSize = true;
            this.lblErrorAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorAuth.Location = new System.Drawing.Point(234, 466);
            this.lblErrorAuth.Name = "lblErrorAuth";
            this.lblErrorAuth.Size = new System.Drawing.Size(0, 21);
            this.lblErrorAuth.TabIndex = 30;
            // 
            // btnAboutProgram
            // 
            this.btnAboutProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAboutProgram.Location = new System.Drawing.Point(22, 503);
            this.btnAboutProgram.Name = "btnAboutProgram";
            this.btnAboutProgram.Size = new System.Drawing.Size(142, 35);
            this.btnAboutProgram.TabIndex = 31;
            this.btnAboutProgram.Text = "О программе";
            this.btnAboutProgram.UseVisualStyleBackColor = true;
            this.btnAboutProgram.Click += new System.EventHandler(this.BtnAboutProgram_Click);
            // 
            // AuthorizationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnAboutProgram);
            this.Controls.Add(this.lblErrorAuth);
            this.Controls.Add(this.picBackAuth);
            this.Controls.Add(this.lblInvalidPasswordAuth);
            this.Controls.Add(this.lblInvalidLoginAuth);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtPasswordAuth);
            this.Controls.Add(this.txtLoginAuth);
            this.Controls.Add(this.lblPasswordAuth);
            this.Controls.Add(this.lblLoginAuth);
            this.Controls.Add(this.btnAuthReg);
            this.Controls.Add(this.btnAuthCancel);
            this.Controls.Add(this.btnAuthOk);
            this.Name = "AuthorizationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация транспорта";
            ((System.ComponentModel.ISupportInitialize)(this.picBackAuth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuthOk;
        private System.Windows.Forms.Button btnAuthCancel;
        private System.Windows.Forms.Button btnAuthReg;
        private System.Windows.Forms.TextBox txtLoginAuth;
        private System.Windows.Forms.TextBox txtPasswordAuth;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblInvalidLoginAuth;
        private System.Windows.Forms.Label lblInvalidPasswordAuth;
        private System.Windows.Forms.Label lblLoginAuth;
        private System.Windows.Forms.PictureBox picBackAuth;
        private System.Windows.Forms.Label lblPasswordAuth;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblErrorAuth;
        private System.Windows.Forms.Button btnAboutProgram;
    }
}
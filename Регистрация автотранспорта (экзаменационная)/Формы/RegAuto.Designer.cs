
namespace Registration_autotransport
{
    partial class RegAuto
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
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVin = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblVinError = new System.Windows.Forms.Label();
            this.btnAutoCancel = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.lblModelError = new System.Windows.Forms.Label();
            this.lblMarksError = new System.Windows.Forms.Label();
            this.lblColorError = new System.Windows.Forms.Label();
            this.lblAutoExist = new System.Windows.Forms.Label();
            this.btnAutoClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarka.Location = new System.Drawing.Point(93, 36);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(57, 21);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Марка";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(84, 89);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(66, 21);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Модель";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(51, 141);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(99, 21);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(105, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цвет";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVin.Location = new System.Drawing.Point(82, 244);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(68, 21);
            this.lblVin.TabIndex = 4;
            this.lblVin.Text = "VIN-код";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(209, 33);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(180, 29);
            this.cmbMarka.Sorted = true;
            this.cmbMarka.TabIndex = 5;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.CmbMarka_SelectedIndexChanged);
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModel.Location = new System.Drawing.Point(209, 89);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(180, 29);
            this.txtModel.TabIndex = 6;
            this.txtModel.TextChanged += new System.EventHandler(this.TxtModel_TextChanged);
            // 
            // dtpYear
            // 
            this.dtpYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpYear.Location = new System.Drawing.Point(209, 141);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(180, 29);
            this.dtpYear.TabIndex = 7;
            // 
            // txtVin
            // 
            this.txtVin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVin.Location = new System.Drawing.Point(209, 246);
            this.txtVin.MaxLength = 17;
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(180, 29);
            this.txtVin.TabIndex = 8;
            this.txtVin.TextChanged += new System.EventHandler(this.TxtVin_TextChanged);
            this.txtVin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVin_KeyPress);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtColor.Location = new System.Drawing.Point(209, 193);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(180, 29);
            this.txtColor.TabIndex = 9;
            this.txtColor.Click += new System.EventHandler(this.TxtColor_Click);
            // 
            // lblVinError
            // 
            this.lblVinError.AutoSize = true;
            this.lblVinError.ForeColor = System.Drawing.Color.Red;
            this.lblVinError.Location = new System.Drawing.Point(209, 278);
            this.lblVinError.Name = "lblVinError";
            this.lblVinError.Size = new System.Drawing.Size(0, 15);
            this.lblVinError.TabIndex = 10;
            // 
            // btnAutoCancel
            // 
            this.btnAutoCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoCancel.Location = new System.Drawing.Point(75, 335);
            this.btnAutoCancel.Name = "btnAutoCancel";
            this.btnAutoCancel.Size = new System.Drawing.Size(90, 39);
            this.btnAutoCancel.TabIndex = 11;
            this.btnAutoCancel.Text = "Отмена";
            this.btnAutoCancel.UseVisualStyleBackColor = true;
            this.btnAutoCancel.Click += new System.EventHandler(this.BtnAutoCancel_Click);
            // 
            // btnSuccess
            // 
            this.btnSuccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuccess.Location = new System.Drawing.Point(236, 335);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(114, 39);
            this.btnSuccess.TabIndex = 12;
            this.btnSuccess.Text = "Подтвердить";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.BtnSuccess_Click);
            // 
            // lblModelError
            // 
            this.lblModelError.AutoSize = true;
            this.lblModelError.ForeColor = System.Drawing.Color.Red;
            this.lblModelError.Location = new System.Drawing.Point(209, 121);
            this.lblModelError.Name = "lblModelError";
            this.lblModelError.Size = new System.Drawing.Size(0, 15);
            this.lblModelError.TabIndex = 13;
            // 
            // lblMarksError
            // 
            this.lblMarksError.AutoSize = true;
            this.lblMarksError.ForeColor = System.Drawing.Color.Red;
            this.lblMarksError.Location = new System.Drawing.Point(209, 65);
            this.lblMarksError.Name = "lblMarksError";
            this.lblMarksError.Size = new System.Drawing.Size(0, 15);
            this.lblMarksError.TabIndex = 14;
            // 
            // lblColorError
            // 
            this.lblColorError.AutoSize = true;
            this.lblColorError.ForeColor = System.Drawing.Color.Red;
            this.lblColorError.Location = new System.Drawing.Point(209, 225);
            this.lblColorError.Name = "lblColorError";
            this.lblColorError.Size = new System.Drawing.Size(0, 15);
            this.lblColorError.TabIndex = 15;
            // 
            // lblAutoExist
            // 
            this.lblAutoExist.AutoSize = true;
            this.lblAutoExist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutoExist.ForeColor = System.Drawing.Color.Red;
            this.lblAutoExist.Location = new System.Drawing.Point(123, 299);
            this.lblAutoExist.Name = "lblAutoExist";
            this.lblAutoExist.Size = new System.Drawing.Size(0, 21);
            this.lblAutoExist.TabIndex = 16;
            // 
            // btnAutoClose
            // 
            this.btnAutoClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoClose.Location = new System.Drawing.Point(153, 391);
            this.btnAutoClose.Name = "btnAutoClose";
            this.btnAutoClose.Size = new System.Drawing.Size(95, 44);
            this.btnAutoClose.TabIndex = 17;
            this.btnAutoClose.Text = "Закрыть";
            this.btnAutoClose.UseVisualStyleBackColor = true;
            this.btnAutoClose.Visible = false;
            this.btnAutoClose.Click += new System.EventHandler(this.BtnAutoClose_Click);
            // 
            // RegAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 447);
            this.Controls.Add(this.btnAutoClose);
            this.Controls.Add(this.lblAutoExist);
            this.Controls.Add(this.lblColorError);
            this.Controls.Add(this.lblMarksError);
            this.Controls.Add(this.lblModelError);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.btnAutoCancel);
            this.Controls.Add(this.lblVinError);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Name = "RegAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о автотранспорте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblVinError;
        private System.Windows.Forms.Button btnAutoCancel;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.Label lblModelError;
        private System.Windows.Forms.Label lblMarksError;
        private System.Windows.Forms.Label lblColorError;
        private System.Windows.Forms.Label lblAutoExist;
        private System.Windows.Forms.Button btnAutoClose;
    }
}
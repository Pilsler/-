
namespace Registration_autotransport
{
    partial class MenuFrm
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
            this.btnRegTransport = new System.Windows.Forms.Button();
            this.btnSearchTransport = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCloseMenuFrm = new System.Windows.Forms.Button();
            this.btnEditAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegTransport
            // 
            this.btnRegTransport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegTransport.Location = new System.Drawing.Point(128, 74);
            this.btnRegTransport.Name = "btnRegTransport";
            this.btnRegTransport.Size = new System.Drawing.Size(320, 44);
            this.btnRegTransport.TabIndex = 0;
            this.btnRegTransport.Text = "Зарегистрировать траснпортное средство";
            this.btnRegTransport.UseVisualStyleBackColor = true;
            this.btnRegTransport.Click += new System.EventHandler(this.BtnRegTransport_Click);
            // 
            // btnSearchTransport
            // 
            this.btnSearchTransport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchTransport.Location = new System.Drawing.Point(128, 115);
            this.btnSearchTransport.Name = "btnSearchTransport";
            this.btnSearchTransport.Size = new System.Drawing.Size(320, 38);
            this.btnSearchTransport.TabIndex = 2;
            this.btnSearchTransport.Text = "Поиск транспортного средства";
            this.btnSearchTransport.UseVisualStyleBackColor = true;
            this.btnSearchTransport.Click += new System.EventHandler(this.BtnSearchTransport_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(165, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 28);
            this.lblWelcome.TabIndex = 3;
            // 
            // btnCloseMenuFrm
            // 
            this.btnCloseMenuFrm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseMenuFrm.Location = new System.Drawing.Point(128, 184);
            this.btnCloseMenuFrm.Name = "btnCloseMenuFrm";
            this.btnCloseMenuFrm.Size = new System.Drawing.Size(320, 37);
            this.btnCloseMenuFrm.TabIndex = 4;
            this.btnCloseMenuFrm.Text = "Выход";
            this.btnCloseMenuFrm.UseVisualStyleBackColor = true;
            this.btnCloseMenuFrm.Click += new System.EventHandler(this.BtnCloseMenuFrm_Click);
            // 
            // btnEditAuto
            // 
            this.btnEditAuto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditAuto.Location = new System.Drawing.Point(128, 149);
            this.btnEditAuto.Name = "btnEditAuto";
            this.btnEditAuto.Size = new System.Drawing.Size(320, 38);
            this.btnEditAuto.TabIndex = 5;
            this.btnEditAuto.Text = "Редактировать авто";
            this.btnEditAuto.UseVisualStyleBackColor = true;
            this.btnEditAuto.Click += new System.EventHandler(this.BtnEditAuto_Click);
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 298);
            this.Controls.Add(this.btnEditAuto);
            this.Controls.Add(this.btnCloseMenuFrm);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSearchTransport);
            this.Controls.Add(this.btnRegTransport);
            this.Name = "MenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет автотранспорта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegTransport;
        private System.Windows.Forms.Button btnSearchTransport;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCloseMenuFrm;
        private System.Windows.Forms.Button btnEditAuto;
    }
}
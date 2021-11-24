
namespace Registration_autotransport
{
    partial class EditAutoFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEdit = new System.Windows.Forms.Label();
            this.dataGridEdit = new System.Windows.Forms.DataGridView();
            this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_maked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtEditModel = new System.Windows.Forms.TextBox();
            this.txtEditColor = new System.Windows.Forms.TextBox();
            this.txtEditVin = new System.Windows.Forms.TextBox();
            this.dtpEditDate = new System.Windows.Forms.DateTimePicker();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.lblEditError = new System.Windows.Forms.Label();
            this.btnEditClose = new System.Windows.Forms.Button();
            this.cmbEditMarks = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdit.Location = new System.Drawing.Point(22, 57);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(342, 21);
            this.lblEdit.TabIndex = 1;
            this.lblEdit.Text = "Выберите в таблице авто для редактирования";
            // 
            // dataGridEdit
            // 
            this.dataGridEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridEdit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEdit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marks,
            this.model,
            this.date_maked,
            this.Color,
            this.VIN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEdit.Location = new System.Drawing.Point(22, 234);
            this.dataGridEdit.Name = "dataGridEdit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEdit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEdit.RowTemplate.Height = 25;
            this.dataGridEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEdit.Size = new System.Drawing.Size(756, 194);
            this.dataGridEdit.TabIndex = 3;
            this.dataGridEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEdit_CellClick);
            // 
            // marks
            // 
            this.marks.HeaderText = "Марка авто";
            this.marks.Name = "marks";
            this.marks.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Модель авто";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // date_maked
            // 
            this.date_maked.HeaderText = "Дата сборки авто";
            this.date_maked.Name = "date_maked";
            this.date_maked.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN-код";
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOwner.Location = new System.Drawing.Point(22, 19);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(397, 25);
            this.lblOwner.TabIndex = 4;
            this.lblOwner.Text = "Список авто принадлежащих пользователю";
            // 
            // txtEditModel
            // 
            this.txtEditModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditModel.Location = new System.Drawing.Point(22, 134);
            this.txtEditModel.Name = "txtEditModel";
            this.txtEditModel.Size = new System.Drawing.Size(171, 29);
            this.txtEditModel.TabIndex = 5;
            // 
            // txtEditColor
            // 
            this.txtEditColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditColor.Location = new System.Drawing.Point(218, 94);
            this.txtEditColor.Name = "txtEditColor";
            this.txtEditColor.Size = new System.Drawing.Size(171, 29);
            this.txtEditColor.TabIndex = 6;
            this.txtEditColor.Click += new System.EventHandler(this.TxtEditColor_Click);
            // 
            // txtEditVin
            // 
            this.txtEditVin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditVin.Location = new System.Drawing.Point(218, 134);
            this.txtEditVin.MaxLength = 17;
            this.txtEditVin.Name = "txtEditVin";
            this.txtEditVin.Size = new System.Drawing.Size(171, 29);
            this.txtEditVin.TabIndex = 7;
            // 
            // dtpEditDate
            // 
            this.dtpEditDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEditDate.Location = new System.Drawing.Point(22, 177);
            this.dtpEditDate.Name = "dtpEditDate";
            this.dtpEditDate.Size = new System.Drawing.Size(171, 29);
            this.dtpEditDate.TabIndex = 10;
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSave.Location = new System.Drawing.Point(239, 177);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(117, 44);
            this.btnEditSave.TabIndex = 11;
            this.btnEditSave.Text = "Сохранить";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.BtnEditSave_Click);
            // 
            // lblEditError
            // 
            this.lblEditError.AutoSize = true;
            this.lblEditError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEditError.Location = new System.Drawing.Point(430, 94);
            this.lblEditError.Name = "lblEditError";
            this.lblEditError.Size = new System.Drawing.Size(0, 21);
            this.lblEditError.TabIndex = 12;
            // 
            // btnEditClose
            // 
            this.btnEditClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditClose.Location = new System.Drawing.Point(661, 177);
            this.btnEditClose.Name = "btnEditClose";
            this.btnEditClose.Size = new System.Drawing.Size(117, 44);
            this.btnEditClose.TabIndex = 13;
            this.btnEditClose.Text = "Закрыть";
            this.btnEditClose.UseVisualStyleBackColor = true;
            this.btnEditClose.Click += new System.EventHandler(this.BtnEditClose_Click);
            // 
            // cmbEditMarks
            // 
            this.cmbEditMarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEditMarks.FormattingEnabled = true;
            this.cmbEditMarks.Location = new System.Drawing.Point(22, 94);
            this.cmbEditMarks.Name = "cmbEditMarks";
            this.cmbEditMarks.Size = new System.Drawing.Size(171, 29);
            this.cmbEditMarks.TabIndex = 14;
            // 
            // EditAutoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEditMarks);
            this.Controls.Add(this.btnEditClose);
            this.Controls.Add(this.lblEditError);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.dtpEditDate);
            this.Controls.Add(this.txtEditVin);
            this.Controls.Add(this.txtEditColor);
            this.Controls.Add(this.txtEditModel);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.dataGridEdit);
            this.Controls.Add(this.lblEdit);
            this.Name = "EditAutoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование авто";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.DataGridView dataGridEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_maked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtEditModel;
        private System.Windows.Forms.TextBox txtEditColor;
        private System.Windows.Forms.TextBox txtEditVin;
        private System.Windows.Forms.DateTimePicker dtpEditDate;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Label lblEditError;
        private System.Windows.Forms.Button btnEditClose;
        private System.Windows.Forms.ComboBox cmbEditMarks;
    }
}
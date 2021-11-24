
namespace Registration_autotransport
{
    partial class SearchFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTextSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchError = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_maked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.btnExportAuto = new System.Windows.Forms.Button();
            this.lblGridEmpty = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbSearchMenu = new System.Windows.Forms.ComboBox();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.cmbMarks = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(259, 196);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // lblTextSearch
            // 
            this.lblTextSearch.AutoSize = true;
            this.lblTextSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextSearch.Location = new System.Drawing.Point(18, 163);
            this.lblTextSearch.Name = "lblTextSearch";
            this.lblTextSearch.Size = new System.Drawing.Size(220, 21);
            this.lblTextSearch.TabIndex = 1;
            this.lblTextSearch.Text = "Введите VIN-код автомобиля";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(25, 200);
            this.txtSearch.MaxLength = 17;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // lblSearchError
            // 
            this.lblSearchError.AutoSize = true;
            this.lblSearchError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchError.Location = new System.Drawing.Point(33, 260);
            this.lblSearchError.Name = "lblSearchError";
            this.lblSearchError.Size = new System.Drawing.Size(0, 21);
            this.lblSearchError.TabIndex = 3;
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.owner,
            this.mark,
            this.mod,
            this.date_maked,
            this.color,
            this.VIN});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.Location = new System.Drawing.Point(25, 296);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(750, 291);
            this.dataGrid.TabIndex = 4;
            // 
            // owner
            // 
            this.owner.HeaderText = "Владелец авто";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            // 
            // mark
            // 
            this.mark.HeaderText = "Марка авто";
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            // 
            // mod
            // 
            this.mod.HeaderText = "Модель авто";
            this.mod.Name = "mod";
            this.mod.ReadOnly = true;
            // 
            // date_maked
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.date_maked.DefaultCellStyle = dataGridViewCellStyle3;
            this.date_maked.HeaderText = "Дата сборки";
            this.date_maked.Name = "date_maked";
            this.date_maked.ReadOnly = true;
            // 
            // color
            // 
            this.color.HeaderText = "Цвет";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN-код";
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            // 
            // btnCloseSearch
            // 
            this.btnCloseSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseSearch.Location = new System.Drawing.Point(571, 196);
            this.btnCloseSearch.Name = "btnCloseSearch";
            this.btnCloseSearch.Size = new System.Drawing.Size(96, 35);
            this.btnCloseSearch.TabIndex = 5;
            this.btnCloseSearch.Text = "Закрыть";
            this.btnCloseSearch.UseVisualStyleBackColor = true;
            this.btnCloseSearch.Click += new System.EventHandler(this.BtnCloseSearch_Click);
            // 
            // btnExportAuto
            // 
            this.btnExportAuto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportAuto.Location = new System.Drawing.Point(389, 196);
            this.btnExportAuto.Name = "btnExportAuto";
            this.btnExportAuto.Size = new System.Drawing.Size(144, 35);
            this.btnExportAuto.TabIndex = 6;
            this.btnExportAuto.Text = "Экспорт в файл";
            this.btnExportAuto.UseVisualStyleBackColor = true;
            this.btnExportAuto.Click += new System.EventHandler(this.BtnExportAuto_Click);
            // 
            // lblGridEmpty
            // 
            this.lblGridEmpty.AutoSize = true;
            this.lblGridEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGridEmpty.Location = new System.Drawing.Point(385, 260);
            this.lblGridEmpty.Name = "lblGridEmpty";
            this.lblGridEmpty.Size = new System.Drawing.Size(0, 21);
            this.lblGridEmpty.TabIndex = 7;
            // 
            // Username
            // 
            this.Username.HeaderText = "Владелец авто";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // marks
            // 
            this.marks.HeaderText = "Марка авто";
            this.marks.Name = "marks";
            this.marks.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя владельца";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя владельца";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Марка авто";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Имя владельца";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(25, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(308, 21);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Выберите поле, по которому будет поиск";
            // 
            // cmbSearchMenu
            // 
            this.cmbSearchMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSearchMenu.FormattingEnabled = true;
            this.cmbSearchMenu.Items.AddRange(new object[] {
            "Марка авто",
            "Модель авто",
            "Дата сборки авто",
            "Цвет",
            "VIN-код"});
            this.cmbSearchMenu.Location = new System.Drawing.Point(32, 63);
            this.cmbSearchMenu.Name = "cmbSearchMenu";
            this.cmbSearchMenu.Size = new System.Drawing.Size(166, 29);
            this.cmbSearchMenu.TabIndex = 9;
            this.cmbSearchMenu.SelectedValueChanged += new System.EventHandler(this.CmbSearchMenu_SelectedValueChanged);
            // 
            // dtpSearch
            // 
            this.dtpSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSearch.Location = new System.Drawing.Point(25, 202);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(213, 29);
            this.dtpSearch.TabIndex = 10;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtColor.Location = new System.Drawing.Point(25, 200);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(213, 29);
            this.txtColor.TabIndex = 11;
            this.txtColor.Click += new System.EventHandler(this.TxtColor_Click_1);
            // 
            // cmbMarks
            // 
            this.cmbMarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMarks.FormattingEnabled = true;
            this.cmbMarks.Items.AddRange(new object[] {
            "VIN-код",
            "Дата сборки авто",
            "Марка авто",
            "Модель авто",
            "Цвет"});
            this.cmbMarks.Location = new System.Drawing.Point(25, 200);
            this.cmbMarks.Name = "cmbMarks";
            this.cmbMarks.Size = new System.Drawing.Size(213, 29);
            this.cmbMarks.Sorted = true;
            this.cmbMarks.TabIndex = 12;
            // 
            // SearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.cmbSearchMenu);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblGridEmpty);
            this.Controls.Add(this.btnExportAuto);
            this.Controls.Add(this.btnCloseSearch);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lblSearchError);
            this.Controls.Add(this.lblTextSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.cmbMarks);
            this.Controls.Add(this.txtColor);
            this.Name = "SearchFrm";
            this.Text = "Поиск автомобиля";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTextSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchError;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnCloseSearch;
        private System.Windows.Forms.Button btnExportAuto;
        private System.Windows.Forms.Label lblGridEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_maked;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbSearchMenu;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ComboBox cmbMarks;
    }
}
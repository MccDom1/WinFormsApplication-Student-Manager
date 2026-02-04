namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            txtStudId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtGrade = new TextBox();
            cmbMonth = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(1, 252);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 82;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(794, 195);
            dgvStudents.TabIndex = 0;
            // 
            // txtStudId
            // 
            txtStudId.Location = new Point(29, 27);
            txtStudId.Name = "txtStudId";
            txtStudId.Size = new Size(200, 39);
            txtStudId.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(29, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 39);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(29, 117);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 39);
            txtLastName.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(29, 162);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 39);
            txtAddress.TabIndex = 4;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(29, 207);
            txtGrade.MaxLength = 1;
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(200, 39);
            txtGrade.TabIndex = 5;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(592, 113);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(156, 40);
            cmbMonth.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(342, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 39);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add\r\n";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(342, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(194, 41);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Selected\r\n";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cmbMonth);
            Controls.Add(txtGrade);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudId);
            Controls.Add(dgvStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private TextBox txtStudId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtGrade;
        private ComboBox cmbMonth;
        private Button btnAdd;
        private Button btnDelete;
    }
}

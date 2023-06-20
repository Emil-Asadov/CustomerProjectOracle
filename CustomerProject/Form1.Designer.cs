namespace CustomerProject
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.lblDocNo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.maskedBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFinCode = new System.Windows.Forms.TextBox();
            this.lblFinCode = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCustIdn = new System.Windows.Forms.TextBox();
            this.lblCustIdn = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCustomerFullNameById = new System.Windows.Forms.Button();
            this.lblCustFullNameById = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(58, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 16);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Ad:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(90, 66);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(211, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(35, 69);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(50, 16);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Soyad:";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(90, 94);
            this.txtBirthPlace.Multiline = true;
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(211, 110);
            this.txtBirthPlace.TabIndex = 3;
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Location = new System.Drawing.Point(6, 97);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(79, 16);
            this.lblBirthPlace.TabIndex = 20;
            this.lblBirthPlace.Text = "Doğum yeri:";
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(420, 72);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(100, 22);
            this.txtDocNo.TabIndex = 6;
            // 
            // lblDocNo
            // 
            this.lblDocNo.AutoSize = true;
            this.lblDocNo.Location = new System.Drawing.Point(340, 75);
            this.lblDocNo.Name = "lblDocNo";
            this.lblDocNo.Size = new System.Drawing.Size(73, 16);
            this.lblDocNo.TabIndex = 23;
            this.lblDocNo.Text = "Seriya No.:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(420, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(369, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email:";
            // 
            // maskedBirthDate
            // 
            this.maskedBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedBirthDate.Location = new System.Drawing.Point(420, 13);
            this.maskedBirthDate.Mask = "00.00.0000";
            this.maskedBirthDate.Name = "maskedBirthDate";
            this.maskedBirthDate.Size = new System.Drawing.Size(100, 22);
            this.maskedBirthDate.TabIndex = 4;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(329, 15);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(84, 16);
            this.lblBirthDate.TabIndex = 21;
            this.lblBirthDate.Text = "Doğum tarixi:";
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(420, 41);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 24);
            this.cmbGender.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(377, 44);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(36, 16);
            this.lblGender.TabIndex = 22;
            this.lblGender.Text = "Cins:";
            // 
            // txtFinCode
            // 
            this.txtFinCode.Location = new System.Drawing.Point(420, 100);
            this.txtFinCode.Name = "txtFinCode";
            this.txtFinCode.Size = new System.Drawing.Size(100, 22);
            this.txtFinCode.TabIndex = 7;
            // 
            // lblFinCode
            // 
            this.lblFinCode.AutoSize = true;
            this.lblFinCode.Location = new System.Drawing.Point(359, 103);
            this.lblFinCode.Name = "lblFinCode";
            this.lblFinCode.Size = new System.Drawing.Size(54, 16);
            this.lblFinCode.TabIndex = 24;
            this.lblFinCode.Text = "Fin kod:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(420, 128);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(195, 22);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(306, 131);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(107, 16);
            this.lblPhoneNumber.TabIndex = 25;
            this.lblPhoneNumber.Text = "Telefon nömrəsi:";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(1, 211);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(851, 236);
            this.dgvCustomers.TabIndex = 16;
            this.dgvCustomers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomers_CellMouseDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(537, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 50);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Yenilə";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(537, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Daxil et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(751, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 50);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Təmizlə";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(644, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 50);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Dəyiş";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(644, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 50);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCustIdn
            // 
            this.txtCustIdn.Location = new System.Drawing.Point(90, 9);
            this.txtCustIdn.Name = "txtCustIdn";
            this.txtCustIdn.Size = new System.Drawing.Size(116, 22);
            this.txtCustIdn.TabIndex = 0;
            this.txtCustIdn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustIdn_KeyPress);
            // 
            // lblCustIdn
            // 
            this.lblCustIdn.AutoSize = true;
            this.lblCustIdn.Location = new System.Drawing.Point(21, 12);
            this.lblCustIdn.Name = "lblCustIdn";
            this.lblCustIdn.Size = new System.Drawing.Size(64, 16);
            this.lblCustIdn.TabIndex = 17;
            this.lblCustIdn.Text = "Qeyd.No:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(751, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 50);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCustomerFullNameById
            // 
            this.btnCustomerFullNameById.Location = new System.Drawing.Point(751, 124);
            this.btnCustomerFullNameById.Name = "btnCustomerFullNameById";
            this.btnCustomerFullNameById.Size = new System.Drawing.Size(101, 50);
            this.btnCustomerFullNameById.TabIndex = 27;
            this.btnCustomerFullNameById.Text = "Tam ad";
            this.btnCustomerFullNameById.UseVisualStyleBackColor = true;
            this.btnCustomerFullNameById.Click += new System.EventHandler(this.btnCustomerFullNameById_Click);
            // 
            // lblCustFullNameById
            // 
            this.lblCustFullNameById.AutoSize = true;
            this.lblCustFullNameById.Location = new System.Drawing.Point(307, 188);
            this.lblCustFullNameById.Name = "lblCustFullNameById";
            this.lblCustFullNameById.Size = new System.Drawing.Size(97, 16);
            this.lblCustFullNameById.TabIndex = 28;
            this.lblCustFullNameById.Text = "Müştəri tam ad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.lblCustFullNameById);
            this.Controls.Add(this.btnCustomerFullNameById);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustIdn);
            this.Controls.Add(this.lblCustIdn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtFinCode);
            this.Controls.Add(this.lblFinCode);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.maskedBirthDate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDocNo);
            this.Controls.Add(this.lblDocNo);
            this.Controls.Add(this.txtBirthPlace);
            this.Controls.Add(this.lblBirthPlace);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.TextBox txtDocNo;
        private System.Windows.Forms.Label lblDocNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox maskedBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFinCode;
        private System.Windows.Forms.Label lblFinCode;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCustIdn;
        private System.Windows.Forms.Label lblCustIdn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCustomerFullNameById;
        private System.Windows.Forms.Label lblCustFullNameById;
    }
}


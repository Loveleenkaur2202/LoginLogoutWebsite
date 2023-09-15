namespace prjWinCsAllChapters
{
    partial class frmVideo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkId = new System.Windows.Forms.CheckBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCommonLaw = new System.Windows.Forms.RadioButton();
            this.radMarried = new System.Windows.Forms.RadioButton();
            this.radSeparated = new System.Windows.Forms.RadioButton();
            this.radSingle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radAmerican = new System.Windows.Forms.RadioButton();
            this.radMastercard = new System.Windows.Forms.RadioButton();
            this.radVisa = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRented = new System.Windows.Forms.Label();
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSpecial = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NETFLIX-LASALLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Full Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(146, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 25);
            this.txtName.TabIndex = 7;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(146, 118);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 68);
            this.txtAddress.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Client Address:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(146, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 25);
            this.txtPassword.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Client Password:";
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(331, 57);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(117, 27);
            this.btnValidate.TabIndex = 12;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Identity Proof:";
            // 
            // chkId
            // 
            this.chkId.AutoSize = true;
            this.chkId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkId.Location = new System.Drawing.Point(129, 199);
            this.chkId.Name = "chkId";
            this.chkId.Size = new System.Drawing.Size(15, 14);
            this.chkId.TabIndex = 14;
            this.chkId.UseVisualStyleBackColor = true;
            this.chkId.CheckedChanged += new System.EventHandler(this.chkId_CheckedChanged);
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(331, 90);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(117, 29);
            this.btnRent.TabIndex = 15;
            this.btnRent.Text = "Rent Movie";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCommonLaw);
            this.groupBox1.Controls.Add(this.radMarried);
            this.groupBox1.Controls.Add(this.radSeparated);
            this.groupBox1.Controls.Add(this.radSingle);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 145);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marital Status";
            // 
            // radCommonLaw
            // 
            this.radCommonLaw.AutoSize = true;
            this.radCommonLaw.Location = new System.Drawing.Point(24, 114);
            this.radCommonLaw.Name = "radCommonLaw";
            this.radCommonLaw.Size = new System.Drawing.Size(111, 21);
            this.radCommonLaw.TabIndex = 3;
            this.radCommonLaw.TabStop = true;
            this.radCommonLaw.Text = "Common Law";
            this.radCommonLaw.UseVisualStyleBackColor = true;
            // 
            // radMarried
            // 
            this.radMarried.AutoSize = true;
            this.radMarried.Location = new System.Drawing.Point(24, 56);
            this.radMarried.Name = "radMarried";
            this.radMarried.Size = new System.Drawing.Size(75, 21);
            this.radMarried.TabIndex = 2;
            this.radMarried.TabStop = true;
            this.radMarried.Text = "Married";
            this.radMarried.UseVisualStyleBackColor = true;
            // 
            // radSeparated
            // 
            this.radSeparated.AutoSize = true;
            this.radSeparated.Location = new System.Drawing.Point(24, 85);
            this.radSeparated.Name = "radSeparated";
            this.radSeparated.Size = new System.Drawing.Size(87, 21);
            this.radSeparated.TabIndex = 1;
            this.radSeparated.TabStop = true;
            this.radSeparated.Text = "Separated";
            this.radSeparated.UseVisualStyleBackColor = true;
            // 
            // radSingle
            // 
            this.radSingle.AutoSize = true;
            this.radSingle.Checked = true;
            this.radSingle.Location = new System.Drawing.Point(24, 27);
            this.radSingle.Name = "radSingle";
            this.radSingle.Size = new System.Drawing.Size(64, 21);
            this.radSingle.TabIndex = 0;
            this.radSingle.TabStop = true;
            this.radSingle.Text = "Single";
            this.radSingle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCardNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radAmerican);
            this.groupBox2.Controls.Add(this.radMastercard);
            this.groupBox2.Controls.Add(this.radVisa);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 162);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Payment";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(66, 117);
            this.txtCardNumber.MaxLength = 19;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(172, 23);
            this.txtCardNumber.TabIndex = 4;
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "N :";
            // 
            // radAmerican
            // 
            this.radAmerican.AutoSize = true;
            this.radAmerican.Location = new System.Drawing.Point(24, 56);
            this.radAmerican.Name = "radAmerican";
            this.radAmerican.Size = new System.Drawing.Size(132, 21);
            this.radAmerican.TabIndex = 2;
            this.radAmerican.TabStop = true;
            this.radAmerican.Text = "American Xpress";
            this.radAmerican.UseVisualStyleBackColor = true;
            // 
            // radMastercard
            // 
            this.radMastercard.AutoSize = true;
            this.radMastercard.Location = new System.Drawing.Point(24, 85);
            this.radMastercard.Name = "radMastercard";
            this.radMastercard.Size = new System.Drawing.Size(95, 21);
            this.radMastercard.TabIndex = 1;
            this.radMastercard.TabStop = true;
            this.radMastercard.Text = "Mastercard";
            this.radMastercard.UseVisualStyleBackColor = true;
            // 
            // radVisa
            // 
            this.radVisa.AutoSize = true;
            this.radVisa.Checked = true;
            this.radVisa.Location = new System.Drawing.Point(24, 27);
            this.radVisa.Name = "radVisa";
            this.radVisa.Size = new System.Drawing.Size(60, 21);
            this.radVisa.TabIndex = 0;
            this.radVisa.TabStop = true;
            this.radVisa.Text = "VISA";
            this.radVisa.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(163, 199);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 15);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Enter Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(252, 199);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(122, 20);
            this.txtTitle.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(380, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 29);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRented
            // 
            this.lblRented.AutoSize = true;
            this.lblRented.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRented.Location = new System.Drawing.Point(337, 237);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(90, 15);
            this.lblRented.TabIndex = 21;
            this.lblRented.Text = "Rented Movies:";
            // 
            // lstMovies
            // 
            this.lstMovies.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMovies.ForeColor = System.Drawing.Color.Navy;
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.ItemHeight = 15;
            this.lstMovies.Location = new System.Drawing.Point(343, 255);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(197, 124);
            this.lstMovies.TabIndex = 22;
            this.lstMovies.SelectedIndexChanged += new System.EventHandler(this.lstRented_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(331, 125);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 27);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return Movie\r\n";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Special of the day:\r\n";
            // 
            // cboSpecial
            // 
            this.cboSpecial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpecial.FormattingEnabled = true;
            this.cboSpecial.Location = new System.Drawing.Point(346, 401);
            this.cboSpecial.Name = "cboSpecial";
            this.cboSpecial.Size = new System.Drawing.Size(203, 23);
            this.cboSpecial.TabIndex = 25;
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(552, 544);
            this.Controls.Add(this.cboSpecial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.lblRented);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.chkId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVideo";
            this.Text = "frmVideo";
            this.Load += new System.EventHandler(this.frmVideo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkId;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCommonLaw;
        private System.Windows.Forms.RadioButton radMarried;
        private System.Windows.Forms.RadioButton radSeparated;
        private System.Windows.Forms.RadioButton radSingle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radAmerican;
        private System.Windows.Forms.RadioButton radMastercard;
        private System.Windows.Forms.RadioButton radVisa;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRented;
        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSpecial;
    }
}
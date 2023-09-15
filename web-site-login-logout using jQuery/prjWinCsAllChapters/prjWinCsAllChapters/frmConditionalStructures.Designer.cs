namespace prjWinCsAllChapters
{
    partial class frmConditionalStructures
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearNumeric = new System.Windows.Forms.Button();
            this.btnEvaluateNumeric = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGradeNumeric = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearAlpha = new System.Windows.Forms.Button();
            this.btnEvaluateAlpha = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGradeAlpha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LASALLE-COLLEGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your gender:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.Location = new System.Drawing.Point(135, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 22);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(152, 110);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(59, 20);
            this.radMale.TabIndex = 4;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(152, 136);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(77, 20);
            this.radFemale.TabIndex = 5;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnClearNumeric);
            this.groupBox1.Controls.Add(this.btnEvaluateNumeric);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGradeNumeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numeric to Alpha";
            // 
            // btnClearNumeric
            // 
            this.btnClearNumeric.Location = new System.Drawing.Point(151, 47);
            this.btnClearNumeric.Name = "btnClearNumeric";
            this.btnClearNumeric.Size = new System.Drawing.Size(66, 28);
            this.btnClearNumeric.TabIndex = 4;
            this.btnClearNumeric.Text = "Clear";
            this.btnClearNumeric.UseVisualStyleBackColor = true;
            this.btnClearNumeric.Click += new System.EventHandler(this.btnClearNumeric_Click);
            // 
            // btnEvaluateNumeric
            // 
            this.btnEvaluateNumeric.Location = new System.Drawing.Point(47, 47);
            this.btnEvaluateNumeric.Name = "btnEvaluateNumeric";
            this.btnEvaluateNumeric.Size = new System.Drawing.Size(79, 28);
            this.btnEvaluateNumeric.TabIndex = 3;
            this.btnEvaluateNumeric.Text = "Evaluate";
            this.btnEvaluateNumeric.UseVisualStyleBackColor = true;
            this.btnEvaluateNumeric.Click += new System.EventHandler(this.btnEvaluateNumeric_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "/100";
            // 
            // txtGradeNumeric
            // 
            this.txtGradeNumeric.ForeColor = System.Drawing.Color.Blue;
            this.txtGradeNumeric.Location = new System.Drawing.Point(147, 15);
            this.txtGradeNumeric.Name = "txtGradeNumeric";
            this.txtGradeNumeric.Size = new System.Drawing.Size(59, 22);
            this.txtGradeNumeric.TabIndex = 1;
//            this.txtGradeNumeric.TextChanged += new System.EventHandler(this.txtGradeNumeric_TextChanged);
            this.txtGradeNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradeNumeric_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter your grade:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnClearAlpha);
            this.groupBox2.Controls.Add(this.btnEvaluateAlpha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtGradeAlpha);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 88);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alpha to Numeric";
            // 
            // btnClearAlpha
            // 
            this.btnClearAlpha.Location = new System.Drawing.Point(151, 47);
            this.btnClearAlpha.Name = "btnClearAlpha";
            this.btnClearAlpha.Size = new System.Drawing.Size(66, 28);
            this.btnClearAlpha.TabIndex = 4;
            this.btnClearAlpha.Text = "Clear";
            this.btnClearAlpha.UseVisualStyleBackColor = true;
            this.btnClearAlpha.Click += new System.EventHandler(this.btnClearAlpha_Click);
            // 
            // btnEvaluateAlpha
            // 
            this.btnEvaluateAlpha.Location = new System.Drawing.Point(47, 47);
            this.btnEvaluateAlpha.Name = "btnEvaluateAlpha";
            this.btnEvaluateAlpha.Size = new System.Drawing.Size(79, 28);
            this.btnEvaluateAlpha.TabIndex = 3;
            this.btnEvaluateAlpha.Text = "Evaluate";
            this.btnEvaluateAlpha.UseVisualStyleBackColor = true;
            this.btnEvaluateAlpha.Click += new System.EventHandler(this.btnEvaluateAlpha_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "A to E";
            // 
            // txtGradeAlpha
            // 
            this.txtGradeAlpha.ForeColor = System.Drawing.Color.Blue;
            this.txtGradeAlpha.Location = new System.Drawing.Point(147, 15);
            this.txtGradeAlpha.Name = "txtGradeAlpha";
            this.txtGradeAlpha.Size = new System.Drawing.Size(59, 22);
            this.txtGradeAlpha.TabIndex = 1;
            this.txtGradeAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradeAlpha_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter your grade:";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(22, 373);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(287, 38);
            this.lblResult.TabIndex = 8;
            // 
            // frmConditionalStructures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 429);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConditionalStructures";
            this.Text = "frmConditionalStructures";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearNumeric;
        private System.Windows.Forms.Button btnEvaluateNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGradeNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearAlpha;
        private System.Windows.Forms.Button btnEvaluateAlpha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGradeAlpha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResult;
    }
}
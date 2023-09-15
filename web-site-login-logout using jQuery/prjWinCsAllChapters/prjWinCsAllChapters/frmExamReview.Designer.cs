namespace prjWinCsAllChapters
{
    partial class frmExamReview
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboQuestions = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radAnswer3 = new System.Windows.Forms.RadioButton();
            this.radAnswer2 = new System.Windows.Forms.RadioButton();
            this.radAnswer1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboQuestions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(344, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a question to start";
            // 
            // cboQuestions
            // 
            this.cboQuestions.FormattingEnabled = true;
            this.cboQuestions.Location = new System.Drawing.Point(8, 44);
            this.cboQuestions.Name = "cboQuestions";
            this.cboQuestions.Size = new System.Drawing.Size(318, 33);
            this.cboQuestions.TabIndex = 0;
            this.cboQuestions.SelectedIndexChanged += new System.EventHandler(this.cboQuestions_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radAnswer3);
            this.groupBox2.Controls.Add(this.radAnswer2);
            this.groupBox2.Controls.Add(this.radAnswer1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(344, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the right answer";
            // 
            // radAnswer3
            // 
            this.radAnswer3.AutoSize = true;
            this.radAnswer3.Location = new System.Drawing.Point(32, 104);
            this.radAnswer3.Name = "radAnswer3";
            this.radAnswer3.Size = new System.Drawing.Size(155, 29);
            this.radAnswer3.TabIndex = 2;
            this.radAnswer3.TabStop = true;
            this.radAnswer3.Text = "radioButton3";
            this.radAnswer3.UseVisualStyleBackColor = true;
            this.radAnswer3.CheckedChanged += new System.EventHandler(this.radAnswer3_CheckedChanged);
            // 
            // radAnswer2
            // 
            this.radAnswer2.AutoSize = true;
            this.radAnswer2.Location = new System.Drawing.Point(32, 74);
            this.radAnswer2.Name = "radAnswer2";
            this.radAnswer2.Size = new System.Drawing.Size(155, 29);
            this.radAnswer2.TabIndex = 1;
            this.radAnswer2.TabStop = true;
            this.radAnswer2.Text = "radioButton2";
            this.radAnswer2.UseVisualStyleBackColor = true;
            this.radAnswer2.CheckedChanged += new System.EventHandler(this.radAnswer2_CheckedChanged);
            // 
            // radAnswer1
            // 
            this.radAnswer1.AutoSize = true;
            this.radAnswer1.Location = new System.Drawing.Point(32, 44);
            this.radAnswer1.Name = "radAnswer1";
            this.radAnswer1.Size = new System.Drawing.Size(155, 29);
            this.radAnswer1.TabIndex = 0;
            this.radAnswer1.TabStop = true;
            this.radAnswer1.Text = "radioButton1";
            this.radAnswer1.UseVisualStyleBackColor = true;
            this.radAnswer1.CheckedChanged += new System.EventHandler(this.radAnswer1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 312);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(351, 80);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evaluation of your answer";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(27, 31);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(316, 25);
            this.lblResult.TabIndex = 0;
            // 
            // frmExamReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 407);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmExamReview";
            this.Text = "frmExamReview";
            this.Load += new System.EventHandler(this.frmExamReview_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboQuestions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radAnswer3;
        private System.Windows.Forms.RadioButton radAnswer2;
        private System.Windows.Forms.RadioButton radAnswer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResult;
    }
}
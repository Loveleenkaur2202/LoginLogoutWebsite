namespace prjWinCsAllChapters
{
    partial class frmCondition
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
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radModulo = new System.Windows.Forms.RadioButton();
            this.radDivision = new System.Windows.Forms.RadioButton();
            this.radSubstraction = new System.Windows.Forms.RadioButton();
            this.radMultiplication = new System.Windows.Forms.RadioButton();
            this.radAddition = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGreaterEqual = new System.Windows.Forms.RadioButton();
            this.radSmallerEqual = new System.Windows.Forms.RadioButton();
            this.radNotEqual = new System.Windows.Forms.RadioButton();
            this.radGreater = new System.Windows.Forms.RadioButton();
            this.radSmaller = new System.Windows.Forms.RadioButton();
            this.radEqual = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value 2:";
            // 
            // txtValue1
            // 
            this.txtValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue1.ForeColor = System.Drawing.Color.Blue;
            this.txtValue1.Location = new System.Drawing.Point(86, 58);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(75, 22);
            this.txtValue1.TabIndex = 2;
            this.txtValue1.TextChanged += new System.EventHandler(this.txtValue1_TextChanged);
            this.txtValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue1_KeyPress);
            // 
            // txtValue2
            // 
            this.txtValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue2.ForeColor = System.Drawing.Color.Blue;
            this.txtValue2.Location = new System.Drawing.Point(336, 58);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(75, 22);
            this.txtValue2.TabIndex = 3;
            this.txtValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue2_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radModulo);
            this.groupBox1.Controls.Add(this.radDivision);
            this.groupBox1.Controls.Add(this.radSubstraction);
            this.groupBox1.Controls.Add(this.radMultiplication);
            this.groupBox1.Controls.Add(this.radAddition);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arithmetics:";
            // 
            // radModulo
            // 
            this.radModulo.AutoSize = true;
            this.radModulo.Location = new System.Drawing.Point(161, 82);
            this.radModulo.Name = "radModulo";
            this.radModulo.Size = new System.Drawing.Size(76, 20);
            this.radModulo.TabIndex = 12;
            this.radModulo.Text = "Modulo";
            this.radModulo.UseVisualStyleBackColor = true;
            // 
            // radDivision
            // 
            this.radDivision.AutoSize = true;
            this.radDivision.Location = new System.Drawing.Point(211, 56);
            this.radDivision.Name = "radDivision";
            this.radDivision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radDivision.Size = new System.Drawing.Size(81, 20);
            this.radDivision.TabIndex = 11;
            this.radDivision.Text = "Division";
            this.radDivision.UseVisualStyleBackColor = true;
            // 
            // radSubstraction
            // 
            this.radSubstraction.AutoSize = true;
            this.radSubstraction.Location = new System.Drawing.Point(211, 30);
            this.radSubstraction.Name = "radSubstraction";
            this.radSubstraction.Size = new System.Drawing.Size(111, 20);
            this.radSubstraction.TabIndex = 10;
            this.radSubstraction.Text = "Substraction";
            this.radSubstraction.UseVisualStyleBackColor = true;
            // 
            // radMultiplication
            // 
            this.radMultiplication.AutoSize = true;
            this.radMultiplication.Location = new System.Drawing.Point(81, 56);
            this.radMultiplication.Name = "radMultiplication";
            this.radMultiplication.Size = new System.Drawing.Size(116, 20);
            this.radMultiplication.TabIndex = 9;
            this.radMultiplication.Text = "Multiplication";
            this.radMultiplication.UseVisualStyleBackColor = true;
            // 
            // radAddition
            // 
            this.radAddition.AutoSize = true;
            this.radAddition.Checked = true;
            this.radAddition.Location = new System.Drawing.Point(84, 30);
            this.radAddition.Name = "radAddition";
            this.radAddition.Size = new System.Drawing.Size(82, 20);
            this.radAddition.TabIndex = 8;
            this.radAddition.TabStop = true;
            this.radAddition.Text = "Addition";
            this.radAddition.UseVisualStyleBackColor = true;
            this.radAddition.CheckedChanged += new System.EventHandler(this.radAddition_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.radGreaterEqual);
            this.groupBox2.Controls.Add(this.radSmallerEqual);
            this.groupBox2.Controls.Add(this.radNotEqual);
            this.groupBox2.Controls.Add(this.radGreater);
            this.groupBox2.Controls.Add(this.radSmaller);
            this.groupBox2.Controls.Add(this.radEqual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 114);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compaison:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radGreaterEqual
            // 
            this.radGreaterEqual.AutoSize = true;
            this.radGreaterEqual.Location = new System.Drawing.Point(216, 88);
            this.radGreaterEqual.Name = "radGreaterEqual";
            this.radGreaterEqual.Size = new System.Drawing.Size(171, 20);
            this.radGreaterEqual.TabIndex = 13;
            this.radGreaterEqual.TabStop = true;
            this.radGreaterEqual.Text = "Greater than or equal";
            this.radGreaterEqual.UseVisualStyleBackColor = true;
            this.radGreaterEqual.CheckedChanged += new System.EventHandler(this.radGreaterEqual_CheckedChanged);
            // 
            // radSmallerEqual
            // 
            this.radSmallerEqual.AutoSize = true;
            this.radSmallerEqual.Location = new System.Drawing.Point(25, 88);
            this.radSmallerEqual.Name = "radSmallerEqual";
            this.radSmallerEqual.Size = new System.Drawing.Size(172, 20);
            this.radSmallerEqual.TabIndex = 12;
            this.radSmallerEqual.TabStop = true;
            this.radSmallerEqual.Text = "Smaller than or equal";
            this.radSmallerEqual.UseVisualStyleBackColor = true;
            // 
            // radNotEqual
            // 
            this.radNotEqual.AutoSize = true;
            this.radNotEqual.Location = new System.Drawing.Point(216, 35);
            this.radNotEqual.Name = "radNotEqual";
            this.radNotEqual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radNotEqual.Size = new System.Drawing.Size(93, 20);
            this.radNotEqual.TabIndex = 11;
            this.radNotEqual.TabStop = true;
            this.radNotEqual.Text = "Not Equal";
            this.radNotEqual.UseVisualStyleBackColor = true;
            // 
            // radGreater
            // 
            this.radGreater.AutoSize = true;
            this.radGreater.Location = new System.Drawing.Point(216, 61);
            this.radGreater.Name = "radGreater";
            this.radGreater.Size = new System.Drawing.Size(77, 20);
            this.radGreater.TabIndex = 10;
            this.radGreater.TabStop = true;
            this.radGreater.Text = "Greater";
            this.radGreater.UseVisualStyleBackColor = true;
            // 
            // radSmaller
            // 
            this.radSmaller.AutoSize = true;
            this.radSmaller.Location = new System.Drawing.Point(25, 61);
            this.radSmaller.Name = "radSmaller";
            this.radSmaller.Size = new System.Drawing.Size(78, 20);
            this.radSmaller.TabIndex = 9;
            this.radSmaller.TabStop = true;
            this.radSmaller.Text = "Smaller";
            this.radSmaller.UseVisualStyleBackColor = true;
            // 
            // radEqual
            // 
            this.radEqual.AutoSize = true;
            this.radEqual.Location = new System.Drawing.Point(25, 35);
            this.radEqual.Name = "radEqual";
            this.radEqual.Size = new System.Drawing.Size(65, 20);
            this.radEqual.TabIndex = 8;
            this.radEqual.TabStop = true;
            this.radEqual.Text = "Equal";
            this.radEqual.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(20, 402);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(387, 43);
            this.lblResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(101, 357);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 27);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Execute";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(236, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "CALCULATOR 2.0";
            // 
            // frmCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCondition";
            this.Text = "frmCondition";
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
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radModulo;
        private System.Windows.Forms.RadioButton radDivision;
        private System.Windows.Forms.RadioButton radSubstraction;
        private System.Windows.Forms.RadioButton radMultiplication;
        private System.Windows.Forms.RadioButton radAddition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radNotEqual;
        private System.Windows.Forms.RadioButton radGreater;
        private System.Windows.Forms.RadioButton radSmaller;
        private System.Windows.Forms.RadioButton radEqual;
        private System.Windows.Forms.Label lblResult;
        //private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radGreaterEqual;
        private System.Windows.Forms.RadioButton radSmallerEqual;
        private System.Windows.Forms.Label label3;
    }
}
namespace prjWinCsAllChapters
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaptersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperators = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConditions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConditionalStructures = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimeSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaptersToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnuQuit});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // chaptersToolStripMenuItem
            // 
            this.chaptersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOperators,
            this.mnuConditions,
            this.mnuConditionalStructures});
            this.chaptersToolStripMenuItem.Name = "chaptersToolStripMenuItem";
            this.chaptersToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.chaptersToolStripMenuItem.Text = "Chapters";
            // 
            // mnuOperators
            // 
            this.mnuOperators.Name = "mnuOperators";
            this.mnuOperators.Size = new System.Drawing.Size(238, 26);
            this.mnuOperators.Text = "Basic Operators";
            this.mnuOperators.Click += new System.EventHandler(this.mnuOperators_Click);
            // 
            // mnuConditions
            // 
            this.mnuConditions.Name = "mnuConditions";
            this.mnuConditions.Size = new System.Drawing.Size(238, 26);
            this.mnuConditions.Text = "Conditions";
            this.mnuConditions.Click += new System.EventHandler(this.mnuConditions_Click);
            // 
            // mnuConditionalStructures
            // 
            this.mnuConditionalStructures.Name = "mnuConditionalStructures";
            this.mnuConditionalStructures.Size = new System.Drawing.Size(238, 26);
            this.mnuConditionalStructures.Text = "Conditional Structures";
            this.mnuConditionalStructures.Click += new System.EventHandler(this.mnuConditionalStructures_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVideo,
            this.mnuBook,
            this.mnuTimeSheet});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // mnuVideo
            // 
            this.mnuVideo.Name = "mnuVideo";
            this.mnuVideo.Size = new System.Drawing.Size(174, 26);
            this.mnuVideo.Text = "Video Store ";
            this.mnuVideo.Click += new System.EventHandler(this.mnuVideo_Click);
            // 
            // mnuBook
            // 
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Size = new System.Drawing.Size(174, 26);
            this.mnuBook.Text = "Adress Book";
            this.mnuBook.Click += new System.EventHandler(this.mnuBook_Click);
            // 
            // mnuTimeSheet
            // 
            this.mnuTimeSheet.Name = "mnuTimeSheet";
            this.mnuTimeSheet.Size = new System.Drawing.Size(174, 26);
            this.mnuTimeSheet.Text = "TimeSheet";
            this.mnuTimeSheet.Click += new System.EventHandler(this.mnuTimeSheet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuQuit.Size = new System.Drawing.Size(167, 26);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Lasalle College 420-CT2-AS O. O. Programming";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaptersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOperators;
        private System.Windows.Forms.ToolStripMenuItem mnuConditions;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuVideo;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuConditionalStructures;
        private System.Windows.Forms.ToolStripMenuItem mnuTimeSheet;
    }
}
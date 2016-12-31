namespace Diceware.NET
{
    partial class MainWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDicewareNETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicatesAllowedCheck = new System.Windows.Forms.CheckBox();
            this.stringGenerateNumberControl = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stringGenerateNumberControl)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 303);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number to Generate:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createPasswordToolStripMenuItem
            // 
            this.createPasswordToolStripMenuItem.Name = "createPasswordToolStripMenuItem";
            this.createPasswordToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.createPasswordToolStripMenuItem.Text = "Create Password";
            this.createPasswordToolStripMenuItem.Click += new System.EventHandler(this.createPasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDicewareNETToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutDicewareNETToolStripMenuItem
            // 
            this.aboutDicewareNETToolStripMenuItem.Name = "aboutDicewareNETToolStripMenuItem";
            this.aboutDicewareNETToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aboutDicewareNETToolStripMenuItem.Text = "About Diceware.NET";
            this.aboutDicewareNETToolStripMenuItem.Click += new System.EventHandler(this.aboutDicewareNETToolStripMenuItem_Click);
            // 
            // duplicatesAllowedCheck
            // 
            this.duplicatesAllowedCheck.AutoSize = true;
            this.duplicatesAllowedCheck.Location = new System.Drawing.Point(15, 361);
            this.duplicatesAllowedCheck.Name = "duplicatesAllowedCheck";
            this.duplicatesAllowedCheck.Size = new System.Drawing.Size(104, 17);
            this.duplicatesAllowedCheck.TabIndex = 6;
            this.duplicatesAllowedCheck.Text = "Allow Duplicates";
            this.duplicatesAllowedCheck.UseVisualStyleBackColor = true;
            // 
            // stringGenerateNumberControl
            // 
            this.stringGenerateNumberControl.Location = new System.Drawing.Point(122, 336);
            this.stringGenerateNumberControl.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.stringGenerateNumberControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stringGenerateNumberControl.Name = "stringGenerateNumberControl";
            this.stringGenerateNumberControl.Size = new System.Drawing.Size(154, 20);
            this.stringGenerateNumberControl.TabIndex = 7;
            this.stringGenerateNumberControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stringGenerateNumberControl.ValueChanged += new System.EventHandler(this.stringGenerateNumberControl_ValueChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 435);
            this.Controls.Add(this.stringGenerateNumberControl);
            this.Controls.Add(this.duplicatesAllowedCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Diceware.NET";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stringGenerateNumberControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDicewareNETToolStripMenuItem;
        private System.Windows.Forms.CheckBox duplicatesAllowedCheck;
        private System.Windows.Forms.NumericUpDown stringGenerateNumberControl;
    }
}


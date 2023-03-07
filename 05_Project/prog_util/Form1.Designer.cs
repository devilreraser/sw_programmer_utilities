namespace prog_util
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
            splitContainer1 = new SplitContainer();
            inputText = new TextBox();
            outputText = new TextBox();
            menuStrip = new MenuStrip();
            menuTextToTable = new ToolStripMenuItem();
            columnsToolStripMenuItem = new ToolStripMenuItem();
            columnsTextToTableToolStripMenuItem = new ToolStripTextBox();
            executeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(inputText);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(outputText);
            splitContainer1.Size = new Size(700, 314);
            splitContainer1.SplitterDistance = 349;
            splitContainer1.TabIndex = 1;
            // 
            // inputText
            // 
            inputText.AcceptsReturn = true;
            inputText.AcceptsTab = true;
            inputText.Dock = DockStyle.Fill;
            inputText.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputText.Location = new Point(0, 0);
            inputText.Multiline = true;
            inputText.Name = "inputText";
            inputText.ScrollBars = ScrollBars.Vertical;
            inputText.Size = new Size(349, 314);
            inputText.TabIndex = 0;
            // 
            // outputText
            // 
            outputText.AcceptsReturn = true;
            outputText.AcceptsTab = true;
            outputText.Dock = DockStyle.Fill;
            outputText.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            outputText.Location = new Point(0, 0);
            outputText.Multiline = true;
            outputText.Name = "outputText";
            outputText.ScrollBars = ScrollBars.Vertical;
            outputText.Size = new Size(347, 314);
            outputText.TabIndex = 1;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuTextToTable });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(700, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip";
            // 
            // menuTextToTable
            // 
            menuTextToTable.DropDownItems.AddRange(new ToolStripItem[] { columnsToolStripMenuItem, executeToolStripMenuItem });
            menuTextToTable.Name = "menuTextToTable";
            menuTextToTable.Size = new Size(85, 20);
            menuTextToTable.Text = "Text To Table";
            // 
            // columnsToolStripMenuItem
            // 
            columnsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { columnsTextToTableToolStripMenuItem });
            columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            columnsToolStripMenuItem.Size = new Size(122, 22);
            columnsToolStripMenuItem.Text = "Columns";
            // 
            // columnsTextToTableToolStripMenuItem
            // 
            columnsTextToTableToolStripMenuItem.Name = "columnsTextToTableToolStripMenuItem";
            columnsTextToTableToolStripMenuItem.Size = new Size(180, 23);
            columnsTextToTableToolStripMenuItem.Text = "0";
            // 
            // executeToolStripMenuItem
            // 
            executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            executeToolStripMenuItem.Size = new Size(122, 22);
            executeToolStripMenuItem.Text = "Execute";
            executeToolStripMenuItem.Click += executeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip;
        private TextBox inputText;
        private TextBox outputText;
        private ToolStripMenuItem menuTextToTable;
        private ToolStripMenuItem columnsToolStripMenuItem;
        private ToolStripTextBox columnsTextToTableToolStripMenuItem;
        private ToolStripMenuItem executeToolStripMenuItem;
    }
}
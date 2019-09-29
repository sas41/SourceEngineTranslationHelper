namespace SourceEngineTranslationHelper
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.toolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTranslationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTranslationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_ProjectLanguage = new System.Windows.Forms.TextBox();
            this.label_ProjectName = new System.Windows.Forms.Label();
            this.label_ProjectLanguage = new System.Windows.Forms.Label();
            this.textBox_ProjectName = new System.Windows.Forms.TextBox();
            this.toolStrip_Main.SuspendLayout();
            this.contextMenuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_Main
            // 
            this.toolStrip_Main.ContextMenuStrip = this.contextMenuStrip_Main;
            this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton_File});
            this.toolStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Main.Name = "toolStrip_Main";
            this.toolStrip_Main.Size = new System.Drawing.Size(1001, 25);
            this.toolStrip_Main.TabIndex = 0;
            this.toolStrip_Main.Text = "toolStrip1";
            // 
            // contextMenuStrip_Main
            // 
            this.contextMenuStrip_Main.AllowDrop = true;
            this.contextMenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRowToolStripMenuItem});
            this.contextMenuStrip_Main.Name = "contextMenuStrip_Main";
            this.contextMenuStrip_Main.Size = new System.Drawing.Size(150, 26);
            // 
            // addNewRowToolStripMenuItem
            // 
            this.addNewRowToolStripMenuItem.Name = "addNewRowToolStripMenuItem";
            this.addNewRowToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addNewRowToolStripMenuItem.Text = "Add New Row";
            this.addNewRowToolStripMenuItem.Click += new System.EventHandler(this.AddNewRowToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton_File
            // 
            this.toolStripDropDownButton_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.importTranslationToolStripMenuItem,
            this.exportTranslationToolStripMenuItem,
            this.importJSONToolStripMenuItem,
            this.exportJSONToolStripMenuItem});
            this.toolStripDropDownButton_File.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_File.Image")));
            this.toolStripDropDownButton_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_File.Name = "toolStripDropDownButton_File";
            this.toolStripDropDownButton_File.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton_File.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Click);
            // 
            // importTranslationToolStripMenuItem
            // 
            this.importTranslationToolStripMenuItem.Name = "importTranslationToolStripMenuItem";
            this.importTranslationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importTranslationToolStripMenuItem.Text = "Import Translation";
            this.importTranslationToolStripMenuItem.Click += new System.EventHandler(this.ImportTranslationToolStripMenuItem_Click);
            // 
            // exportTranslationToolStripMenuItem
            // 
            this.exportTranslationToolStripMenuItem.Name = "exportTranslationToolStripMenuItem";
            this.exportTranslationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exportTranslationToolStripMenuItem.Text = "Export Translation";
            this.exportTranslationToolStripMenuItem.Click += new System.EventHandler(this.ExportTranslationToolStripMenuItem_Click);
            // 
            // importJSONToolStripMenuItem
            // 
            this.importJSONToolStripMenuItem.Name = "importJSONToolStripMenuItem";
            this.importJSONToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importJSONToolStripMenuItem.Text = "Import JSON";
            this.importJSONToolStripMenuItem.Click += new System.EventHandler(this.ImportJSONToolStripMenuItem_Click);
            // 
            // exportJSONToolStripMenuItem
            // 
            this.exportJSONToolStripMenuItem.Name = "exportJSONToolStripMenuItem";
            this.exportJSONToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exportJSONToolStripMenuItem.Text = "Export JSON";
            this.exportJSONToolStripMenuItem.Click += new System.EventHandler(this.ExportJSONToolStripMenuItem_Click);
            // 
            // dataGridView_Main
            // 
            this.dataGridView_Main.AllowUserToOrderColumns = true;
            this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Main.ContextMenuStrip = this.contextMenuStrip_Main;
            this.dataGridView_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Main.Location = new System.Drawing.Point(3, 44);
            this.dataGridView_Main.Name = "dataGridView_Main";
            this.dataGridView_Main.Size = new System.Drawing.Size(995, 566);
            this.dataGridView_Main.TabIndex = 1;
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Main.Controls.Add(this.dataGridView_Main, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1001, 613);
            this.tableLayoutPanel_Main.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBox_ProjectLanguage, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_ProjectName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_ProjectLanguage, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ProjectName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 35);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBox_ProjectLanguage
            // 
            this.textBox_ProjectLanguage.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_ProjectLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ProjectLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProjectLanguage.Location = new System.Drawing.Point(505, 3);
            this.textBox_ProjectLanguage.MaximumSize = new System.Drawing.Size(250, 26);
            this.textBox_ProjectLanguage.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBox_ProjectLanguage.Name = "textBox_ProjectLanguage";
            this.textBox_ProjectLanguage.Size = new System.Drawing.Size(250, 26);
            this.textBox_ProjectLanguage.TabIndex = 3;
            this.textBox_ProjectLanguage.TextChanged += new System.EventHandler(this.TextBox_ProjectLanguage_TextChanged);
            // 
            // label_ProjectName
            // 
            this.label_ProjectName.AutoEllipsis = true;
            this.label_ProjectName.AutoSize = true;
            this.label_ProjectName.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProjectName.Location = new System.Drawing.Point(0, 0);
            this.label_ProjectName.Margin = new System.Windows.Forms.Padding(0);
            this.label_ProjectName.Name = "label_ProjectName";
            this.label_ProjectName.Size = new System.Drawing.Size(108, 35);
            this.label_ProjectName.TabIndex = 0;
            this.label_ProjectName.Text = "Project Name:";
            // 
            // label_ProjectLanguage
            // 
            this.label_ProjectLanguage.AutoEllipsis = true;
            this.label_ProjectLanguage.AutoSize = true;
            this.label_ProjectLanguage.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_ProjectLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProjectLanguage.Location = new System.Drawing.Point(364, 0);
            this.label_ProjectLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.label_ProjectLanguage.Name = "label_ProjectLanguage";
            this.label_ProjectLanguage.Size = new System.Drawing.Size(138, 35);
            this.label_ProjectLanguage.TabIndex = 1;
            this.label_ProjectLanguage.Text = "Project Language:";
            // 
            // textBox_ProjectName
            // 
            this.textBox_ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProjectName.Location = new System.Drawing.Point(111, 3);
            this.textBox_ProjectName.MaximumSize = new System.Drawing.Size(250, 26);
            this.textBox_ProjectName.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBox_ProjectName.Name = "textBox_ProjectName";
            this.textBox_ProjectName.Size = new System.Drawing.Size(250, 26);
            this.textBox_ProjectName.TabIndex = 2;
            this.textBox_ProjectName.TextChanged += new System.EventHandler(this.TextBox_ProjectName_TextChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 638);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Controls.Add(this.toolStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "Source Engine Translation Helper";
            this.toolStrip_Main.ResumeLayout(false);
            this.toolStrip_Main.PerformLayout();
            this.contextMenuStrip_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_Main;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_File;
        private System.Windows.Forms.ToolStripMenuItem importJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTranslationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem addNewRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_ProjectLanguage;
        private System.Windows.Forms.Label label_ProjectName;
        private System.Windows.Forms.Label label_ProjectLanguage;
        private System.Windows.Forms.TextBox textBox_ProjectName;
        private System.Windows.Forms.ToolStripMenuItem importTranslationToolStripMenuItem;
    }
}

